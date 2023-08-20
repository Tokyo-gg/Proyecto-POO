using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_POO
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection;
        private OleDbDataAdapter dataAdapter;
        private DataSet dataSet;
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            EnableNavigationButtons();
        }

        private void InitializeDatabase()
        {
            // Define la cadena de conexión para la base de datos Access
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Contactos.accdb;";

            // Crea una nueva conexión OleDb utilizando la cadena de conexión
            connection = new OleDbConnection(connectionString);

            // Crea un adaptador OleDbDataAdapter para realizar operaciones de lectura y escritura en la base de datos
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Contactos", connection);

            // Configurar el comando INSERT para agregar nuevos registros
            //dataAdapter.InsertCommand = new OleDbCommand("INSERT INTO Contactos (Primer Nombre, Apellido, Email, Telefono) VALUES (@Primer Nombre, @Apellido, @Email, @Telefono)", connection);
            dataAdapter.InsertCommand = new OleDbCommand("INSERT INTO Contactos ([Primer Nombre], Apellido, Email, Telefono) VALUES (?, ?, ?, ?)", connection);
            dataAdapter.InsertCommand.Parameters.Add("@PrimerNombre", OleDbType.VarChar, 255, "Primer Nombre");
            dataAdapter.InsertCommand.Parameters.Add("@Apellido", OleDbType.VarChar, 255, "Apellido");
            dataAdapter.InsertCommand.Parameters.Add("@Email", OleDbType.VarChar, 255, "Email");
            dataAdapter.InsertCommand.Parameters.Add("@Telefono", OleDbType.VarChar, 255, "Telefono");

            //Configura el comando DELETE para eliminar registros.
            dataAdapter.DeleteCommand = new OleDbCommand("DELETE FROM Contactos WHERE ID = @ID", connection);
            dataAdapter.DeleteCommand.Parameters.Add("@ID", OleDbType.Integer, 4, "ID");

            // Configurar el comando UPDATE para modificar registros existentes
            dataAdapter.UpdateCommand = new OleDbCommand("UPDATE Contactos SET [Primer Nombre] = @PrimerNombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono WHERE ID = @ID", connection);
            dataAdapter.UpdateCommand.Parameters.Add("@PrimerNombre", OleDbType.VarChar, 255, "Primer Nombre");
            dataAdapter.UpdateCommand.Parameters.Add("@Apellido", OleDbType.VarChar, 255, "Apellido");
            dataAdapter.UpdateCommand.Parameters.Add("@Email", OleDbType.VarChar, 255, "Email");
            dataAdapter.UpdateCommand.Parameters.Add("@Telefono", OleDbType.VarChar, 255, "Telefono");
            dataAdapter.UpdateCommand.Parameters.Add("@ID", OleDbType.Integer, 4, "ID").SourceVersion = DataRowVersion.Original;
            
            // Crea un nuevo DataSet para almacenar los datos recuperados de la base de datos
            dataSet = new DataSet();

            // Utiliza el adaptador para llenar el DataSet con los datos de la tabla "Contactos"
            dataAdapter.Fill(dataSet, "Contactos");

            // Despliega los detalles del contacto actual en los TextBoxes
            NavigateRecords(currentIndex);
        }

        private void NavigateRecords(int index)
        {
            // Verifica si existen filas en la tabla "Contacts" del DataSet
            if (dataSet.Tables["Contactos"].Rows.Count > 0)
            {
                // Obtiene la fila específica en el índice proporcionado
                DataRow row = dataSet.Tables["Contactos"].Rows[index];

                // Obtiene el valor del campo "ID" de la fila y lo coloca en el cuadro de texto tbxAddressID
                tbxAddressID.Text = row["ID"].ToString();

                // Obtiene el valor del campo "Primer Nombre" de la fila y lo coloca en el cuadro de texto txbFirstName
                tbxFirstName.Text = row["Primer Nombre"].ToString();

                // Obtiene el valor del campo "Apellido" de la fila y lo coloca en el cuadro de texto tbxLastName
                tbxLastName.Text = row["Apellido"].ToString();

                // Obtiene el valor del campo "Email" de la fila y lo coloca en el cuadro de texto txbEmail
                tbxEmail.Text = row["Email"].ToString();

                // Obtiene el valor del campo "PhoneNumber" de la fila y lo coloca en el cuadro de texto txtPhoneNumber
                tbxPhoneNumber.Text = row["Telefono"].ToString();
            }
        }

        private DataRow[] matchingRows; // Variable para almacenar las filas coincidentes

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Obtiene el texto ingresado en el cuadro de texto de búsqueda
            string searchQuery = tbxFindLastName.Text;
            // Utiliza el método Select para buscar filas en el DataSet donde el LastName empiece con la cadena de búsqueda
            DataRow[] matchingRows = dataSet.Tables["Contactos"].Select($"Apellido LIKE '{searchQuery}%'");


            // Si se encontraron filas que coinciden con la búsqueda
            if (matchingRows.Length > 0)
            {
                // Obtiene el índice de la primera fila coincidente en el DataTable "Contacts"
                currentIndex = dataSet.Tables["Contactos"].Rows.IndexOf(matchingRows[0]);

                // Actualiza los campos del formulario con los detalles del contacto actual
                NavigateRecords(currentIndex);

                // Deshabilita los botones agregar y eliminar
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                // Muestra un mensaje si no se encontraron resultados coincidentes
                MessageBox.Show("No se encontraron contactos coincidentes.");
            }

            // Sincronizar el BindingNavigator con la lista de resultados coincidentes
            bindingNavigator.BindingSource = new BindingSource(new DataView(dataSet.Tables["Contactos"]), "");
        }


        private void DisableNavigationButtons()
        {
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnMoverPrimero.Enabled = false;
            btnMoverUltimo.Enabled = false;
        }

        private void EnableNavigationButtons()
        {
            btnPrevious.Enabled = true;   
            btnNext.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnGuardar.Enabled = true;
            btnMoverPrimero.Enabled = true;
            btnMoverUltimo.Enabled = true;
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Verifica si el índice actual es mayor que 0
            if (currentIndex > 0)
            {
                // Reduce el índice en 1 para ir al registro anterior
                currentIndex--;

                // Llama a la función NavigateRecords con el nuevo índice para mostrar los detalles del registro anterior
                NavigateRecords(currentIndex);

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Verifica si el índice actual es menor que la cantidad total de filas menos 1
            if (currentIndex < dataSet.Tables["Contactos"].Rows.Count - 1)
            {
                // Incrementa el índice en 1 para ir al siguiente registro
                currentIndex++;

                // Llama a la función NavigateRecords con el nuevo índice para mostrar los detalles del siguiente registro
                NavigateRecords(currentIndex);


            }
        }

        private void btnBrowseAllEntries_Click(object sender, EventArgs e)
        {
            // Borra la búsqueda, mostrando todos los registros nuevamente
            RefreshAllRecords();

            // Habilita los botones de Agregar y Eliminar
            EnableNavigationButtons();
        }

        private void RefreshAllRecords()
        {
            // Limpia la búsqueda (si la hubiera)
            tbxFindLastName.Clear();

            // Muestra el primer registro (si hay registros)
            if (dataSet.Tables["Contactos"].Rows.Count > 0)
            {
            currentIndex = 0;
            NavigateRecords(currentIndex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Crear una nueva fila en el DataTable "Contactos"
            DataRow newRow = dataSet.Tables["Contactos"].NewRow();

            // Obtén el valor máximo actual de la columna "ID" en el DataTable "Contactos"
            int maxID = dataSet.Tables["Contactos"].AsEnumerable().Max(row => row.Field<int>("ID"));

            // Calcula el siguiente ID sumando 1 al valor máximo actual
            int newID = maxID + 1;

            // Asignar el nuevo ID al campo "ID" de la nueva fila
            newRow["ID"] = newID;

            // Agregar la nueva fila al DataTable
            dataSet.Tables["Contactos"].Rows.Add(newRow);

            ////Actualizar la posición de la fila al último contacto agregado
            currentIndex = dataSet.Tables["Contactos"].Rows.Count - 1;

            // Mostrar el ID en el cuadro de texto ID y limpiar los otros campos
            tbxAddressID.Text = newID.ToString();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxEmail.Clear();
            tbxPhoneNumber.Clear();

            btnGuardar.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            DisableNavigationButtons();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verifica si el índice actual es válido
            if (currentIndex >= 0 && currentIndex < dataSet.Tables["Contactos"].Rows.Count)
            {
                // Obtener la fila correspondiente al índice actual
                DataRow row = dataSet.Tables["Contactos"].Rows[currentIndex];

                // Actualizar los valores de las columnas con los datos ingresados en los TextBox
                row["Primer Nombre"] = tbxFirstName.Text;
                row["Apellido"] = tbxLastName.Text;
                row["Email"] = tbxEmail.Text;
                row["Telefono"] = tbxPhoneNumber.Text;

                // Actualizar los cambios en la base de datos
                dataAdapter.Update(dataSet, "Contactos");
                dataSet.AcceptChanges();

                // Mostrar un mensaje de éxito
                MessageBox.Show("Se ha guardado con éxito.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Habilitar los botones de navegación y deshabilitar el botón GUARDAR
                EnableNavigationButtons();
                //btnGuardar.Enabled = false; // Deshabilitar el botón GUARDAR
                RefreshAllRecords();
            }
            else
            {
                MessageBox.Show("No se puede editar el registro en la posición actual.", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea eliminar este contacto?", "Confirmar eliminación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRow rowToDelete = dataSet.Tables["Contactos"].Rows[currentIndex];
                rowToDelete.Delete();

                dataAdapter.Update(dataSet, "Contactos");
                dataSet.AcceptChanges();

                //// Actualizar la posición de la fila si se eliminó el último contacto
                //if (currentIndex >= dataSet.Tables["Contactos"].Rows.Count)
                //{
                //    currentIndex = dataSet.Tables["Contactos"].Rows.Count - 1;
               // }

                // Refresh the form and show the next record
                RefreshAllRecords();
            }
        }

        private void btnMoverPrimero_Click(object sender, EventArgs e)
        {
            // Verifica si existen filas en la tabla "Contactos" del DataSet
            if (dataSet.Tables["Contactos"].Rows.Count > 0)
            {
                // Establece el índice actual al primero
                currentIndex = 0;

                // Actualiza los detalles del formulario con el primer registro
                NavigateRecords(currentIndex);
            }
        }

        private void btnMoverUltimo_Click(object sender, EventArgs e)
        {
            // Verifica si existen filas en la tabla "Contactos" del DataSet
            if (dataSet.Tables["Contactos"].Rows.Count > 0)
            {
                // Establece el índice actual al último
                currentIndex = dataSet.Tables["Contactos"].Rows.Count - 1;

                // Actualiza los detalles del formulario con el último registro
                NavigateRecords(currentIndex);
            }
        }

    }

}
