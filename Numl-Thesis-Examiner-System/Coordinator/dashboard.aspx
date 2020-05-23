<%@ Page Title="" Language="C#" MasterPageFile="Coordinator.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="Coordinator.Numl_Thesis_Examiner_System.dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="forms" runat="server">
     <!-- Content Wrapper. Contains page content -->
  <section class="content-wrapper">
    <!-- Content Header (Page header) -->
    <div class="content-header">
      <div class="container-fluid">
        <div class="row">
            <div class="col-sm-4"></div>
          <div class="col-sm-4 text-center">
            <h1 class="m-0 text-dark">Dashboard</h1>
          </div>
            <div class="col-sm-4"></div><!-- /.col -->
          
        </div><!-- /.row -->
      </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->

    <!-- Main content -->
    <section class="content">
      <div class="container-fluid">
        <!-- Small boxes (Stat box) -->
           <div class="row ">
               <div class="col-sm-10"></div>&nbsp;&nbsp;&nbsp;&nbsp;
               <label class="col-form-label">Year</label>
                  <div class="col-sm-1">
                      <asp:DropDownList ID="year" runat="server" onchange="getcount();" class="form-control"></asp:DropDownList>
                </div>
               </div>
          <br >
    <div class="row">
                
        <!-- .col-->
          <div class="col-lg-3 col-6">
            <!-- small box -->
            <div class="small-box bg-info">
              <div class="inner">
                <h3 id="total">0</h3>

                <p>Total</p>
              </div>
                <div class="icon">
                <i >
                    <ion-icon name="paper"></ion-icon>
                </i>
              </div>
              <a href="viewpapers.aspx" class="sami small-box-footer" name="All">View
<i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <!-- .col -->
          <div class="col-lg-3 col-6">
            <!-- small box -->
            <div class="small-box bg-warning">
              <div class="inner">
                <h3 id="inprogress">0</h3>

                <p>In Progress </p>
              </div>
              <div class="icon">
                <i><ion-icon name="copy"></ion-icon></i>
              </div>
              <a href="viewpapers.aspx" class="sami small-box-footer" name="Inprogress">View<i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-lg-3 col-6">
            <!-- small box -->                  
            <div class="small-box bg-success">
              <div class="inner">
                <h3 id="approved">0</h3>

                <p>Approved</p>
              </div>
              <div class="icon">
                <i ><ion-icon name="document"></ion-icon></i>
              </div>
              <a href="viewpapers.aspx" class="sami small-box-footer" name="Approved">View<i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
          <!-- ./col -->
          <div class="col-lg-3 col-6">
            <!-- small box -->
            <div class="small-box bg-danger">
              <div class="inner">
                <h3 id="rejected">0</h3>

                <p>Rejected</p>
              </div>
<div class="icon">
                <i ><ion-icon name="close"></ion-icon></i>
              </div>
              <a href="viewpapers.aspx" class="sami small-box-footer" name="Rejected">View<i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
        </div>
          <div class="row">
          <div class="col-lg-3 col-6">
            <!-- small box -->
            <div class="small-box bg-secondary">
              <div class="inner">
                <h3 id="pending">0</h3>

                <p>Pending</p>
              </div>
                <div class="icon">
                <i class="far fa-hourglass"></i>
              </div>
              <a href="viewpapers.aspx" class="sami small-box-footer" name="Pending">View<i class="fas fa-arrow-circle-right"></i></a>
            </div>
          </div>
        </div>
          </div>
          </section>
      </section>
    <script>
        $(".sami").click(function () {
            $.cookie("paperstatus", $(this).attr('name'));
        });
        $(document).ready(function(){
            getcount();
        });
        function getcount() {
            var request = "{'year':'" + $.trim($("[id$='year']  option:selected").text()) + "'}";
           $.ajax({
               type: "POST",
               url: "dashboard.aspx/getcount",
               contentType: "application/json; charset=utf-8",
               data: request,
               dataType: "json",
               success: function (Result) {
                   var data = $.parseJSON(Result.d);
                   $("#total").html(data[0].total);
                   $("#approved").html(data[0].approved);
                   $("#inprogress").html(data[0].inprogress);
                   $("#rejected").html(data[0].rejected);
                   $("#pending").html(data[0].pending);
               }
           });
        }
    </script>
</asp:Content>
