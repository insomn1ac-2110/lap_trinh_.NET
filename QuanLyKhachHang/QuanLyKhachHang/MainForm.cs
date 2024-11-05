using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachHang
{
    public partial class MainForm : Form
    {
        private List<Customer> customers;
        private List<Service> services;
        private List<Invoice> invoices;
        private int customerIdCounter = 1;
        private int serviceIdCounter = 1;
        private int invoiceIdCounter = 1;

        private ListBox customerListBox;
        private ListBox serviceListBox;
        private ListBox invoiceListBox;
        private TextBox customerNameTextBox;
        private TextBox customerPhoneTextBox;
        private TextBox customerAddressTextBox;
        private TextBox serviceNameTextBox;
        private TextBox servicePriceTextBox;
        private Button addCustomerButton;
        private Button editCustomerButton;
        private Button deleteCustomerButton;
        private Button addServiceButton;
        private Button createInvoiceButton;
        private Label totalPriceLabel;

        public MainForm()
        {
            InitializeComponent();
            customers = new List<Customer>();
            services = new List<Service>();
            invoices = new List<Invoice>();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Initialize components and add event handlers here

            // ListBox for customers
            customerListBox = new ListBox
            {
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(200, 150)
            };
            this.Controls.Add(customerListBox);

            // ListBox for services
            serviceListBox = new ListBox
            {
                Location = new System.Drawing.Point(250, 12),
                Size = new System.Drawing.Size(200, 150)
            };
            this.Controls.Add(serviceListBox);

            // ListBox for invoice services
            invoiceListBox = new ListBox
            {
                Location = new System.Drawing.Point(12, 250),
                Size = new System.Drawing.Size(200, 150)
            };
            this.Controls.Add(invoiceListBox);

            // TextBox for customer details
            customerNameTextBox = CreateTextBoxWithPlaceholder("Tên", new System.Drawing.Point(12, 180));
            this.Controls.Add(customerNameTextBox);

            customerPhoneTextBox = CreateTextBoxWithPlaceholder("Số điện thoại", new System.Drawing.Point(12, 210));
            this.Controls.Add(customerPhoneTextBox);

            customerAddressTextBox = CreateTextBoxWithPlaceholder("Địa chỉ", new System.Drawing.Point(12, 240));
            this.Controls.Add(customerAddressTextBox);

            // Buttons for customer operations
            addCustomerButton = new Button
            {
                Text = "Thêm khách hàng",
                Location = new System.Drawing.Point(120, 180)
            };
            addCustomerButton.Click += AddCustomerButton_Click;
            this.Controls.Add(addCustomerButton);

            editCustomerButton = new Button
            {
                Text = "Chỉnh sửa",
                Location = new System.Drawing.Point(120, 210)
            };
            editCustomerButton.Click += EditCustomerButton_Click;
            this.Controls.Add(editCustomerButton);

            deleteCustomerButton = new Button
            {
                Text = "Xóa",
                Location = new System.Drawing.Point(120, 240)
            };
            deleteCustomerButton.Click += DeleteCustomerButton_Click;
            this.Controls.Add(deleteCustomerButton);

            // TextBox for service details
            serviceNameTextBox = CreateTextBoxWithPlaceholder("Tên dịch vụ", new System.Drawing.Point(250, 180));
            this.Controls.Add(serviceNameTextBox);

            servicePriceTextBox = CreateTextBoxWithPlaceholder("Giá tiền", new System.Drawing.Point(250, 210));
            this.Controls.Add(servicePriceTextBox);

            // Buttons for service operations
            addServiceButton = new Button
            {
                Text = "Thêm dịch vụ",
                Location = new System.Drawing.Point(360, 180)
            };
            addServiceButton.Click += AddServiceButton_Click;
            this.Controls.Add(addServiceButton);

            createInvoiceButton = new Button
            {
                Text = "Tạo hóa đơn",
                Location = new System.Drawing.Point(12, 420)
            };
            createInvoiceButton.Click += CreateInvoiceButton_Click;
            this.Controls.Add(createInvoiceButton);

            totalPriceLabel = new Label
            {
                Location = new System.Drawing.Point(12, 450),
                Size = new System.Drawing.Size(200, 23),
                Text = "Tổng tiền: 0"
            };
            this.Controls.Add(totalPriceLabel);
        }

        private TextBox CreateTextBoxWithPlaceholder(string placeholderText, System.Drawing.Point location)
        {
            var textBox = new TextBox
            {
                Location = location,
                Size = new System.Drawing.Size(100, 20),
                ForeColor = System.Drawing.Color.Gray,
                Text = placeholderText
            };

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };

            return textBox;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Id = customerIdCounter++,
                Name = customerNameTextBox.Text,
                Phone = customerPhoneTextBox.Text,
                Address = customerAddressTextBox.Text
            };
            customers.Add(customer);
            UpdateCustomerList();
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer)customerListBox.SelectedItem;
            selectedCustomer.Name = customerNameTextBox.Text;
            selectedCustomer.Phone = customerPhoneTextBox.Text;
            selectedCustomer.Address = customerAddressTextBox.Text;
            UpdateCustomerList();
        }

        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer)customerListBox.SelectedItem;
            customers.Remove(selectedCustomer);
            UpdateCustomerList();
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            var service = new Service
            {
                Id = serviceIdCounter++,
                Name = serviceNameTextBox.Text,
                Price = decimal.Parse(servicePriceTextBox.Text)
            };
            services.Add(service);
            UpdateServiceList();
        }

        private void CreateInvoiceButton_Click(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer)customerListBox.SelectedItem;
            var selectedServices = serviceListBox.SelectedItems.Cast<Service>().ToList();
            var invoice = new Invoice
            {
                Id = invoiceIdCounter++,
                Customer = selectedCustomer,
                Services = selectedServices
            };
            invoices.Add(invoice);
            ShowInvoice(invoice);
        }

        private void UpdateCustomerList()
        {
            customerListBox.DataSource = null;
            customerListBox.DataSource = customers;
            customerListBox.DisplayMember = "Name";
        }

        private void UpdateServiceList()
        {
            serviceListBox.DataSource = null;
            serviceListBox.DataSource = services;
            serviceListBox.DisplayMember = "Name";
        }

        private void ShowInvoice(Invoice invoice)
        {
            invoiceListBox.Items.Clear();
            foreach (var service in invoice.Services)
            {
                invoiceListBox.Items.Add(service.Name + " - " + service.Price.ToString("C"));
            }
            totalPriceLabel.Text = "Tổng tiền: " + invoice.TotalPrice.ToString("C");
        }
    }
}
