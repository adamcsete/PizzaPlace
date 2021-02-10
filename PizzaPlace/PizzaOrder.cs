using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace PizzaPlace
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
            show_process();

            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
            
            SqlConnection connection = new SqlConnection(ConnectionString);
            
            //fill pizza list
            string sql = @"SELECT * FROM pizzas;";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pizzalist.Items.Add(reader.GetString(1));
            }
            connection.Close();

            //fill courier list
            sql = @"SELECT * FROM couriers;";
            command = new SqlCommand(sql, connection);
            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                courierlist.Items.Add(reader.GetString(1));
            }
            connection.Close();

            //fill customers list
            sql = @"SELECT * FROM customers;";
            command = new SqlCommand(sql, connection);
            connection.Open();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                customer.Items.Add(reader.GetString(1)+ " " + reader.GetString(2));
            }
            connection.Close();

        }

        private void pizzalist_TextChanged(object sender, EventArgs e)
        {
            price.Visible = true;
            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
            SqlConnection connection = new SqlConnection(ConnectionString);

            string sql = "SELECT * FROM pizzas WHERE pNAME ='" + pizzalist.Text + "';";
            
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                price.Text = reader.GetInt16(2).ToString() + " Ft";
            }
            connection.Close();

            //check whether to show orderButton
            if (name.Text != "" &&
                address.Text != "" &&
                phonenumber.Text != "" &&
                price.Text != "" &&
                pizzalist.Text != "<válassz pizzát>" &&
                courierlist.Text != "<válassz futárt>") orderButton.Visible = true;
        }

        private void customer_TextChanged(object sender, EventArgs e)
        {
            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
           
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sql = @"USE pizzaplace
                           SELECT * FROM customers 
                           WHERE CONCAT(custNAME,' ',custADDRESS) = '" + customer.Text + "';";
            SqlCommand command = new SqlCommand(sql, connection);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                name.Text = reader.GetString(1);
                address.Text = reader.GetString(2);
                phonenumber.Text = reader.GetString(3);
            }
            connection.Close();

            //show delete customer button
            delCustomer.Visible = true;

            //check whether to show orderButton
            if (name.Text != "" &&
                address.Text != "" &&
                phonenumber.Text != "" &&
                price.Text != "" &&
                pizzalist.Text != "<válassz pizzát>" &&
                courierlist.Text != "<válassz futárt>") orderButton.Visible = true;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string state = "készül";
            string sql = @"INSERT INTO orders (oSTATE, oPIZZA, oCUSTOMER, oCOURIER, oPRICE, oTIME) VALUES ('" + state + "','" + pizzalist.Text + @"',
                          '"+ name.Text + " " + address.Text + "','" + courierlist.Text + "'," + price.Text.Substring(0,price.Text.IndexOf(" ")) + ",'"+DateTime.Now.ToString()+"')";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();

            //check if customer already in database if not, then insert
            sql = "SELECT * FROM customers WHERE custNAME = '" +name.Text+"' AND custADDRESS = '"+address.Text+"';";
            connection.Open();
            command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(3) != phonenumber.Text)
                {
                    connection.Close();
                    connection.Open();
                    sql = "UPDATE customers SET custNUMBER = '" + phonenumber.Text + "' WHERE custNAME = '" + name.Text + "' AND custADDRESS = '" + address.Text + "';";
                    command = new SqlCommand(sql, connection);
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
            }
            else 
            {
                connection.Close();
                connection.Open();
                sql = "INSERT INTO customers (custNAME, custADDRESS, custNUMBER) VALUES ('"+name.Text+"','"+address.Text+"','"+phonenumber.Text+"')";
                command = new SqlCommand(sql, connection);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            connection.Close();

            //clear after order
            customer.Text = "<korábbi ügyfelek>";
            name.Text = "";
            address.Text = "";
            phonenumber.Text = "";
            pizzalist.Text = "<válassz pizzát>";
            courierlist.Text = "<válassz futárt>";
            price.Visible = false;
            price.Text = "";
            orderButton.Visible = false;
            delCustomer.Visible = false;

            //refill customers list
            customer.Items.Clear();
            sql = @"SELECT * FROM customers;";
            command = new SqlCommand(sql, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                customer.Items.Add(reader.GetString(1) + " " + reader.GetString(2));
            }
            connection.Close();

            show_process();
        }

        private void courierlist_TextChanged(object sender, EventArgs e)
        {
            if (name.Text != "" && 
                address.Text != "" && 
                phonenumber.Text != "" && 
                price.Text != "" && 
                pizzalist.Text != "<válassz pizzát>" &&
                courierlist.Text != "<válassz futárt>") orderButton.Visible = true;

        }

        //show orders in process
        private void show_process()
        {
            orderState.Items.Clear();
            deliveredBox.Items.Clear();
            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sql = @"SELECT * FROM orders;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == "készül" || reader.GetString(1) == "szállítás alatt")
                {
                    orderState.Items.Add("Azonosító: " + reader.GetInt32(0).ToString() +
                                          ", " + reader.GetString(1) +
                                          ": " + reader.GetString(2) +
                                          ", " + reader.GetString(3) +
                                          ", futár: " + reader.GetString(4) +
                                          ", " + reader.GetInt16(5).ToString() + " Ft" +
                                          ", " + reader.GetString(6));
                }
                else 
                { 
                    deliveredBox.Items.Add("Azonosító: " + reader.GetInt32(0).ToString() +
                                          ", " + reader.GetString(1) +
                                          ": " + reader.GetString(2) +
                                          ", " + reader.GetString(3) +
                                          ", futár: " + reader.GetString(4) +
                                          ", " + reader.GetInt16(5).ToString() + " Ft" +
                                          ", " + reader.GetString(6));
                }
            }
            connection.Close();
        }

        private void orderState_Click(object sender, EventArgs e)
        {
            stateButton.Visible = true;
            if (orderState.SelectedItem.ToString().Contains("készül"))
            {
                stateButton.Text = "Tovább: \nszállítás alatt";
            }

            if (orderState.SelectedItem.ToString().Contains("szállítás alatt"))
            {
                stateButton.Text = "Tovább: \nkiszállítva";
            }

            deleteOrder.Visible = true;

        }

        private void stateButton_Click(object sender, EventArgs e)
        {
            stateButton.Visible = false;
            deleteOrder.Visible = false;
            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
            SqlConnection connection = new SqlConnection(ConnectionString);
            string s = orderState.SelectedItem.ToString();
            string idToChange = s.Substring(11,s.IndexOf(",")-11);
            string state = "";

            if (orderState.SelectedItem.ToString().Contains("készül")) state = "szállítás alatt";
            if (orderState.SelectedItem.ToString().Contains("szállítás alatt")) state = "kiszállítva";

            connection.Open();
            string sql = @"UPDATE orders SET oSTATE = '" + state + "', " +
                "          oTIME='" + DateTime.Now.ToString() + "' WHERE oID = " + idToChange + ";";
            
            SqlCommand command = new SqlCommand(sql, connection);
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
            
            show_process();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            //check whether to show orderButton
            if (name.Text != "" &&
                address.Text != "" &&
                phonenumber.Text != "" &&
                price.Text != "" &&
                pizzalist.Text != "<válassz pizzát>" &&
                courierlist.Text != "<válassz futárt>") orderButton.Visible = true;
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            //check whether to show orderButton
            if (name.Text != "" &&
                address.Text != "" &&
                phonenumber.Text != "" &&
                price.Text != "" &&
                pizzalist.Text != "<válassz pizzát>" &&
                courierlist.Text != "<válassz futárt>") orderButton.Visible = true;
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            //check whether to show orderButton
            if (name.Text != "" &&
                address.Text != "" &&
                phonenumber.Text != "" &&
                price.Text != "" &&
                pizzalist.Text != "<válassz pizzát>" &&
                courierlist.Text != "<válassz futárt>") orderButton.Visible = true;
        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            //delete customer from database
            string sql = "DELETE FROM customers WHERE custNAME = '" + name.Text + "'AND custADDRESS = '" + address.Text + "';";
            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();

            //refill customers list
            customer.Items.Clear();
            sql = @"SELECT * FROM customers;";
            command = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                customer.Items.Add(reader.GetString(1) + " " + reader.GetString(2));
            }
            connection.Close();

            //clear after delete
            customer.Text = "<korábbi ügyfelek>";
            name.Text = "";
            address.Text = "";
            phonenumber.Text = "";
            pizzalist.Text = "<válassz pizzát>";
            courierlist.Text = "<válassz futárt>";
            price.Visible = false;
            price.Text = "";
            orderButton.Visible = false;
            delCustomer.Visible = false;

        }

        private void deleteOrder_Click(object sender, EventArgs e)
        {
            deleteOrder.Visible = false;
            stateButton.Visible = false;
            string getSource = Directory.GetCurrentDirectory() + "\\dbparameter";
            string ConnectionString = File.ReadAllText(getSource);
            SqlConnection connection = new SqlConnection(ConnectionString);
            string s = orderState.SelectedItem.ToString();
            string idToDelete = s.Substring(11, s.IndexOf(",") - 11);
            connection.Open();
            string sql = "DELETE FROM orders WHERE oID = " + idToDelete + ";";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
            show_process();
        }

        private void deliveredOrders_Click(object sender, EventArgs e)
        {
            if (deliveredOrders.BackColor.Equals(Color.LemonChiffon)) 
            {
                deliveredOrders.BackColor = Color.GreenYellow;
                deliveredBox.Visible = true;
            }
            else 
            {
                deliveredOrders.BackColor = Color.LemonChiffon;
                deliveredBox.Visible = false;
            }
        }
    }
}
