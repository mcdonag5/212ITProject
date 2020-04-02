import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;

import net.proteanit.sql.DbUtils;

import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.LayoutStyle.ComponentPlacement;

public class ContactManagerWindow {

	private JFrame frmHarrisContactManager;
	private JTable tbContact;
	private JTextField tfFName;
	private JTextField tfLName;
	private JTextField tfOtherTel;
	private JTextField tfTele;
	private JTextField tfEmail;
	private JTextField tfCity;
	private JTextField tfAddr1;
	private JTextField tfAddr2;
	private JTextField tfPostcode;
	
	private JButton btnSaveNew;
	private JButton btnAddNew;
	private JButton btnUpdateSelected;
	private JButton btnSaveSelected;
	private JButton btnDeleteSelected;
	
	private String contactView = "Personal";
	private int selectedId;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					ContactManagerWindow window = new ContactManagerWindow();
					window.frmHarrisContactManager.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public ContactManagerWindow() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		DbConn d = new DbConn();
		
		frmHarrisContactManager = new JFrame();
		frmHarrisContactManager.setTitle("Harris Contact Manager - Personal");
		frmHarrisContactManager.setBounds(100, 100, 849, 545);
		frmHarrisContactManager.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		JScrollPane scrollPane = new JScrollPane();
		
		tbContact = new JTable();
		tbContact.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				selectedId = (int) tbContact.getValueAt(tbContact.getSelectedRow(),0);
			}
		});
		scrollPane.setViewportView(tbContact);
		tbContact.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
		
		tfFName = new JTextField();
		tfFName.setEnabled(false);
		tfFName.setColumns(10);
		
		tfLName = new JTextField();
		tfLName.setEnabled(false);
		tfLName.setColumns(10);
		
		JLabel lblFirstName = new JLabel("First Name");
		lblFirstName.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		JLabel lblLastName = new JLabel("Last Name");
		lblLastName.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		tfOtherTel = new JTextField();
		tfOtherTel.setEnabled(false);
		tfOtherTel.setColumns(10);
		
		JLabel lblOtherTelephone = new JLabel("Home Telephone");
		lblOtherTelephone.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		JLabel lblTelephone = new JLabel("Telephone");
		lblTelephone.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		tfTele = new JTextField();
		tfTele.setEnabled(false);
		tfTele.setColumns(10);
		
		JLabel lblEmail = new JLabel("Email");
		lblEmail.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		tfEmail = new JTextField();
		tfEmail.setEnabled(false);
		tfEmail.setColumns(10);
		
		tfCity = new JTextField();
		tfCity.setEnabled(false);
		tfCity.setColumns(10);
		
		JLabel lblCity = new JLabel("City");
		lblCity.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		JLabel lblAddressLine2 = new JLabel("Address Line 2");
		lblAddressLine2.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		JLabel lblAddressLine1 = new JLabel("Address Line 1");
		lblAddressLine1.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		tfAddr1 = new JTextField();
		tfAddr1.setEnabled(false);
		tfAddr1.setColumns(10);
		
		tfAddr2 = new JTextField();
		tfAddr2.setEnabled(false);
		tfAddr2.setColumns(10);
		
		JLabel lblPostcode = new JLabel("Postcode");
		lblPostcode.setFont(new Font("Tahoma", Font.PLAIN, 10));
		
		tfPostcode = new JTextField();
		tfPostcode.setEnabled(false);
		tfPostcode.setColumns(10);
		
		JButton btnChangeView = new JButton("Business \r\nContacts");
		btnChangeView.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				EnableTextboxes(false);
				btnChangeView.setText(contactView+" Contacts");
				switch(contactView) {
				case "Personal":
					lblOtherTelephone.setText("Work Telephone");
					tbContact.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
					contactView = "Business";
					break;
				case "Business":
					lblOtherTelephone.setText("Home Telephone");
					tbContact.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
					contactView = "Personal";
					break;
				}
				frmHarrisContactManager.setTitle("Harris Contact Manager - "+contactView); 
			}
		});
		
		JButton btnRefresh = new JButton("Refresh");
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				switch(contactView) {
				case "Personal":
					tbContact.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
					break;
				case "Business":
					tbContact.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
					break;
				}
			}
		});
		
		btnAddNew = new JButton("Add New");
		btnAddNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				EnableTextboxes(true);
				
				btnSaveNew.setEnabled(true);
			}
		});
		
		btnSaveNew = new JButton("Save New");
		btnSaveNew.setEnabled(false);
		
		btnUpdateSelected = new JButton("Update Selected");
		btnUpdateSelected.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				EnableTextboxes(true);
				SetTextField();
				
				btnSaveSelected.setEnabled(true);
			}
		});
		
		btnSaveSelected = new JButton("Save Selected");
		btnSaveSelected.setEnabled(false);
		
		btnDeleteSelected = new JButton("Delete Selected");
		
		GroupLayout groupLayout = new GroupLayout(frmHarrisContactManager.getContentPane());
		groupLayout.setHorizontalGroup(
			groupLayout.createParallelGroup(Alignment.LEADING)
				.addGroup(groupLayout.createSequentialGroup()
					.addGap(10)
					.addComponent(lblFirstName, GroupLayout.PREFERRED_SIZE, 64, GroupLayout.PREFERRED_SIZE)
					.addGap(20)
					.addComponent(tfFName, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(lblAddressLine1, GroupLayout.PREFERRED_SIZE, 80, GroupLayout.PREFERRED_SIZE)
					.addGap(4)
					.addComponent(tfAddr1, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(126)
					.addComponent(btnUpdateSelected, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(btnAddNew, GroupLayout.PREFERRED_SIZE, 108, GroupLayout.PREFERRED_SIZE))
				.addGroup(groupLayout.createSequentialGroup()
					.addGap(10)
					.addComponent(lblLastName, GroupLayout.PREFERRED_SIZE, 64, GroupLayout.PREFERRED_SIZE)
					.addGap(20)
					.addComponent(tfLName, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(lblAddressLine2, GroupLayout.PREFERRED_SIZE, 80, GroupLayout.PREFERRED_SIZE)
					.addGap(4)
					.addComponent(tfAddr2, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(126)
					.addComponent(btnSaveSelected, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(btnSaveNew, GroupLayout.PREFERRED_SIZE, 108, GroupLayout.PREFERRED_SIZE))
				.addGroup(groupLayout.createSequentialGroup()
					.addGap(10)
					.addComponent(lblTelephone, GroupLayout.PREFERRED_SIZE, 64, GroupLayout.PREFERRED_SIZE)
					.addGap(20)
					.addComponent(tfTele, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(lblCity, GroupLayout.PREFERRED_SIZE, 80, GroupLayout.PREFERRED_SIZE)
					.addGap(4)
					.addComponent(tfCity, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(126)
					.addComponent(btnDeleteSelected, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE))
				.addGroup(groupLayout.createSequentialGroup()
					.addGap(10)
					.addComponent(lblOtherTelephone, GroupLayout.PREFERRED_SIZE, 80, GroupLayout.PREFERRED_SIZE)
					.addGap(4)
					.addComponent(tfOtherTel, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(lblPostcode, GroupLayout.PREFERRED_SIZE, 64, GroupLayout.PREFERRED_SIZE)
					.addGap(20)
					.addComponent(tfPostcode, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE))
				.addGroup(groupLayout.createSequentialGroup()
					.addGap(10)
					.addComponent(lblEmail, GroupLayout.PREFERRED_SIZE, 80, GroupLayout.PREFERRED_SIZE)
					.addGap(4)
					.addComponent(tfEmail, GroupLayout.PREFERRED_SIZE, 124, GroupLayout.PREFERRED_SIZE)
					.addGap(344)
					.addComponent(btnChangeView, GroupLayout.PREFERRED_SIZE, 143, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(btnRefresh, GroupLayout.PREFERRED_SIZE, 108, GroupLayout.PREFERRED_SIZE)
					.addGap(10))
				.addComponent(scrollPane, GroupLayout.DEFAULT_SIZE, 833, Short.MAX_VALUE)
		);
		groupLayout.setVerticalGroup(
			groupLayout.createParallelGroup(Alignment.LEADING)
				.addGroup(groupLayout.createSequentialGroup()
					.addGap(10)
					.addGroup(groupLayout.createParallelGroup(Alignment.LEADING)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(7)
							.addComponent(lblFirstName, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(1)
							.addComponent(tfFName, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(4)
							.addComponent(lblAddressLine1, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(1)
							.addComponent(tfAddr1, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(btnUpdateSelected)
						.addComponent(btnAddNew))
					.addGap(8)
					.addGroup(groupLayout.createParallelGroup(Alignment.LEADING)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(7)
							.addComponent(lblLastName, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(1)
							.addComponent(tfLName, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(4)
							.addComponent(lblAddressLine2, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(1)
							.addComponent(tfAddr2, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(btnSaveSelected)
						.addComponent(btnSaveNew))
					.addGap(6)
					.addGroup(groupLayout.createParallelGroup(Alignment.LEADING)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(3)
							.addComponent(lblTelephone, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addComponent(tfTele, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(6)
							.addComponent(lblCity, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(3)
							.addComponent(tfCity, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(3)
							.addComponent(btnDeleteSelected)))
					.addGap(5)
					.addGroup(groupLayout.createParallelGroup(Alignment.LEADING)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(3)
							.addComponent(lblOtherTelephone, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addComponent(tfOtherTel, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(3)
							.addComponent(lblPostcode, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addComponent(tfPostcode, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
					.addGap(6)
					.addGroup(groupLayout.createParallelGroup(Alignment.LEADING)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(8)
							.addComponent(lblEmail, GroupLayout.PREFERRED_SIZE, 14, GroupLayout.PREFERRED_SIZE))
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(5)
							.addComponent(tfEmail, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(btnChangeView, GroupLayout.PREFERRED_SIZE, 29, GroupLayout.PREFERRED_SIZE)
						.addGroup(groupLayout.createSequentialGroup()
							.addGap(6)
							.addComponent(btnRefresh)))
					.addPreferredGap(ComponentPlacement.RELATED, 11, Short.MAX_VALUE)
					.addComponent(scrollPane, GroupLayout.PREFERRED_SIZE, 339, GroupLayout.PREFERRED_SIZE))
		);
		frmHarrisContactManager.getContentPane().setLayout(groupLayout);
		
		
	}
	
	public void EnableTextboxes (Boolean enabled) {
		tfFName.setEnabled(enabled);
		tfLName.setEnabled(enabled);
		tfTele.setEnabled(enabled);
		tfOtherTel.setEnabled(enabled);
		tfEmail.setEnabled(enabled);
		tfAddr1.setEnabled(enabled);
		tfAddr2.setEnabled(enabled);
		tfCity.setEnabled(enabled);
		tfPostcode.setEnabled(enabled);
		
		ClearTextField();
		btnSaveSelected.setEnabled(false);
		btnSaveNew.setEnabled(false);
	}
	
	public void ClearTextField() {
		tfFName.setText("");
		tfLName.setText("");
		tfTele.setText("");
		tfOtherTel.setText("");
		tfEmail.setText("");
		tfAddr1.setText("");
		tfAddr2.setText("");
		tfCity.setText("");
		tfPostcode.setText("");
	}
	
	public void SetTextField () {
		tfFName.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 1).toString());
		tfLName.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 2).toString());
		tfTele.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 3).toString());
		tfOtherTel.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 4).toString());
		tfEmail.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 5).toString());
		tfAddr1.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 6).toString());
		tfAddr2.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 7).toString());
		tfCity.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 8).toString());
		tfPostcode.setText(tbContact.getValueAt(tbContact.getSelectedRow(), 9).toString());
	}
}
