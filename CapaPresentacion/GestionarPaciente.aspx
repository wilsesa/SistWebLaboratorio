<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="GestionarPaciente.aspx.cs" Inherits="CapaPresentacion.frmGestionarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">REGISTRO DE PACIENTES</h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DOCUMENTO DE IDENTIDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNroDocumento" runat="server" Text="" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>NOMBRES</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtNombres" runat="server" Text="" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>APELLIDO PATERNO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtApPaterno" runat="server" Text="" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>APELLIDO MATERNO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtApMaterno" runat="server" Text="" CssClass="form-control" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>SEXO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                                <asp:ListItem Text="Masculino" />
                                <asp:ListItem Text="Femenino" />
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>EDAD</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtEdad" runat="server" Text="" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>TELÉFONO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtTelefono" runat="server" Text="" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>DIRECCIÓN</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtDireccion" runat="server" Text="" CssClass="form-control" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div align="center">
            <%--<div style="text-align:center">--%>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnRegistrar" Text="Registrar" runat="server" CssClass="btn-primary" Width="200px" Height="40px" OnClick="btnRegistrar_Click" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn-danger" Width="200px" Height="40px" />
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <%--DataTable Part--%>
        <div class="row">
            <div class="col-xs-12">
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title">Lista de Pacientes</h3>
                    </div>
                    <div class="box-body table-responsive">
                        <table id="tbl_pacientes" class="table table-bordered table-hover">
                            <thead>
                                <tr>
                                    <th>Código</th>
                                    <th>Nombres</th>
                                    <th>Apellidos</th>
                                    <th>Sexo</th>
                                    <th>Edad</th>
                                    <th>Dirección</th>
                                    <th>Estado</th>
                                </tr>
                            </thead>
                            <tbody id="tbl_body-table">
                                <%--DATA POR MEDIO DE AJAX--%>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
