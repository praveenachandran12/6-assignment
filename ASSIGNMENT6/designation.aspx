<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="designation.aspx.cs" Inherits="ASSIGNMENT6.designation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>designation</title>
    <style>        * {
    margin: 0px 0 0 0px
        }
.container {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    height: 100vh;
    background-color: lightblue;
}
    .container h1 {
        color: white;
        font-family: sans-serif;
        margin: 20px;
    }
.designation {
    display: flex;
    justify-content: center;
    align-items: center;
    width: 1324px;
    color: rgb(255, 255, 255);
    font-size: 18px;
    font-family: sans-serif;
    background-color: lightpink;
    padding: 20px;
            height: 454px;
        }
  .designation input
     {
        border: none;
        padding: 5px;
        margin-top: 10px;
        font-family: sans-serif;
    }
        .designation input:focus
         {
            box-shadow: 3px 3px 10px rgb(228, 228, 228), -3px -3px 10px rgb(224, 224, 224);
        }
    .designation .submit {
        width: 100%;
        padding: 8px 0;
        font-size: 20px;
        color: rgb(44, 44, 44);
        background-color: lightcoral;
        border-radius: 5px;
    }
        .designation .submit:hover {
            box-shadow: 3px 3px 6px rgb(255, 214, 176);
        }
</style>
</head>
<body>
    <div class="container">
     <h1><center>DESIGNATION REGISTRATION</center></h1> 
    <form id="form1" runat="server" class="designation">
       
            <table align="center" class="auto-style1">


  
                
                 <tr>
                     
                         <td>Department Name :</td>
                     <td>
                         <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                     </td>
                 </tr>
                <tr>  
                    <td>Designation :</td>  
                    <td> 
                      <asp:TextBox ID="Designation" runat="server"></asp:TextBox>
                         
                    </td>  
                </tr>
                 
                        
                <tr>  
                    <td class="auto-style1">  
                      <center style="height: 65px"> <asp:Button   ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click"/>  
                          <br />
                          <br />
                          <br />
                        </center> 
                    </td>  
                </tr>
                </table> <br /><br />
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="designationid" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None" Height="202px" Width="562px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="depname" HeaderText="Department" />
                    <asp:BoundField DataField="designationname" HeaderText="Designation" />
                    <asp:CommandField HeaderText="Update" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                    <asp:HyperLinkField DataNavigateUrlFields="designationid" DataNavigateUrlFormatString="WebForm1.aspx?did={0}" HeaderText="Go to next page" Text="Go" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        
            <br />
            <br />
            <br />
            <br />
        
    </form>
        </div>
</body>
</html>
