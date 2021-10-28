using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace HM1.ADO.NET
{
    public partial class Form1 : Form
    {                                        
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection GetConnection() {


            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = FRUITS; Integrated Security = true; ";
            return new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection=GetConnection())
            {
                connection.Open();
                conbox.Text = connection.State.ToString();
            }
        }

        private void allbn_Click(object sender, EventArgs e)
        {
            string query = "";
            using (SqlConnection connection = GetConnection())
            {
                DataTable data = new DataTable();
                switch ((sender as Button).Name)
                {
                    case "allbn":
                        query = @"SELECT FRUITNAME,FRUITTYPE,COLOUR,CALORY FROM FRUITS";
                        break;
                    case "namebn":
                        query = @"SELECT FRUITNAME FROM FRUITS";
                        break;
                    case "Colourbn":
                        query = @"SELECT DISTINCT COLOUR FROM FRUITS";
                        break;
                    case "maxclbn":
                        query = @"SELECT MAX(CALORY)[MAX] FROM FRUITS";
                        break;
                    case "minclbn":
                        query = @"SELECT MIN(CALORY)[MIN] FROM FRUITS";
                        break;
                    case "avgclbn":
                        query = @"SELECT AVG(CALORY)[AVERAGE] FROM FRUITS";
                        break;
                    case "countvbn":
                        query = @"SELECT COUNT(FRUITNAME)[COUNT] FROM FRUITS WHERE FRUITTYPE='VEGETABLE'";
                        break;
                    case "countfbn":
                        query = @"SELECT COUNT(FRUITNAME)[COUNT] FROM FRUITS WHERE FRUITTYPE='FRUIT'";
                        break;
                    case "chosebn":
                        query = $"SELECT COUNT(FRUITNAME)[COUNT] FROM FRUITS WHERE COLOUR='{chooseclbn.Text}'";
                        break;
                    case "groupbn":
                        query = @"SELECT COLOUR,COUNT(FRUITNAME)[COUNT] FROM FRUITS GROUP BY COLOUR";
                        break;
                    case "redbn":
                        query = @"SELECT FRUITNAME FROM FRUITS WHERE COLOUR IN ('YELLOW','RED')";
                        break;
                    case "maxbn":
                        query = $"SELECT FRUITNAME FROM FRUITS WHERE CALORY<{maxbox.Text}";
                        break;
                    case "minbn":
                        query = $"SELECT FRUITNAME FROM FRUITS WHERE CALORY>{minbox.Text}";
                        break;
                    case "betweenbn":
                        query = $"SELECT FRUITNAME FROM FRUITS WHERE CALORY  BETWEEN {mind.Text} AND {maxd.Text}";
                        break;
                    default:
                        break;
                }
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    adapter.Fill(data);
                }
                dataGrid.DataSource = data;

            }



        }
    }
}
