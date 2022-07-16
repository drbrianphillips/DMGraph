using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;//Allows file reading and writing
using System.Diagnostics;
using System.Reflection;

namespace Graphing_DRAINMOD
{
    public partial class Main2 : Form
    {
        #region "Instantiate Plots"


        //*******************************************************
        //Instantiate Forms to Embed
        //******************************************************* 
        Plot_General Plot_General = new Plot_General();
        Plot_XAxis Plot_XAxis = new Plot_XAxis();
        Plot_PrimaryY Plot_PrimaryY = new Plot_PrimaryY();
        Plot_SecondaryY Plot_SecondaryY = new Plot_SecondaryY();

        Plot_Observed1 Plot_Observed1 = new Plot_Observed1();
        Plot_Observed2 Plot_Observed2 = new Plot_Observed2();
        Plot_Observed3 Plot_Observed3 = new Plot_Observed3();

        Plot_WaterTableDepth Plot_WaterTableDepth = new Plot_WaterTableDepth();
        Plot_DryZoneDepth Plot_DryZoneDepth = new Plot_DryZoneDepth();
        Plot_SurfaceStorage Plot_SurfaceStorage = new Plot_SurfaceStorage();
        Plot_Rainfall Plot_Rainfall = new Plot_Rainfall();
        Plot_Infiltration Plot_Infiltration = new Plot_Infiltration();
        Plot_Evaporation Plot_Evaporation = new Plot_Evaporation();
        Plot_Drainage Plot_Drainage = new Plot_Drainage();
        Plot_SurfaceRunoff Plot_SurfaceRunoff = new Plot_SurfaceRunoff();
        Plot_WaterLoss Plot_WaterLoss = new Plot_WaterLoss();

        #endregion


        #region "Initialize Plots"

        public Main2()
        {
            InitializeComponent();

            //Expand All Nodes of TreeView
            treeView1.ExpandAll();


            //*******************************************************
            //Child Form Settings
            //******************************************************* 
            Plot_General.FormBorderStyle = FormBorderStyle.None;
            Plot_General.TopLevel = false;
            Plot_General.Visible = false;
            Plot_General.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_General);
            
            Plot_XAxis.FormBorderStyle = FormBorderStyle.None;
            Plot_XAxis.TopLevel = false;
            Plot_XAxis.Visible = false;
            Plot_XAxis.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_XAxis);

            Plot_PrimaryY.FormBorderStyle = FormBorderStyle.None;
            Plot_PrimaryY.TopLevel = false;
            Plot_PrimaryY.Visible = false;
            Plot_PrimaryY.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_PrimaryY);

            Plot_SecondaryY.FormBorderStyle = FormBorderStyle.None;
            Plot_SecondaryY.TopLevel = false;
            Plot_SecondaryY.Visible = false;
            Plot_SecondaryY.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_SecondaryY);

            Plot_Observed1.FormBorderStyle = FormBorderStyle.None;
            Plot_Observed1.TopLevel = false;
            Plot_Observed1.Visible = false;
            Plot_Observed1.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_Observed1);

            Plot_Observed2.FormBorderStyle = FormBorderStyle.None;
            Plot_Observed2.TopLevel = false;
            Plot_Observed2.Visible = false;
            Plot_Observed2.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_Observed2);

            Plot_Observed3.FormBorderStyle = FormBorderStyle.None;
            Plot_Observed3.TopLevel = false;
            Plot_Observed3.Visible = false;
            Plot_Observed3.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_Observed3);

            Plot_WaterTableDepth.FormBorderStyle = FormBorderStyle.None;
            Plot_WaterTableDepth.TopLevel = false;
            Plot_WaterTableDepth.Visible = false;
            Plot_WaterTableDepth.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_WaterTableDepth);

            Plot_DryZoneDepth.FormBorderStyle = FormBorderStyle.None;
            Plot_DryZoneDepth.TopLevel = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_DryZoneDepth.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_DryZoneDepth);

            Plot_SurfaceStorage.FormBorderStyle = FormBorderStyle.None;
            Plot_SurfaceStorage.TopLevel = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_SurfaceStorage.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_SurfaceStorage);

            Plot_Rainfall.FormBorderStyle = FormBorderStyle.None;
            Plot_Rainfall.TopLevel = false;
            Plot_Rainfall.Visible = false;
            Plot_Rainfall.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_Rainfall);

            Plot_Infiltration.FormBorderStyle = FormBorderStyle.None;
            Plot_Infiltration.TopLevel = false;
            Plot_Infiltration.Visible = false;
            Plot_Infiltration.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_Infiltration);

            Plot_Evaporation.FormBorderStyle = FormBorderStyle.None;
            Plot_Evaporation.TopLevel = false;
            Plot_Evaporation.Visible = false;
            Plot_Evaporation.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_Evaporation);

            Plot_Drainage.FormBorderStyle = FormBorderStyle.None;
            Plot_Drainage.TopLevel = false;
            Plot_Drainage.Visible = false;
            Plot_Drainage.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_Drainage);

            Plot_SurfaceRunoff.FormBorderStyle = FormBorderStyle.None;
            Plot_SurfaceRunoff.TopLevel = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_SurfaceRunoff.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_SurfaceRunoff);

            Plot_WaterLoss.FormBorderStyle = FormBorderStyle.None;
            Plot_WaterLoss.TopLevel = false;
            Plot_WaterLoss.Visible = false;
            Plot_WaterLoss.Dock = DockStyle.Fill;
            splitContainerMain.Panel2.Controls.Add(Plot_WaterLoss);


            //GOTO Specified Tree Node
            StreamReader NodeDat = new StreamReader("graphing/node.dat");
            string sTreeNode = NodeDat.ReadLine();
            NodeDat.Close();

            switch (sTreeNode)
            {
                case "NodeGeneral":
                    this.treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
                    break;
                case "NodeXAxis":
                    this.treeView1.SelectedNode = treeView1.Nodes[0].Nodes[1];
                    break;
                case "NodePrimaryY":
                    this.treeView1.SelectedNode = treeView1.Nodes[0].Nodes[2];
                    break;
                case "NodeSecondaryY":
                    this.treeView1.SelectedNode = treeView1.Nodes[0].Nodes[3];
                    break;
                case "NodeObserved1":
                    this.treeView1.SelectedNode = treeView1.Nodes[2].Nodes[0];
                    break;
                case "NodeObserved2":
                    this.treeView1.SelectedNode = treeView1.Nodes[2].Nodes[1];
                    break;
                case "NodeObserved3":
                    this.treeView1.SelectedNode = treeView1.Nodes[2].Nodes[2];
                    break;
                case "NodeWaterTableDepth":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[0];
                    break;
                case "NodeDryZoneDepth":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[1];
                    break;
                case "NodeSurfaceStorage":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[2];
                    break;
                case "NodeRainfall":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[3];
                    break;
                case "NodeInfiltration":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[4];
                    break;
                case "NodeEvaporation":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[5];
                    break;
                case "NodeDrainage":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[6];
                    break;
                case "NodeSurfaceRunoff":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[7];
                    break;
                case "NodeWaterLoss":
                    this.treeView1.SelectedNode = treeView1.Nodes[1].Nodes[8];
                    break;
                default:
                    break;
            }

            
            //READ IN DAT Files
            //Call each forms method to read from preference1.dat
            Plot_XAxis.methodReadFromPreference1();
            Plot_PrimaryY.methodReadFromPreference1();
            Plot_SecondaryY.methodReadFromPreference1();

            Plot_Observed1.methodReadFromPreference1();
            Plot_Observed2.methodReadFromPreference1();
            Plot_Observed3.methodReadFromPreference1();

            Plot_WaterTableDepth.methodReadFromPreference1();
            Plot_DryZoneDepth.methodReadFromPreference1();
            Plot_SurfaceStorage.methodReadFromPreference1();
            Plot_Rainfall.methodReadFromPreference1();
            Plot_Infiltration.methodReadFromPreference1();
            Plot_Evaporation.methodReadFromPreference1();
            Plot_Drainage.methodReadFromPreference1();
            Plot_SurfaceRunoff.methodReadFromPreference1();
            Plot_WaterLoss.methodReadFromPreference1();

            //Call each forms method to read from associated preference 2 files
            Plot_General.methodReadFromPreference2();
            Plot_XAxis.methodReadFromPreference2();
            Plot_PrimaryY.methodReadFromPreference2();
            Plot_SecondaryY.methodReadFromPreference2();

            Plot_Observed1.methodReadFromPreference2();
            Plot_Observed2.methodReadFromPreference2();
            Plot_Observed3.methodReadFromPreference2();

            Plot_WaterTableDepth.methodReadFromPreference2();
            Plot_DryZoneDepth.methodReadFromPreference2();
            Plot_SurfaceStorage.methodReadFromPreference2();
            Plot_Rainfall.methodReadFromPreference2();
            Plot_Infiltration.methodReadFromPreference2();
            Plot_Evaporation.methodReadFromPreference2();
            Plot_Drainage.methodReadFromPreference2();
            Plot_SurfaceRunoff.methodReadFromPreference2();
            Plot_WaterLoss.methodReadFromPreference2();
               
        }

#endregion


        #region "Changed Tree Selection Method"

        //*******************************************************
        //Changed Tree Selection Method
        //******************************************************* 
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            switch (e.Node.Name)
            {
                case "NodePlotArea":
                    methodEmbedPlot_General();
                    break;
                case "NodeGeneral": 
                    methodEmbedPlot_General(); 
                    break;
                case "NodeXAxis":
                    methodEmbedPlot_XAxis();
                    break;
                case "NodePrimaryY":
                    methodEmbedPlot_PrimaryY();
                    break;
                case "NodeSecondaryY":
                    methodEmbedPlot_SecondaryY();
                    break;
                case "NodeObserved":
                    methodEmbedPlot_Observed1();
                    break;
                case "NodeObserved1":
                    methodEmbedPlot_Observed1();
                    break;
                case "NodeObserved2":
                    methodEmbedPlot_Observed2();
                    break;
                case "NodeObserved3":
                    methodEmbedPlot_Observed3();
                    break;
                case "NodeHydrology":
                    methodEmbedPlot_WaterTableDepth();
                    break;
                case "NodeWaterTableDepth":
                    methodEmbedPlot_WaterTableDepth();
                    break;
                case "NodeDryZoneDepth":
                    methodEmbedPlot_DryZoneDepth();
                    break;
                case "NodeSurfaceStorage":
                    methodEmbedPlot_SurfaceStorage();
                    break;
                case "NodeRainfall":
                    methodEmbedPlot_Rainfall();
                    break;
                case "NodeInfiltration":
                    methodEmbedPlot_Infiltration();
                    break;
                case "NodeEvaporation":
                    methodEmbedPlot_Evaporation();
                    break;
                case "NodeDrainage":
                    methodEmbedPlot_Drainage();
                    break;
                case "NodeSurfaceRunoff":
                    methodEmbedPlot_SurfaceRunoff();
                    break;
                case "NodeWaterLoss":
                    methodEmbedPlot_WaterLoss();
                    break;
                default:
                    break;
            }

        }

        

        #endregion


        #region "Show Forms in Panel Methods"

        //*******************************************************
        //Showing correct form in panel
        //******************************************************* 

        private void methodEmbedPlot_General()
        {
            Plot_General.Visible = true; 
            Plot_XAxis.Visible = false; 
            Plot_PrimaryY.Visible = false; 
            Plot_SecondaryY.Visible = false; 

            Plot_Observed1.Visible = false; 
            Plot_Observed2.Visible = false; 
            Plot_Observed3.Visible = false; 

            Plot_WaterTableDepth.Visible = false; 
            Plot_DryZoneDepth.Visible = false; 
            Plot_SurfaceStorage.Visible = false; 
            Plot_Rainfall.Visible = false; 
            Plot_Infiltration.Visible = false; 
            Plot_Evaporation.Visible = false; 
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_XAxis()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = true;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;

        }
        private void methodEmbedPlot_PrimaryY()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = true;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }  
        private void methodEmbedPlot_SecondaryY()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = true;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }    
        private void methodEmbedPlot_Observed1()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = true;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }   
        private void methodEmbedPlot_Observed2()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = true;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_Observed3()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = true;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.SystemColors.Highlight;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.White;
        }
        private void methodEmbedPlot_WaterTableDepth()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = true;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_DryZoneDepth()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = true;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }   
        private void methodEmbedPlot_SurfaceStorage()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = true;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }   
        private void methodEmbedPlot_Rainfall()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = true;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_Infiltration()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = true;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_Evaporation()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = true;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_Drainage()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = true;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_SurfaceRunoff()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = true;
            Plot_WaterLoss.Visible = false;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }
        private void methodEmbedPlot_WaterLoss()
        {
            Plot_General.Visible = false;
            Plot_XAxis.Visible = false;
            Plot_PrimaryY.Visible = false;
            Plot_SecondaryY.Visible = false;

            Plot_Observed1.Visible = false;
            Plot_Observed2.Visible = false;
            Plot_Observed3.Visible = false;

            Plot_WaterTableDepth.Visible = false;
            Plot_DryZoneDepth.Visible = false;
            Plot_SurfaceStorage.Visible = false;
            Plot_Rainfall.Visible = false;
            Plot_Infiltration.Visible = false;
            Plot_Evaporation.Visible = false;
            Plot_Drainage.Visible = false;
            Plot_SurfaceRunoff.Visible = false;
            Plot_WaterLoss.Visible = true;

            this.treeView1.Nodes[0].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[0].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[2].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[3].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[4].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[5].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[6].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[7].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[1].Nodes[8].BackColor = System.Drawing.SystemColors.Highlight;
            this.treeView1.Nodes[2].Nodes[0].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[1].BackColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[2].BackColor = System.Drawing.Color.White;

            this.treeView1.Nodes[0].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[0].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[2].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[3].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[4].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[5].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[6].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[7].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[1].Nodes[8].ForeColor = System.Drawing.Color.White;
            this.treeView1.Nodes[2].Nodes[0].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[1].ForeColor = System.Drawing.Color.Black;
            this.treeView1.Nodes[2].Nodes[2].ForeColor = System.Drawing.Color.Black;
        }

        
        //private void embedForm22(Form frm)
        //{
        //    //Handle Writing Current Forms Data to File before moving to New Form
        //    //

        //    sPreviousNode = treeView1.SelectedNode.Name;

        //    //END TEST


        //    // Remove existing controls
        //    foreach (Control ctl in splitContainerMain.Panel2.Controls) ctl.Dispose();
        //    splitContainerMain.Panel2.Controls.Clear();
        //    // Whack <frm> to turn it into a child control
        //    frm.FormBorderStyle = FormBorderStyle.None;
        //    frm.TopLevel = false;
        //    frm.Visible = true;
        //    frm.Dock = DockStyle.Fill;
        //    splitContainerMain.Panel2.Controls.Add(frm);
            
        //}
#endregion


        #region "Buttons"

        //*******************************************************
        //Buttons
        //******************************************************* 

        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Write CANCEL to Cacel.dat file
            //This will trigger main plot form to NOT reload format scheme
            methodCancelKey();

            this.Close();
        }

        private void buttonApplyClose_Click(object sender, EventArgs e)
        {
            //Write RELOAD to Cancel.dat file
            //This will trigger main plot form to reload format scheme
            methodReloadKey();

            //Call each forms method to save to preference1.dat
            //Order is important!!!!!!!
            Plot_XAxis.methodSaveToPreference1();
            Plot_PrimaryY.methodSaveToPreference1();
            Plot_SecondaryY.methodSaveToPreference1();

            Plot_Observed1.methodSaveToPreference1();
            Plot_Observed2.methodSaveToPreference1();
            Plot_Observed3.methodSaveToPreference1();

            Plot_WaterTableDepth.methodSaveToPreference1();
            Plot_DryZoneDepth.methodSaveToPreference1();
            Plot_SurfaceStorage.methodSaveToPreference1();
            Plot_Rainfall.methodSaveToPreference1();
            Plot_Infiltration.methodSaveToPreference1();
            Plot_Evaporation.methodSaveToPreference1();
            Plot_Drainage.methodSaveToPreference1();
            Plot_SurfaceRunoff.methodSaveToPreference1();
            Plot_WaterLoss.methodSaveToPreference1();

            //Call each forms method to save to associated preference 2 files
            Plot_General.methodSaveToPreference2();
            Plot_XAxis.methodSaveToPreference2();
            Plot_PrimaryY.methodSaveToPreference2();
            Plot_SecondaryY.methodSaveToPreference2();

            Plot_Observed1.methodSaveToPreference2();
            Plot_Observed2.methodSaveToPreference2();
            Plot_Observed3.methodSaveToPreference2();

            Plot_WaterTableDepth.methodSaveToPreference2();
            Plot_DryZoneDepth.methodSaveToPreference2();
            Plot_SurfaceStorage.methodSaveToPreference2();
            Plot_Rainfall.methodSaveToPreference2();
            Plot_Infiltration.methodSaveToPreference2();
            Plot_Evaporation.methodSaveToPreference2();
            Plot_Drainage.methodSaveToPreference2();
            Plot_SurfaceRunoff.methodSaveToPreference2();
            Plot_WaterLoss.methodSaveToPreference2();


            this.Close();
        }

        #endregion    


        #region "Key Files"

        //*******************************************************
        //Cancel Key File
        //******************************************************* 

        public void methodCancelKey()
        {
            using (StreamWriter sw5 = new StreamWriter("Graphing/Cancel.dat"))
            {

                sw5.WriteLine("CANCEL");
                sw5.WriteLine(DateTime.Now.ToLongTimeString().ToString());

                //Clean up and close file
                sw5.Flush();
                sw5.Close();

            }//close writer
        }//close method

        public void methodReloadKey()
        {
            using (StreamWriter sw6 = new StreamWriter("Graphing/Cancel.dat"))
            {
                
                sw6.WriteLine("RELOAD");
                sw6.WriteLine(DateTime.Now.ToLongTimeString().ToString());


                //Clean up and close file
                sw6.Flush();
                sw6.Close();

            }//close writer

            using (StreamWriter sw50 = new StreamWriter("Graphing/Time.dat"))
            {

                sw50.WriteLine(DateTime.Now.ToLongTimeString().ToString());

                //Clean up and close file
                sw50.Flush();
                sw50.Close();

            }//close writer



        }//close method


        #endregion

 
    }
}
