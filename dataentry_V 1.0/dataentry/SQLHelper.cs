using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

/// <summary>
/// Summary description for SQLHelper
/// </summary>
/// 
public class SQLHelper
{
    public static string con = ConfigurationManager.ConnectionStrings["new1"].ConnectionString;
    public static OleDbCommand _objCmd = new OleDbCommand();
    public static DataTable _objDt;
    public static DataSet _objDs;
    public static OleDbDataAdapter _objAdp;
    public static OleDbConnection _objCon;
    public static OleDbDataReader _objDr;

    public SQLHelper()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    static string OpenConnection()
    {
        try
        {
            _objCon = new OleDbConnection(con);
            _objCon.Open();

            return ("");
        }
        catch (Exception e)
        {
            return (e.Message);
        }
    }

    static string CloseConnection()
    {
        try
        {
            _objCon.Close();
            return ("");
        }
        catch (Exception ex)
        {
            return (ex.Message);
        }
    }

    static public DataSet FetchDataSet(string SqlStatement)
    {
        try
        {
            OpenConnection();
            _objAdp = new OleDbDataAdapter(SqlStatement, _objCon);
            _objDs = new DataSet();
            _objAdp.Fill(_objDs);
            return (_objDs);
        }
        catch (Exception ex)
        {

        }
        finally
        {
            CloseConnection();
            _objAdp.Dispose();
        }
        return (null);
    }

    static public DataTable FetchDataTable(string SqlStatement)
    {
        try
        {
            OpenConnection();
            _objAdp = new OleDbDataAdapter(SqlStatement, _objCon);
            _objDt = new DataTable();
            _objAdp.Fill(_objDt);
            return (_objDt);
        }
        catch (Exception e)
        {

        }
        finally
        {
            CloseConnection();
            _objAdp.Dispose();
        }
        return (null);
    }

    static public string ExecuteNonQuery()
    {
        try
        {
            if (_objCon == null)
                _objCon = new OleDbConnection();
            if (_objCon.State == ConnectionState.Closed)
            {
                OpenConnection();
            }

            _objCmd.Connection = _objCon;
            _objCmd.ExecuteNonQuery();
            if (_objCon.State == ConnectionState.Open)
            {
                CloseConnection();
            }
            return "";
        }
        catch (Exception e)
        {
            return (e.Message);
        }
        finally
        {
        }
    }

    static public string ExecuteStatement(string sqlstatement)
    {
        try
        {
            if (_objCon == null)
                _objCon = new OleDbConnection();
            if (_objCon.State == ConnectionState.Closed)
            {
                OpenConnection();
            }
            _objCmd.Connection = _objCon;
            _objCmd.CommandText = sqlstatement;
            string retVal = Convert.ToString(_objCmd.ExecuteScalar());

            if (_objCon.State == ConnectionState.Open)
            {
                CloseConnection();
            }
            return retVal;
        }
        catch (Exception e)
        {
            return (e.Message);
        }
        finally
        {
        }
    }

    public static void Fill_Dropdown(ComboBox ddls, string Query, string DataValueField)
    {
        string sql = Query;
        DataSet ds_ddown = new DataSet();
        ds_ddown.Clear();
        ds_ddown = FetchDataSet(sql);
        ddls.DataSource = ds_ddown.Tables[0].DefaultView;

        ddls.DisplayMember = DataValueField;
        ddls.ValueMember = DataValueField;

        // if (ddls.Items.Count > 0) ddls.SelectedIndex = 0;
    }

    public static void Fill_ListBox(ListBox lsbx, string Query, string DataTextField, string DataValueField, string defText, string defValue)
    {
        string sql = Query;
        DataSet ds_lsbx = new DataSet();
        ds_lsbx.Clear();
        ds_lsbx = FetchDataSet(sql);
        lsbx.DataSource = ds_lsbx.Tables[0].DefaultView;
        //  lsbx.DataTextField = DataTextField;
        //  lsbx.DataValueField = DataValueField;
        //  lsbx.DataBind();

        if (defText == "" && defValue == "")
        {
            //lsbx.Items.Insert(0, "Select");
            lsbx.SelectedIndex = 0;
        }
        else
        {
            //lsbx.Items.Insert(0,defText.ToString());
            lsbx.SelectedIndex = 0;
        }

    }

    public static void BindGridview(DataGridView grd, string qry)
    {
        try
        {
            OpenConnection();
            _objAdp = new OleDbDataAdapter(qry, _objCon);
            _objDt = new DataTable();
            _objAdp.Fill(_objDt);
            grd.DataSource = _objDt;
            //grd.DataBind();
        }
        catch (Exception e)
        {

        }
        finally
        {
        }
    }


}
