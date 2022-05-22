using Conexion_con_MySQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Conexion_con_MySQL.Validaciones;

namespace Conexion_Con_MySQL
{
    public partial class FormProductos : Form
    {
        MySqlConnection conexionBD;
        MySqlDataReader reader;
        MySqlCommand comando;
        public FormProductos()
        {
            InitializeComponent();
            textBoxDesc.Enabled = false;
            textBoxExit.Enabled = false;
            textBoxPrecio.Enabled = false;
            buttonInsertar.Enabled = false;
            buttonActualizar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonLimpiar.Enabled = false;
        }

        // APLICAMOS LAS VALIDACIONES

        private void textBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validaciones.SoloInt(e.KeyChar));
        }

        private void textBoxExit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validaciones.SoloInt(e.KeyChar));
        }

        private void textBoxDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validaciones.SoloLetras(e.KeyChar));
        }

        private void textBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Convert.ToChar(Validaciones.SoloDoubles(e.KeyChar));
        }

        // INICIO DEL BOTON BUSCAR

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            reader = null; //Variable para leer el resultado de la consulta
            textBoxCodigo.Enabled = false;
            
            conexionBD = ConexionDB.Conexion();

            try
            {
                string consulta = "SELECT * FROM producto " +
                    "WHERE codigo='" + textBoxCodigo.Text + "' AND estatus='A'";

                comando = new MySqlCommand(consulta);
                comando.Connection = conexionBD;
                conexionBD.Open();

                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBoxDesc.Text = reader.GetString(1);
                        textBoxExit.Text = reader.GetString(2);
                        textBoxPrecio.Text = reader.GetString(3).Replace(',','.');
                    }
                    MessageBox.Show("Registro encontrado");
                    buttonBuscar.Enabled = false;
                    buttonActualizar.Enabled = true;
                    buttonEliminar.Enabled = true;
                    buttonLimpiar.Enabled = true;
                    buttonInsertar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                    this.buttonLimpiar_Click(sender, e);
                    buttonInsertar.Enabled = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
                this.buttonLimpiar_Click(sender, e);
            }

            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }

        // FIN DEL BOTON BUSCAR

        //INICIO DEL BOTON INSERTAR
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            this.buttonLimpiar_Click(sender, e);

            textBoxDesc.Enabled = true;
            textBoxExit.Enabled = true;
            textBoxPrecio.Enabled = true;
            buttonBuscar.Enabled = false;
            buttonLimpiar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonActualizar.Enabled = false;
            buttonInsertar.Hide();
            btnAcepInsert.Show();
            btnCancInsert.Show();
        }

            // boton para cancelar la insercion
        private void btnCancInsert_Click(object sender, EventArgs e)
        {
            btnAcepInsert.Hide();
            btnCancInsert.Hide();
            buttonInsertar.Show();
            buttonInsertar.Enabled = false;
            textBoxDesc.Enabled = false;
            textBoxExit.Enabled = false;
            textBoxPrecio.Enabled = false;

            this.buttonLimpiar_Click(sender, e);
        }

        // boton para aceptar la insercion
        private void btnAcepInsert_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != ""
                && textBoxDesc.Text != "" 
                && textBoxExit.Text != "" 
                && textBoxPrecio.Text != "")
            {
                string codigo = textBoxCodigo.Text;
                string desc = textBoxDesc.Text;
                int existencia = Convert.ToInt32(textBoxExit.Text);
             

                string insercion = "INSERT INTO producto " +
                "(codigo, descripcion, existencia, precio, estatus) " +
                "VALUES " +
                "('" + codigo + "','" + desc + "','" + existencia + "','" + textBoxPrecio.Text + "','A' )";

                conexionBD = ConexionDB.Conexion();
                conexionBD.Open();
                try
                {
                    MySqlCommand comando = new MySqlCommand(insercion, conexionBD);
                    comando.Connection = conexionBD;
                    comando.ExecuteNonQuery();
                    MessageBox.Show("El producto '" + codigo + "' ha sido insertado exitosamente");
                    this.buttonLimpiar_Click(sender, e);
                    buttonBuscar.Enabled = false;
                   
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("El producto'" + codigo + "'ya existe", "Error de insercion de datos");
                        this.buttonLimpiar_Click(sender, e);
                        buttonBuscar.Enabled = false;
                        
                    }
                    MessageBox.Show("Error de inserción:" + ex.Message);
                    this.buttonLimpiar_Click(sender, e);
                    buttonBuscar.Enabled = false;


                }
                finally
                {
                    conexionBD.Close(); /* cierra la conexion con la Base de datoS*/
                }
            } else
            {
                MessageBox.Show("Llene todos los campos");
            }
        }


        // FIN DEL BOTON INSERTAR

        // INICIO DEL BOTON LIMPIAR

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Clear();
            textBoxCodigo.Enabled = true;
            textBoxDesc.Clear();
            textBoxExit.Clear();
            textBoxPrecio.Clear();
            buttonLimpiar.Enabled = false;
            buttonActualizar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonInsertar.Enabled = false;
            buttonBuscar.Enabled = true;
        }

        // FIN DEL BOTON LIMPIAR
        

        // INICIO DEL BOTON ACTUALIZAR

        string descripcion_original;
        string existencias_originales;
        string precio_original;

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            // guardamos los datos por si hay que cancelar la actualizacion
            descripcion_original = textBoxDesc.Text;
            existencias_originales = textBoxExit.Text;
            precio_original = textBoxPrecio.Text;
            
            textBoxDesc.Enabled = true;
            textBoxExit.Enabled = true;
            textBoxPrecio.Enabled = true;
            buttonBuscar.Enabled = false;
            buttonLimpiar.Enabled = false;
            buttonEliminar.Enabled = false;
            buttonInsertar.Enabled = false;
            buttonActualizar.Hide();
            buttonAceptarActualizacion.Show();
            buttonCancelarActualizacion.Show();
        }

            // boton para cancelar la actualizacion

        private void buttonCancelarActualizacion_Click(object sender, EventArgs e)
        {
            // devolvemos a los datos originales
            textBoxDesc.Text = descripcion_original;
            textBoxExit.Text = existencias_originales;
            textBoxPrecio.Text = precio_original;

            textBoxDesc.Enabled = false;
            textBoxExit.Enabled = false;
            textBoxPrecio.Enabled = false;
            buttonBuscar.Enabled = true;
            buttonLimpiar.Enabled = true;
            buttonEliminar.Enabled = true;
            buttonInsertar.Enabled = true;

            buttonActualizar.Show();
            buttonAceptarActualizacion.Hide();
            buttonCancelarActualizacion.Hide();
        }

        // boton para aceptar la actualizacion

        private void buttonAceptarActualizacion_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != ""
                && textBoxDesc.Text != ""
                && textBoxExit.Text != ""
                && textBoxPrecio.Text != "")
            {
                string descripcion = textBoxDesc.Text;
                int existencia = int.Parse(textBoxExit.Text);

                string actualizar = "UPDATE producto SET " +
                    "descripcion = '" + descripcion + "', " +
                    "existencia = '" + existencia + "', " +
                    "precio = '" + textBoxPrecio.Text + "' " +
                    "WHERE codigo='" + textBoxCodigo.Text + "' AND estatus='A'";

                conexionBD = ConexionDB.Conexion();
                conexionBD.Open();

                try
                {
                    comando = new MySqlCommand(actualizar);
                    comando.Connection = conexionBD;
                    comando.ExecuteNonQuery();

                    textBoxDesc.Enabled = false;
                    textBoxExit.Enabled = false;
                    textBoxPrecio.Enabled = false;

                    buttonBuscar.Enabled = false;
                    buttonLimpiar.Enabled = true;
                    buttonEliminar.Enabled = true;
                    buttonInsertar.Enabled = false;

                    buttonActualizar.Show();
                    buttonAceptarActualizacion.Hide();
                    buttonCancelarActualizacion.Hide();

                    MessageBox.Show("Registro Actualizado");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al Actualizar " + ex.Message);
                    this.buttonCancelarActualizacion_Click(sender, e);
                }

                finally
                {
                    conexionBD.Close(); //Cierra la conexión a MySQL
                }
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacíos");
            }
        
        }

        // FIN DEL BOTON ACTUALIZAR

        // INICIO DEL BOTON ELIMINAR
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "UPDATE producto SET estatus = 'I' " +
                "WHERE codigo='" + textBoxCodigo.Text + "' AND estatus='A'";

            conexionBD = ConexionDB.Conexion();
            conexionBD.Open();

            try
            {
                comando = new MySqlCommand(eliminar);
                comando.Connection = conexionBD;
                comando.ExecuteNonQuery();

                this.buttonLimpiar_Click(sender, e);

                MessageBox.Show("Registro Eliminado");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al Eliminar " + ex.Message);
            }

            finally
            {
                conexionBD.Close(); //Cierra la conexión a MySQL
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        // FIN DEL BOTON ELIMINAR

    }
}
