
namespace PizzaPlace
{
    partial class PizzaOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.pizzalist = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courierlist = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.orderState = new System.Windows.Forms.ListBox();
            this.stateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.delCustomer = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.deliveredOrders = new System.Windows.Forms.Button();
            this.deliveredBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // pizzalist
            // 
            this.pizzalist.FormattingEnabled = true;
            this.pizzalist.Location = new System.Drawing.Point(171, 214);
            this.pizzalist.Name = "pizzalist";
            this.pizzalist.Size = new System.Drawing.Size(151, 28);
            this.pizzalist.TabIndex = 4;
            this.pizzalist.Text = "<válassz pizzát>";
            this.pizzalist.TextChanged += new System.EventHandler(this.pizzalist_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(132, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(426, 27);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(132, 136);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(426, 27);
            this.address.TabIndex = 7;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cím";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(132, 169);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(426, 27);
            this.phonenumber.TabIndex = 9;
            this.phonenumber.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefonszám";
            // 
            // courierlist
            // 
            this.courierlist.FormattingEnabled = true;
            this.courierlist.Location = new System.Drawing.Point(359, 214);
            this.courierlist.Name = "courierlist";
            this.courierlist.Size = new System.Drawing.Size(151, 28);
            this.courierlist.TabIndex = 12;
            this.courierlist.Text = "<válassz futárt>";
            this.courierlist.TextChanged += new System.EventHandler(this.courierlist_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(197, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Megrendelő adatai";
            // 
            // customer
            // 
            this.customer.FormattingEnabled = true;
            this.customer.Location = new System.Drawing.Point(132, 69);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(426, 28);
            this.customer.TabIndex = 15;
            this.customer.Text = "<korrábbi ügyfelek>";
            this.customer.TextChanged += new System.EventHandler(this.customer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(171, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fizetendő:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(266, 275);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(25, 23);
            this.price.TabIndex = 17;
            this.price.Text = "ár";
            this.price.Visible = false;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(197, 319);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(195, 52);
            this.orderButton.TabIndex = 18;
            this.orderButton.Text = "Rendelés leadása";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Visible = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // orderState
            // 
            this.orderState.FormattingEnabled = true;
            this.orderState.ItemHeight = 20;
            this.orderState.Location = new System.Drawing.Point(12, 422);
            this.orderState.Name = "orderState";
            this.orderState.Size = new System.Drawing.Size(879, 104);
            this.orderState.TabIndex = 19;
            this.orderState.Click += new System.EventHandler(this.orderState_Click);
            // 
            // stateButton
            // 
            this.stateButton.Location = new System.Drawing.Point(413, 344);
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(200, 75);
            this.stateButton.TabIndex = 20;
            this.stateButton.UseVisualStyleBackColor = true;
            this.stateButton.Visible = false;
            this.stateButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kattints a rendelésre a módosításhoz: ";
            // 
            // delCustomer
            // 
            this.delCustomer.Location = new System.Drawing.Point(576, 69);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(167, 29);
            this.delCustomer.TabIndex = 22;
            this.delCustomer.Text = "Korábbi ügyfél törlése";
            this.delCustomer.UseVisualStyleBackColor = true;
            this.delCustomer.Visible = false;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // deleteOrder
            // 
            this.deleteOrder.BackColor = System.Drawing.Color.Salmon;
            this.deleteOrder.Location = new System.Drawing.Point(812, 352);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(79, 58);
            this.deleteOrder.TabIndex = 23;
            this.deleteOrder.Text = "Rendelés törlése";
            this.deleteOrder.UseVisualStyleBackColor = false;
            this.deleteOrder.Visible = false;
            this.deleteOrder.Click += new System.EventHandler(this.deleteOrder_Click);
            // 
            // deliveredOrders
            // 
            this.deliveredOrders.BackColor = System.Drawing.Color.LemonChiffon;
            this.deliveredOrders.Location = new System.Drawing.Point(717, 352);
            this.deliveredOrders.Name = "deliveredOrders";
            this.deliveredOrders.Size = new System.Drawing.Size(89, 58);
            this.deliveredOrders.TabIndex = 24;
            this.deliveredOrders.Text = "Kiszállított rendelések";
            this.deliveredOrders.UseVisualStyleBackColor = false;
            this.deliveredOrders.Click += new System.EventHandler(this.deliveredOrders_Click);
            // 
            // deliveredBox
            // 
            this.deliveredBox.FormattingEnabled = true;
            this.deliveredBox.ItemHeight = 20;
            this.deliveredBox.Location = new System.Drawing.Point(13, 532);
            this.deliveredBox.Name = "deliveredBox";
            this.deliveredBox.Size = new System.Drawing.Size(878, 64);
            this.deliveredBox.TabIndex = 25;
            this.deliveredBox.Visible = false;
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 606);
            this.Controls.Add(this.deliveredBox);
            this.Controls.Add(this.deliveredOrders);
            this.Controls.Add(this.deleteOrder);
            this.Controls.Add(this.delCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stateButton);
            this.Controls.Add(this.orderState);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.courierlist);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pizzalist);
            this.Controls.Add(this.label1);
            this.Name = "PizzaOrder";
            this.Text = "Pizzarendelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pizzalist;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox courierlist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ListBox orderState;
        private System.Windows.Forms.Button stateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button deliveredOrders;
        private System.Windows.Forms.ListBox deliveredBox;
    }
}