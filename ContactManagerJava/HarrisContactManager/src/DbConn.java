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
}
