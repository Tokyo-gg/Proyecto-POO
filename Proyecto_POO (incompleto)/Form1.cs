using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
            dataAdapter.InsertCommand = new OleDbCommand("INSERT INTO Contactos (Primer Nombre, Apellido, Email, Telefono) VALUES (@Primer Nombre, @Apellido, @Email, @Telefono)", connection);

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
        }


        private void DisableNavigationButtons()
        {
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;                        
        }

        private void EnableNavigationButtons()
        {
            btnPrevious.Enabled = true;   
            btnNext.Enabled = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnGuardar.Enabled = true;
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

            // Asignar un valor al campo "ID" automáticamente (usando el siguiente número en la lista)
            int newID = dataSet.Tables["Contactos"].Rows.Count + 1;
            newRow["ID"] = newID;

            // Agregar la nueva fila al DataTable
            dataSet.Tables["Contactos"].Rows.Add(newRow);

            // Mostrar el ID en el cuadro de texto ID y limpiar los otros campos
            tbxAddressID.Text = newID.ToString();
            tbxFirstName.Clear();
            tbxLastName.Clear();
            tbxEmail.Clear();
            tbxPhoneNumber.Clear();

            // Habilitar los campos de entrada y el botón Guardar
            EnableNavigationButtons();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

            // Habilitar los botones de navegación y deshabilitar el botón GUARDAR
            EnableNavigationButtons();
            btnGuardar.Enabled = false; // Deshabilitar el botón GUARDAR

        }


    }
    
}
