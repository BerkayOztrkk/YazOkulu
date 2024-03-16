<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <strong>
                <asp:Label for="TextBox1" runat="server" Text="Öğrenci Ad:"></asp:Label>
                 </strong>
                 <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TextBox2" runat="server" Text="Öğrenci Soyad:"></asp:Label>
                 </strong>
                 <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TextBox3" runat="server" Text="Öğrenci Numara:"></asp:Label>
                 </strong>
                 <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TextBox4" runat="server" Text="Öğrenci Şifre:"></asp:Label>
                </strong>
                <br />
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TextBox5" runat="server" Text="Öğrenci Fotoğraf:"></asp:Label>
                 </strong>
                 <br />
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </div>


        </div>
        <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info" />

    </form>
</asp:Content>


