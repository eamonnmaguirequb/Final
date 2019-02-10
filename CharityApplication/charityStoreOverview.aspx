<%@ Page Title="" Language="C#" MasterPageFile="~/privateStoreLanding.Master" AutoEventWireup="true" CodeBehind="charityStoreOverview.aspx.cs" Inherits="CharityApplication.charityStoreOverview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div id="content-wrapper">

        <div class="container-fluid">

            <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Welcome Back <asp:Literal ID="userLoggedIn" runat="server">Unknown</asp:Literal><asp:Literal ID="userLocation" runat="server">Unknown</asp:Literal></h1>
          </div>
              <!-- Charity Information-->

       <main role="main" class="container">
      <div class="d-flex align-items-center p-3 my-3 text-white-50 bg-purple rounded box-shadow">
     

            <asp:GridView ID="GridViewImage" runat="server" AutoGenerateColumns="False" DataSourceID="sqlImage"  GridLines="None">
                <Columns>
                    <asp:ImageField DataImageUrlField="charityImage" SortExpression="userEmail" />
                </Columns>
            </asp:GridView>
            
            
            <asp:SqlDataSource ID="sqlImage" runat="server" ConnectionString="<%$ ConnectionStrings:dbcon %>" SelectCommand="SELECT [charityImage] FROM [Charity] WHERE [Charity].[charityOrganiser] = @charityStore">
                <SelectParameters>
                    <asp:Parameter Name="charityStore" />
                </SelectParameters>
                </asp:SqlDataSource>

                <br />
                </div>
                 <div class="lh-100">
          <h6 class="mb-0 text-white lh-100">Bootstrap</h6>
          <small>Since 2011</small>
        </div>
           </main>
      </div>

         </div>
    
</asp:Content>
