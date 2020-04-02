import java.sql.*;

public class DbConn {
	//Connection information to connect to database//
	private String connString = "jdbc:mysql://db212it.czz7ucpwdopn.us-east-1.rds.amazonaws.com/HarrisContactDb";
	private String username = "admin";
	private String password = "mastersword";
	private Connection con = null;
	
	//constructor to make connect with database//
	public DbConn () {
		try {
			con = DriverManager.getConnection(connString,username,password);
			System.out.println("Connected");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Connection unsuccessful");
			System.out.println(e);
		}
	}
	
	//Personal table//
	//Get all personal records
	public ResultSet GetAllPersonal() {
		ResultSet rs = null;
		String sql = "{call selectAllPersonal()}";//Command to set to database
		try {
			CallableStatement cst = con.prepareCall(sql);
			rs = cst.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;
	}
	
	//Insert personal record
	public void InsertPersonal(PersonalContact contact) {
		String sql = "{CALL insertPersonal(?, ?, ?, ?, ?, ?, ?, ?, ?)}";
		try {
			CallableStatement cst = con.prepareCall(sql);
	        cst.setString(1, contact.ContactFname);//setting the values of the parameters
	        cst.setString(2, contact.ContactLname);
	        cst.setString(3, contact.ContactTel);
	        cst.setString(4, contact.PersonalTel);
	        cst.setString(5, contact.ContactEmail);
	        cst.setString(6, contact.ContactAddr1);
	        cst.setString(7, contact.ContactAddr2);
	        cst.setString(8, contact.ContactCity);
	        cst.setString(9, contact.ContactPostcode);
	        cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	//Insert personal record
	public void UpdatePersonal(PersonalContact contact) {
		String sql = "{CALL updatePersonal(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}";
		try {
			CallableStatement cst = con.prepareCall(sql);
			cst.setString(1, Integer.toString(contact.ContactID)); //id of the contact to know which one to change
	        cst.setString(2, contact.ContactFname);//setting the values of the parameters
	        cst.setString(3, contact.ContactLname);
	        cst.setString(4, contact.ContactTel);
	        cst.setString(5, contact.PersonalTel);
	        cst.setString(6, contact.ContactEmail);
	        cst.setString(7, contact.ContactAddr1);
	        cst.setString(8, contact.ContactAddr2);
	        cst.setString(9, contact.ContactCity);
	        cst.setString(10, contact.ContactPostcode);
	        cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
		
	}
	
	//Delete personal record
	public void DeletePersonal(int id) {
		String sql = "{CALL deletePersonal(?)}";
		try {
			CallableStatement cst = con.prepareCall(sql);
			cst.setString(1, Integer.toString(id)); //id of the contact to know which one to delete
	        cst.executeQuery();
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}
	
	//Business table//
		//Get all business records
		public ResultSet GetAllBusiness() {
			ResultSet rs = null;
			String sql = "{call selectAllBusiness()}";//Command to set to database
			try {
				CallableStatement cst = con.prepareCall(sql);
				rs = cst.executeQuery();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			return rs;
		}
		
		//Insert personal record
		public void InsertBusiness(BusinessContact contact) {
			String sql = "{CALL insertBusiness(?, ?, ?, ?, ?, ?, ?, ?, ?)}";
			try {
				CallableStatement cst = con.prepareCall(sql);
		        cst.setString(1, contact.ContactFname);//setting the values of the parameters
		        cst.setString(2, contact.ContactLname);
		        cst.setString(3, contact.ContactTel);
		        cst.setString(4, contact.BusinessTel);
		        cst.setString(5, contact.ContactEmail);
		        cst.setString(6, contact.ContactAddr1);
		        cst.setString(7, contact.ContactAddr2);
		        cst.setString(8, contact.ContactCity);
		        cst.setString(9, contact.ContactPostcode);
		        cst.executeQuery();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
		
		//Update business record
		public void UpdateBusiness(BusinessContact contact) {
			String sql = "{CALL updateBusiness(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)}";
			try {
				CallableStatement cst = con.prepareCall(sql);
				cst.setString(1, Integer.toString(contact.ContactID)); //id of the contact to know which one to change
		        cst.setString(2, contact.ContactFname);//setting the values of the parameters
		        cst.setString(3, contact.ContactLname);
		        cst.setString(4, contact.ContactTel);
		        cst.setString(5, contact.BusinessTel);
		        cst.setString(6, contact.ContactEmail);
		        cst.setString(7, contact.ContactAddr1);
		        cst.setString(8, contact.ContactAddr2);
		        cst.setString(9, contact.ContactCity);
		        cst.setString(10, contact.ContactPostcode);
		        cst.executeQuery();
			} catch (SQLException e) {
				e.printStackTrace();
			}
			
		}
		
		//Delete business record
		public void DeleteBusiness(int id) {
			String sql = "{CALL deleteBusiness(?)}";
			try {
				CallableStatement cst = con.prepareCall(sql);
				cst.setString(1, Integer.toString(id)); //id of the contact to know which one to delete
		        cst.executeQuery();
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}
}
