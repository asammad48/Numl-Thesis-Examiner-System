<%@ Page EnableEventValidation="false" Title="" Language="C#" MasterPageFile="Coordinator.Master" AutoEventWireup="true" CodeBehind="addcase.aspx.cs" Inherits="Numl_Thesis_Examiner_System.addcase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="forms" runat="server">
 <section class="content-wrapper">
    <!-- Content Header (Page header) -->
    <div class="content-header">
      <div class="container-fluid">
        <div class="row">
            <div class="col-sm-4"></div>
          <div class="col-sm-4 text-center">
            <h1 class="m-0 text-dark">Add Case</h1>
          </div>
            <div class="col-sm-4"></div><!-- /.col -->          
        </div><!-- /.row -->
      </div>
    <!-- /.container-fluid -->
    </div>
    <section class="content">
        <div class="row">
            <div class="col-sm-1">
                </div>
            <div class="col-sm-10">
    <div class="card card-info">
              <div class="card-header">
                <h3 class="card-title">Add Case Details</h3>
              </div>
              <!-- /.card-header -->
              <!-- form start -->
              <for class="form-horizontal" >
                <div class="card-body" id="form">
                    <div class="form-group row text-center">
                        <asp:Label runat="server" ID="alert" Visible="false" class="col-sm-12 alert alert-success" role="alert"></asp:Label>
                        </div>
                  <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Thesis Title:<label class="text-danger font-weight-bold">*</label></label>                      
                    <div class="col-sm-8">
                        <asp:TextBox ID="thesistitle" class="form-control" runat="server" required></asp:TextBox>
                  </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Student Name:<label class="text-danger font-weight-bold">*</label></label>                      
                    <div class="col-sm-8">
                        <asp:TextBox ID="studentname" class="form-control" runat="server" required></asp:TextBox>
                    </div>
                  </div>
                  <div class="form-group row">
                    <label class="col-sm-2 col-form-label">Registration No:<label class="text-danger font-weight-bold">*</label></label>
                    <div class="col-sm-4">
                        <asp:TextBox ID="registrationno" class="form-control" runat="server" required></asp:TextBox>
                     </div>
                     <label class="col-sm-2 col-form-label">&nbsp;&nbsp;Program:</label>
                      <div class="col-sm-2">
                      <asp:DropDownList ID="programddl" class="form-control" runat="server" ></asp:DropDownList>
                      </div>
                  </div>                 
                  <div class="form-group row">
                   <label class="col-sm-2 col-form-label">Type:</label>
                      <div class="col-sm-3">
                        <select id="type" runat="server" class="form-control">
                         <option class="form-control">Student</option>
                         <option class="form-control">Faculty</option>
                        </select>
                      </div>                    
                    <label class="col-sm-2 col-form-label">Plagerism Check:<label class="text-danger font-weight-bold">*</label></label>
                     <div class="col-sm-4">
                       <span>
                      <input type="radio" name="plagerismcheck" id="pc1" onclick="show()" required/><label class=" col-form-label">Yes</label>&nbsp;&nbsp;
                      <input type="radio" name="plagerismcheck" id="pc0" onclick="hide()" /><label class=" col-form-label">No</label>
                       </span>
                    </div>
                  </div>
                    
                  <div class="form-group row">
                   <label class="col-sm-12 col-form-label text-info text-center">*** Internal Examiner ***</label>                     
                  </div>
                  <div class="form-group row">
                   <label class="col-sm-2 col-form-label">Name:</label>
                      <div class="col-sm-3">
                      <asp:DropDownList ID="internalddl" class="form-control" runat="server"></asp:DropDownList>
                      </div>  
                      <div class="col-sm-3">
                      <asp:Button  class="btn btn-info" ID="iadd" runat="server" Text="Add"></asp:Button>
                      </div>                      
                   </div>
                    <div class="form-group row">
                      <div class="col-sm-3">
                          </div>
                      <div class="col-sm-6">
                       <asp:GridView ID="internalgrid" CssClass="table table-responsive" HeaderStyle-CssClass="bg-info" runat="server"></asp:GridView>
                    </div>                      
                   </div>

                    <div class="form-group row">
                   <label class="col-sm-12 col-form-label text-info text-center">*** External Examiner ***</label>                     
                  </div>
                  <div class="form-group row">
                   <label class="col-sm-2 col-form-label">Specialization:</label>
                      <div class="col-sm-3">
                      <asp:DropDownList ID="especializationddl" class="form-control" runat="server"></asp:DropDownList>
                      </div>  
                   <label class="col-sm-1 col-form-label">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Name:</label>
                      <div class="col-sm-4">
                      <asp:DropDownList ID="ename" class="form-control" runat="server"></asp:DropDownList>
                      </div>  
                      <div class="col-sm-1">
                      <asp:Button  class="btn btn-info" ID="eadd" runat="server" Text="Add"></asp:Button>
                      </div>                      
                   </div>
                   
                    <div class="form-group row">
                        <div class="col-sm-3">
                          </div>
                      <div class="col-sm-6">
                       <asp:GridView ID="externalgrid" CssClass="table table-responsive" HeaderStyle-CssClass="bg-info" runat="server"></asp:GridView>
                    </div>                      
                   </div>

                    <div class="form-group row">
                   <label class="col-sm-12 col-form-label text-info text-center">*** Foreign Examiner ***</label>                     
                  </div>
                  <div class="form-group row">
                   <label class="col-sm-2 col-form-label">Specialization:</label>
                      <div class="col-sm-3">
                      <asp:DropDownList ID="fspecializationddl" class="form-control" runat="server"></asp:DropDownList>
                      </div>  
                   <label class="col-sm-1 col-form-label">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Name:</label>
                      <div class="col-sm-4">
                      <asp:DropDownList ID="fname" class="form-control" runat="server"></asp:DropDownList>
                      </div>  
                      <div class="col-sm-1">
                      <asp:Button  class="btn btn-info" ID="fadd" runat="server" Text="Add"></asp:Button>
                      </div>                      
                   </div>
                   <div class="form-group row">
                       <div class="col-sm-3">
                          </div>
                      <div class="col-sm-6">
                       <asp:GridView ID="foreigngrid" CssClass="table table-responsive" HeaderStyle-CssClass="bg-info" runat="server"></asp:GridView>
                    </div>                      
                   </div>
                  </div>
                <!-- /.card-body -->
                <div class="card-footer text-center">
                  <asp:Button ID="submit" runat="server" class="btn btn-info" Text="Submit" OnClientClick="return answers()" OnClick="submit_Click"></asp:Button>
                </div>
                <!-- /.card-footer -->
              </for>
            </div>
        </div>
                 <div class="col-sm-1">
                     </div>
            </div>
        </section>
       </section>
</asp:Content>
