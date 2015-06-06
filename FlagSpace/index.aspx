<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="FlagSpace.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" runat="server">
    <!-- Main component for a primary marketing message or call to action -->
    
    <!-- Intro Section -->
    <section id="home" class="intro-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>This is <strong> Surabaya! </strong></h1>
                    <p>City of heroes, where you can find beautiful space, delicious food!</p>
                    <a class="btn btn-default page-scroll" href="#services">Click Me to Scroll Down!</a>
                </div>
            </div>
        </div>
    </section>


    <!-- Services Section -->
    <section id="services" class="services-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1>Project</h1>
                    <p>
                        We build multi-platform apps where user can easily upload and share location around us. Our purpose is to make people know more about our City, we start from Surabaya. Do you interest to join our project? Please do not hesitate to <a class="page-scroll" id="contactlink" href="#contact">Contact Us</a>. This project is open for all, better if you are a member of Start Surabaya. 
                    </p>                    
                    <a class="btn btn-default page-scroll" href="#about">Click Me to Scroll Down!</a>
                </div>            
            </div>
        </div>
    </section>

    <!-- About Section -->
    <section id="about" class="about-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h1 style="color:#000">About Us</h1>
		            <h4>Flag My Space</h4>
                    <p style="color:#000"> We are a bunch of startup-maniacs who want to make something that makes better life (and more fun!) for people. <strong>Start Surabaya</strong></p>
                    <a class="btn btn-default page-scroll" href="#contact">Click Me to Scroll Down!</a>
                </div>
            </div>
        </div>
    </section>


    <!-- Contact Section -->
    <section id="contact" class="contact-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <h3>Contact Us</h3>
                	<h5>Spazio Building 7th floor #709 & #722</h5>
                    <h5>Jl Mayjend Yono Soewoyo kav 3</h5>
                    <h5>Surabaya 60226</h5>
                    <h5>T: + 62 81266695793</h5>
                    <h5>E: flagmysp@flagmy.space</h5>
                <a class="btn btn-default page-scroll" href="#home">Back to Top</a>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" runat="server">
</asp:Content>