using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for UserWelcome
/// </summary>
public class UserWelcome
{
    private SqlConnection connect;
    public UserWelcome()
    {
        string connectString =
            ConfigurationManager.ConnectionStrings["CommunityAssistConnection"].ToString();
        connect = new SqlConnection(connectString);

    }

    public DataTable GetGrantReviews(int grantTypeKey)
    {
        DataTable table = new DataTable();
        string sql = "SELECT GrantReviewDate AS [Date], GrantRequestExplanation AS Explanation, GrantAllocationAmount AS Amount, GrantRequestStatus AS [Status] FROM GrantRequest grq INNER JOIN GrantReview grv ON grq.GrantRequestKey = grv.GrantRequestKey WHERE GrantTypeKey = @GrantTypeKey";
        //string sql = "SELECT * FROM GrantRequest";
        SqlCommand cmd = new SqlCommand(sql, connect);
        cmd.Parameters.AddWithValue("@GrantTypeKey", grantTypeKey);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Close();
        connect.Close();
        return table;
    }

    public DataTable GetPeople()
    {
        DataTable table = new DataTable();
        string sql = "SELECT PersonKey, PersonLastName, PersonFirstName, PersonLastName+ ', ' +PersonFirstName AS PersonName  FROM Person";
        SqlCommand cmd = new SqlCommand(sql, connect);
        SqlDataReader reader = null;
        connect.Open();
        reader = cmd.ExecuteReader();
        table.Load(reader);
        reader.Close();
        connect.Close();
        return table;
    }
}