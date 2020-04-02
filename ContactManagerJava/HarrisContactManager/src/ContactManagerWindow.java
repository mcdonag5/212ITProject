import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.Font;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

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
		frmHarrisContactManager.setTitle("Harris Contact Manager");
		frmHarrisContactManager.setBounds(100, 100, 849, 545);
		frmHarrisContactManager.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmHarrisContactManager.getContentPane().setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(0, 101, 833, 405);
		frmHarrisContactManager.getContentPane().add(scrollPane);
		
		tbContact = new JTable();
		scrollPane.setViewportView(tbContact);
		
		tfFName = new JTextField();
		tfFName.setBounds(65, 11, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfFName);
		tfFName.setColumns(10);
		
		tfLName = new JTextField();
		tfLName.setBounds(65, 42, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfLName);
		tfLName.setColumns(10);
		
		JLabel lblFirstName = new JLabel("First Name");
		lblFirstName.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblFirstName.setBounds(6, 14, 64, 14);
		frmHarrisContactManager.getContentPane().add(lblFirstName);
		
		JLabel lblLastName = new JLabel("Last Name");
		lblLastName.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblLastName.setBounds(6, 45, 64, 14);
		frmHarrisContactManager.getContentPane().add(lblLastName);
		
		tfOtherTel = new JTextField();
		tfOtherTel.setColumns(10);
		tfOtherTel.setBounds(283, 42, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfOtherTel);
		
		JLabel lblHomeTelephone = new JLabel("Home Telephone");
		lblHomeTelephone.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblHomeTelephone.setBounds(199, 45, 80, 14);
		frmHarrisContactManager.getContentPane().add(lblHomeTelephone);
		
		JLabel lblTelephone = new JLabel("Telephone");
		lblTelephone.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblTelephone.setBounds(199, 14, 64, 14);
		frmHarrisContactManager.getContentPane().add(lblTelephone);
		
		tfTele = new JTextField();
		tfTele.setColumns(10);
		tfTele.setBounds(283, 11, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfTele);
		
		JLabel lblEmail = new JLabel("Email");
		lblEmail.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblEmail.setBounds(199, 76, 80, 14);
		frmHarrisContactManager.getContentPane().add(lblEmail);
		
		tfEmail = new JTextField();
		tfEmail.setColumns(10);
		tfEmail.setBounds(283, 73, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfEmail);
		
		tfCity = new JTextField();
		tfCity.setColumns(10);
		tfCity.setBounds(501, 70, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfCity);
		
		JLabel lblCity = new JLabel("City");
		lblCity.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblCity.setBounds(417, 73, 80, 14);
		frmHarrisContactManager.getContentPane().add(lblCity);
		
		JLabel lblAddressLine2 = new JLabel("Address Line 2");
		lblAddressLine2.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblAddressLine2.setBounds(417, 42, 80, 14);
		frmHarrisContactManager.getContentPane().add(lblAddressLine2);
		
		JLabel lblAddressLine1 = new JLabel("Address Line 1");
		lblAddressLine1.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblAddressLine1.setBounds(417, 11, 80, 14);
		frmHarrisContactManager.getContentPane().add(lblAddressLine1);
		
		tfAddr1 = new JTextField();
		tfAddr1.setColumns(10);
		tfAddr1.setBounds(501, 8, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfAddr1);
		
		tfAddr2 = new JTextField();
		tfAddr2.setColumns(10);
		tfAddr2.setBounds(501, 39, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfAddr2);
		
		JLabel lblPostcode = new JLabel("Postcode");
		lblPostcode.setFont(new Font("Tahoma", Font.PLAIN, 10));
		lblPostcode.setBounds(630, 11, 64, 14);
		frmHarrisContactManager.getContentPane().add(lblPostcode);
		
		tfPostcode = new JTextField();
		tfPostcode.setColumns(10);
		tfPostcode.setBounds(689, 8, 124, 20);
		frmHarrisContactManager.getContentPane().add(tfPostcode);
		
		JButton btnChangeView = new JButton("Business Contacts");
		btnChangeView.setBounds(6, 73, 183, 23);
		frmHarrisContactManager.getContentPane().add(btnChangeView);
		
		JButton btnRefresh = new JButton("Refresh");
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				tbContact.setModel(d.GetAllPersonal());
			}
		});
		btnRefresh.setBounds(640, 36, 89, 23);
		frmHarrisContactManager.getContentPane().add(btnRefresh);
		
		
	}
}
