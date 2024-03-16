<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <strong>
                    <asp:Label for="id" runat="server" Text="Öğrenci Id:"></asp:Label>
                </strong>
                <br />
                <asp:TextBox ID="id" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtad" runat="server" Text="Öğrenci Ad:"></asp:Label>
                </strong>
                <br />
                <asp:TextBox ID="txtad" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtsoyad" runat="server" Text="Öğrenci Soyad:"></asp:Label>
                </strong>
                <br />
                <asp:TextBox ID="txtsoyad" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtno" runat="server" Text="Öğrenci Numara:"></asp:Label>
                </strong>
                <br />
                <asp:TextBox ID="txtno" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtsifre" runat="server" Text="Öğrenci Şifre:"></asp:Label>
                </strong>
                <br />
                <asp:TextBox ID="txtsifre" runat="server"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="txtfoto" runat="server" Text="Öğrenci Fotoğraf:"></asp:Label>
                </strong>
                <br />
                <asp:TextBox ID="txtfoto" runat="server"></asp:TextBox>
            </div>


        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle" CssClass="btn btn-info" OnClick="Button1_Click" />

    </form>
</asp:Content>



