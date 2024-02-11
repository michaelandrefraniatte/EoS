using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EoSResol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e.KeyData);
        }
        private void OnKeyDown(Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                const string message = "• Author: Michaël André Franiatte.\n\r\n\r• Contact: michael.franiatte@gmail.com.\n\r\n\r• Publisher: https://github.com/michaelandrefraniatte.\n\r\n\r• Copyrights: All rights reserved, no permissions granted.\n\r\n\r• License: Not open source, not free of charge to use.";
                const string caption = "About";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
        }
        //int text;
        double xH2S;
        double xO2;
        double xCO;
        double xN2;
        double xNH3;
        double xCO2;
        double xH2O;
        double xH2;
        double yH2S;
        double yO2;
        double yCO;
        double yN2;
        double yNH3;
        double yCO2;
        double yH2O;
        double yH2;
        double MH2S;
        double MO2;
        double MCO;
        double MN2;
        double MNH3;
        double MCO2;
        double MH2O;
        double MH2;
        double sumy;
        double XH2Obis;
        double XCO2bis;
        double XCObis;
        double XH2bis;
        double XN2bis;
        double XCH4bis;
        double XNH3bis;
        double XMGbis;
        double Pb;
        double P;
        double T;
        double TcH2O;//température critique de H2O dans la cellule J8
        double PcH2O;//pression critique de H2O
        double TcCO2;
        double PcCO2;
        double TcCO;
        double PcCO;
        double TcH2;
        double PcH2;
        double TcN2;
        double PcN2;
        double TcCH4;
        double PcCH4;
        double TcNH3;
        double PcNH3;
        double TcMG;
        double PcMG;
        double R;
        double wH2O;
        double nH2O;
        double alphaH2O;
        double wCO2;
        double nCO2;
        double alphaCO2;
        double wCO;
        double nCO;
        double alphaCO;
        double wH2;
        double nH2;
        double alphaH2;
        double wN2;
        double nN2;
        double alphaN2;
        double wCH4;
        double nCH4;
        double alphaCH4;
        double wNH3;
        double nNH3;
        double alphaNH3;
        double wMG;
        double nMG;
        double alphaMG;
        double AH2;
        double BH2;
        double ACO2;
        double BCO2;
        double AN2;
        double BN2;
        double AH2O;
        double BH2O;
        double ACO;
        double BCO;
        double ACH4;
        double BCH4;
        double ANH3;
        double BNH3;
        double AMG;
        double BMG;
        double grAbis;
        double grAsuite;
        double GRA;
        double GRB;
        double test;
        double ZN;
        double FZ;
        double FpZ;
        double ZN1;
        double VN;
        double V;
        double BiH2;
        double BiCO2;
        double BiN2;
        double BiH2O;
        double BiCO;
        double BiCH4;
        double BiNH3;
        double BiMG;
        double A;
        double B;
        double ArH2;
        double ArCO2;
        double ArN2;
        double ArH2O;
        double ArCO;
        double ArCH4;
        double ArNH3;
        double ArMG;
        double SB;
        double DVDXH2;
        double DVDXCO2;
        double DVDXN2;
        double DVDXH2O;
        double DVDXCO;
        double DVDXCH4;
        double DVDXNH3;
        double DVDXMG;
        double VCO2M;
        double VCOM;
        double VH2M;
        double VN2M;
        double VCH4M;
        double VNH3M;
        double VH2OM;
        double VMGM;
        double logFIH2O;
        double FIH2Oinc;
        double FUH2Oinc;
        double FUH2Oi;
        double logFIH2;
        double FIH2inc;
        double FUH2inc;
        double FUH2i;
        double logFICO;
        double FICOinc;
        double FUCOinc;
        double FUCOi;
        double logFICO2;
        double FICO2inc;
        double FUCO2inc;
        double FUCO2i;
        double logFIN2;
        double FIN2inc;
        double FUN2inc;
        double FUN2i;
        double logFICH4;
        double FICH4inc;
        double FUCH4inc;
        double FUCH4i;
        double logFINH3;
        double FINH3inc;
        double FUNH3inc;
        double FUNH3i;
        double logFIMG;
        double FIMGinc;
        double FUMGinc;
        double FUMGi;
        double M;
        double Vlgg;
        double Vlglg;
        double Vgg;
        double xl;
        double LogKr;
        double LogKeq;
        double LogKrLogkeq;
        private void button1_Click(object sender, EventArgs e)
        {
            //text = 10;
            //textBox1.Text = text.ToString();
            //text = Int16.Parse(textBox1.Text.ToString()) + 10;
            //textBox1.Text = text.ToString();
            xH2S = Double.Parse(textBox57.Text.ToString());
            xO2 = Double.Parse(textBox58.Text.ToString());
            xCO = Double.Parse(textBox59.Text.ToString());
            xN2 = Double.Parse(textBox60.Text.ToString());
            xNH3 = Double.Parse(textBox61.Text.ToString());
            xCO2 = Double.Parse(textBox62.Text.ToString());
            xH2O = Double.Parse(textBox63.Text.ToString());
            xH2 = Double.Parse(textBox64.Text.ToString());
            xH2S = Double.Parse(textBox57.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            xO2 = Double.Parse(textBox58.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            xCO = Double.Parse(textBox59.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            xN2 = Double.Parse(textBox60.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            xNH3 = Double.Parse(textBox61.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            xCO2 = Double.Parse(textBox62.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            xH2O = Double.Parse(textBox63.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            xH2 = Double.Parse(textBox64.Text.ToString()) / (Double.Parse(textBox57.Text.ToString()) + Double.Parse(textBox58.Text.ToString()) + Double.Parse(textBox59.Text.ToString()) + Double.Parse(textBox60.Text.ToString()) + Double.Parse(textBox61.Text.ToString()) + Double.Parse(textBox62.Text.ToString()) + Double.Parse(textBox63.Text.ToString()) + Double.Parse(textBox64.Text.ToString()));
            textBox57.Text = xH2S.ToString(); //"H2";//xH2S
            textBox58.Text = xO2.ToString(); //"H2O";//xO2
            textBox59.Text = xCO.ToString(); //"CO2";//xCO
            textBox60.Text = xN2.ToString(); //"NH3";//xN2
            textBox61.Text = xNH3.ToString(); //"N2";//xNH3
            textBox62.Text = xCO2.ToString(); //"CO";//xCO2
            textBox63.Text = xH2O.ToString(); //"O2";//xH2O
            textBox64.Text = xH2.ToString(); //"H2S";//xH2
            MH2S = Double.Parse(textBox49.Text.ToString());//MH2S
            MO2 = Double.Parse(textBox50.Text.ToString());//MO2
            MCO = Double.Parse(textBox51.Text.ToString());//MCO
            MN2 = Double.Parse(textBox52.Text.ToString());//MN2
            MNH3 = Double.Parse(textBox53.Text.ToString());//MNH3
            MCO2 = Double.Parse(textBox54.Text.ToString());//MCO2
            MH2O = Double.Parse(textBox55.Text.ToString());//MH2O
            MH2 = Double.Parse(textBox56.Text.ToString());//MH2
            yH2S = xH2S * MH2S / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            yO2 = xO2 * MO2 / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            yCO = xCO * MCO / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            yN2 = xN2 * MN2 / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            yNH3 = xNH3 * MNH3 / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            yCO2 = xCO2 * MCO2 / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            yH2O = xH2O * MH2O / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            yH2 = xH2 * MH2 / (xH2S * MH2S + xO2 * MO2 + xCO * MCO + xCO2 * MCO2 + xN2 * MN2 + xCO2 * MCO2 + xH2O * MH2O + xH2 * MH2);
            sumy = yH2S + yO2 + yCO + yN2 + yNH3 + yCO2 + yH2O + yH2;
            yH2S = yH2S / sumy;
            yO2 = yO2 / sumy;
            yCO = yCO / sumy;
            yN2 = yN2 / sumy;
            yNH3 = yNH3 / sumy;
            yCO2 = yCO2 / sumy;
            yH2O = yH2O / sumy;
            yH2 = yH2 / sumy;
            textBox65.Text = yH2S.ToString();//yH2S
            textBox66.Text = yO2.ToString();//yO2
            textBox67.Text = yCO.ToString();//yCO
            textBox68.Text = yN2.ToString();//yN2
            textBox69.Text = yNH3.ToString();//yNH3
            textBox70.Text = yCO2.ToString();//yCO2
            textBox71.Text = yH2O.ToString();//yH2O
            textBox72.Text = yH2.ToString();//yH2
            /////////////////////////////////////////
            XH2Obis = Double.Parse(textBox63.Text.ToString());
            XCO2bis = Double.Parse(textBox62.Text.ToString());
            XCObis = Double.Parse(textBox61.Text.ToString());
            XH2bis = Double.Parse(textBox64.Text.ToString());
            XN2bis = Double.Parse(textBox58.Text.ToString());
            XCH4bis = Double.Parse(textBox60.Text.ToString());
            XNH3bis = Double.Parse(textBox57.Text.ToString());
            XMGbis = Double.Parse(textBox59.Text.ToString());
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            textBox78.Text = VCO2M.ToString();
            textBox77.Text = VCOM.ToString();
            textBox80.Text = VH2M.ToString();
            textBox74.Text = VN2M.ToString();
            textBox76.Text = VCH4M.ToString();
            textBox73.Text = VNH3M.ToString();
            textBox79.Text = VH2OM.ToString();
            textBox75.Text = VMGM.ToString();
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox87.Text = FUH2Oi.ToString();
            textBox86.Text = FUCO2i.ToString();
            textBox85.Text = FUCOi.ToString();
            textBox88.Text = FUH2i.ToString();
            textBox82.Text = FUN2i.ToString();
            textBox84.Text = FUCH4i.ToString();
            textBox81.Text = FUNH3i.ToString();
            textBox83.Text = FUMGi.ToString();
            /////////////////////////
            M = MH2 * xH2 + MH2O * xH2O + MCO2 * xCO2 + MNH3 * xNH3 + MN2 * xN2 + MCO * xCO + MO2 * xO2 + MH2S * xH2S;
            textBox12.Text = M.ToString();
            Vlgg = VMGM + VH2OM + VNH3M + VCH4M + VN2M + VH2M + VCOM + VCO2M;
            textBox13.Text = Vlgg.ToString();
            Vlglg = Vlgg / 2;
            textBox14.Text = Vlglg.ToString();
            Vgg = Vlgg - M;
            textBox15.Text = Vgg.ToString();
            xl = M / Vlgg;
            textBox16.Text = xl.ToString();
            textBox125.Text = (M / Vlglg).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Hello";
            textBox1.Text = "P (bars)";
            textBox117.Text = "P (bars)";
            textBox2.Text = "T (°C)";
            textBox118.Text = "T (°C)";
            textBox3.Text = "constituent";
            textBox4.Text = "Pc (bars)";
            textBox5.Text = "Tc (K)";
            textBox6.Text = "wc";
            textBox7.Text = "M (g/mol)";
            textBox8.Text = "molar fraction";
            textBox9.Text = "massic fraction";
            textBox10.Text = "molar V (cm3/mol)";
            textBox11.Text = "fugacity";
            textBox12.Text = "molar V Liq";
            textBox119.Text = "molar V Liq";
            textBox13.Text = "V Liq+Gaz/Gaz";
            textBox120.Text = "V Liq+Gaz/Gaz";
            textBox14.Text = "V Liq+Gaz/Liq+Gaz";
            textBox121.Text = "V Liq+Gaz/Liq+Gaz";
            textBox15.Text = "V Gaz/Gaz";
            textBox122.Text = "V Gaz/Gaz";
            textBox16.Text = "density, xl (g/cm3)";
            textBox123.Text = "density, xl (g/cm3)";
            textBox17.Text = "H2";
            textBox18.Text = "H2O";
            textBox19.Text = "CO2";
            textBox20.Text = "NH3";
            textBox21.Text = "N2";
            textBox22.Text = "CO";
            textBox23.Text = "O2";
            textBox24.Text = "H2S";
            textBox25.Text = "89.4"; //"H2";//PcH2S
            textBox26.Text = "50.5"; //"H2O";//PcO2
            textBox27.Text = "35"; //"CO2";//PcCO
            textBox28.Text = "33.9"; //"NH3";//PcN2
            textBox29.Text = "113.33"; //"N2";//PcNH3
            textBox30.Text = "73.8"; //"CO";//PcCO2
            textBox31.Text = "221.2"; //"O2";//PcH2O
            textBox32.Text = "12.97"; //"H2S";//PcH2
            textBox33.Text = "373.2";//TcH2S
            textBox34.Text = "154.6";//TcO2
            textBox35.Text = "132.9";//TcCO
            textBox36.Text = "126.2";//TcN2
            textBox37.Text = "405.40";//TcNH3
            textBox38.Text = "304.2";//TcCO2
            textBox39.Text = "647.30";//TcH2O
            textBox40.Text = "33.3";//TcH2
            textBox41.Text = "0.1";//wcH2S
            textBox42.Text = "0.021";//wcO2
            textBox43.Text = "0.049";//wcCO
            textBox44.Text = "0.04";//wcN2
            textBox45.Text = "0.25601";//wcNH3
            textBox46.Text = "0.225";//wcCO2
            textBox47.Text = "0.344";//wcH2O
            textBox48.Text = "-0.215";//wcH2
            textBox49.Text = "34.0814";//MH2S
            textBox50.Text = "32.0852";//MO2
            textBox51.Text = "28.0102";//MCO
            textBox52.Text = "28.0134";//MN2
            textBox53.Text = "17.03040";//MNH3
            textBox54.Text = "44.0096";//MCO2
            textBox55.Text = "18.0158";//MH2O
            textBox56.Text = "2.0158";//MH2
            textBox57.Text = "0.000000"; //"H2";//xH2S
            textBox58.Text = "0.00122"; //"H2O";//xO2
            textBox59.Text = "0.00000"; //"CO2";//xCO
            textBox60.Text = "0.02859"; //"NH3";//xN2
            textBox61.Text = "0.00000"; //"N2";//xNH3
            textBox62.Text = "0.22871"; //"CO";//xCO2
            textBox63.Text = "0.62712"; //"O2";//xH2O
            textBox64.Text = "0.11435"; //"H2S";//xH2
            textBox65.Text = "H2S"; //"H2";//yH2S
            textBox66.Text = "O2"; //"H2O";//yO2
            textBox67.Text = "CO"; //"CO2";//yCO
            textBox68.Text = "N2"; //"NH3";//yN2
            textBox69.Text = "NH3"; //"N2";//yNH3
            textBox70.Text = "CO2"; //"CO";//yCO2
            textBox71.Text = "H2O"; //"O2";//yH2O
            textBox72.Text = "H2"; //"H2S";//yH2
            textBox73.Text = "H2S"; //"H2";//vH2S
            textBox74.Text = "O2"; //"H2O";//vO2
            textBox75.Text = "CO"; //"CO2";//vCO
            textBox76.Text = "N2"; //"NH3";//vN2
            textBox77.Text = "NH3"; //"N2";//vNH3
            textBox78.Text = "CO2"; //"CO";//vCO2
            textBox79.Text = "H2O"; //"O2";//vH2O
            textBox80.Text = "H2"; //"H2S";//vH2
            textBox81.Text = "H2S"; //"H2";//fH2S
            textBox82.Text = "O2"; //"H2O";//fO2
            textBox83.Text = "CO"; //"CO2";//fCO
            textBox84.Text = "N2"; //"NH3";//fN2
            textBox85.Text = "NH3"; //"N2";//fNH3
            textBox86.Text = "CO2"; //"CO";//fCO2
            textBox87.Text = "H2O"; //"O2";//fH2O
            textBox88.Text = "H2"; //"H2S";//fH2
            textBox89.Text = "H2S"; //"H2";//f°H2S
            textBox90.Text = "O2"; //"H2O";//f°O2
            textBox91.Text = "CO"; //"CO2";//f°CO
            textBox92.Text = "N2"; //"NH3";//f°N2
            textBox93.Text = "NH3"; //"N2";//f°NH3
            textBox94.Text = "CO2"; //"CO";//f°CO2
            textBox95.Text = "H2O"; //"O2";//f°H2O
            textBox96.Text = "H2"; //"H2S";//f°H2
            textBox97.Text = "fugacity°";
            textBox98.Text = "0"; //"H2";//RH2S
            textBox99.Text = "0"; //"H2O";//RO2
            textBox100.Text = "0"; //"CO2";//RCO
            textBox101.Text = "0.5"; //"NH3";//RN2
            textBox102.Text = "0"; //"N2";//RNH3
            textBox103.Text = "17"; //"CO";//RCO2
            textBox104.Text = "0"; //"O2";//RH2O
            textBox105.Text = "40.5"; //"H2S";//RH2
            textBox106.Text = "stoechio react";
            textBox107.Text = "0"; //"H2";//PH2S
            textBox108.Text = "0"; //"H2O";//PO2
            textBox109.Text = "0"; //"CO2";//PCO
            textBox110.Text = "0"; //"NH3";//PN2
            textBox111.Text = "0"; //"N2";//PNH3
            textBox112.Text = "0"; //"CO";//PCO2
            textBox113.Text = "30"; //"O2";//PH2O
            textBox114.Text = "0"; //"H2S";//PH2
            textBox115.Text = "stoechio prod";
            textBox116.Text = "Kr/Keq";
            textBox124.Text = "Kr/Keq";
            textBox125.Text = "density global";
            textBox126.Text = "density global";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MH2S = Double.Parse(textBox49.Text.ToString());//MH2S
            MO2 = Double.Parse(textBox50.Text.ToString());//MO2
            MCO = Double.Parse(textBox51.Text.ToString());//MCO
            MN2 = Double.Parse(textBox52.Text.ToString());//MN2
            MNH3 = Double.Parse(textBox53.Text.ToString());//MNH3
            MCO2 = Double.Parse(textBox54.Text.ToString());//MCO2
            MH2O = Double.Parse(textBox55.Text.ToString());//MH2O
            MH2 = Double.Parse(textBox56.Text.ToString());//MH2
            /////////////////////////////////////////
            XH2Obis = 0;
            XCO2bis = 0;
            XCObis = 0;
            XH2bis = 0;
            XN2bis = 0;
            XCH4bis = 0;
            XNH3bis = 1;
            XMGbis = 0;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox89.Text = FUNH3i.ToString();
            ////////////////////////////////////
            /////////////////////////////////////////
            XH2Obis = 0;
            XCO2bis = 0;
            XCObis = 0;
            XH2bis = 0;
            XN2bis = 1;
            XCH4bis = 0;
            XNH3bis = 0;
            XMGbis = 0;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox90.Text = FUN2i.ToString();
            /////////////////////////////////////////////:
            /////////////////////////////////////////
            XH2Obis = 0;
            XCO2bis = 0;
            XCObis = 0;
            XH2bis = 0;
            XN2bis = 0;
            XCH4bis = 0;
            XNH3bis = 0;
            XMGbis = 1;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox91.Text = FUMGi.ToString();
            ////////////////////////////////////////
            /////////////////////////////////////////
            XH2Obis = 0;
            XCO2bis = 0;
            XCObis = 0;
            XH2bis = 0;
            XN2bis = 0;
            XCH4bis = 1;
            XNH3bis = 0;
            XMGbis = 0;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox92.Text = FUCH4i.ToString();
            ///////////////////////////////////////////
            /////////////////////////////////////////
            XH2Obis = 0;
            XCO2bis = 0;
            XCObis = 1;
            XH2bis = 0;
            XN2bis = 0;
            XCH4bis = 0;
            XNH3bis = 0;
            XMGbis = 0;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox93.Text = FUCOi.ToString();
            ///////////////////////////////////////////
            /////////////////////////////////////////
            XH2Obis = 0;
            XCO2bis = 1;
            XCObis = 0;
            XH2bis = 0;
            XN2bis = 0;
            XCH4bis = 0;
            XNH3bis = 0;
            XMGbis = 0;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox94.Text = FUCO2i.ToString();
            ///////////////////////////////////////////////////
            /////////////////////////////////////////
            XH2Obis = 1;
            XCO2bis = 0;
            XCObis = 0;
            XH2bis = 0;
            XN2bis = 0;
            XCH4bis = 0;
            XNH3bis = 0;
            XMGbis = 0;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox95.Text = FUH2Oi.ToString();
            //////////////////////////////////////////
            /////////////////////////////////////////
            XH2Obis = 0;
            XCO2bis = 0;
            XCObis = 0;
            XH2bis = 1;
            XN2bis = 0;
            XCH4bis = 0;
            XNH3bis = 0;
            XMGbis = 0;
            Pb = Double.Parse(textBox1.Text.ToString());
            P = Pb * 100000; //passage de la pression de bar en Pa
            T = Double.Parse(textBox2.Text.ToString()) + 273.15;
            TcH2O = Double.Parse(textBox39.Text.ToString()); //température critique de H2O dans la cellule J8
            PcH2O = Double.Parse(textBox31.Text.ToString()); //pression critique de H2O
            TcCO2 = Double.Parse(textBox38.Text.ToString());
            PcCO2 = Double.Parse(textBox30.Text.ToString());
            TcCO = Double.Parse(textBox37.Text.ToString());
            PcCO = Double.Parse(textBox29.Text.ToString());
            TcH2 = Double.Parse(textBox40.Text.ToString());
            PcH2 = Double.Parse(textBox32.Text.ToString());
            TcN2 = Double.Parse(textBox34.Text.ToString());
            PcN2 = Double.Parse(textBox26.Text.ToString());
            TcCH4 = Double.Parse(textBox36.Text.ToString());
            PcCH4 = Double.Parse(textBox28.Text.ToString());
            TcNH3 = Double.Parse(textBox33.Text.ToString());
            PcNH3 = Double.Parse(textBox25.Text.ToString());
            TcMG = Double.Parse(textBox35.Text.ToString());
            PcMG = Double.Parse(textBox27.Text.ToString());
            R = 8.314472; //constante des gaz parfaits
            ///////////////////////////////////////////////
            //calcul des facteurs acentriques
            wH2O = Double.Parse(textBox47.Text.ToString());
            nH2O = 0.48508 + 1.55171 * wH2O - 0.15613 * Math.Pow(wH2O, 2);
            alphaH2O = Math.Pow(1 + nH2O * (1 - Math.Pow(T / TcH2O, 0.5)), 2);
            wCO2 = Double.Parse(textBox46.Text.ToString());
            nCO2 = 0.48508 + 1.55171 * wCO2 - 0.15613 * Math.Pow(wCO2, 2);
            alphaCO2 = Math.Pow(1 + nCO2 * (1 - Math.Pow(T / TcCO2, 0.5)), 2);
            wCO = Double.Parse(textBox45.Text.ToString());
            nCO = 0.48508 + 1.55171 * wCO - 0.15613 * Math.Pow(wCO, 2);
            alphaCO = Math.Pow(1 + nCO * (1 - Math.Pow(T / TcCO, 0.5)), 2);
            wH2 = Double.Parse(textBox48.Text.ToString());
            nH2 = 0.48508 + 1.55171 * wH2 - 0.15613 * Math.Pow(wH2, 2);
            alphaH2 = Math.Pow(1 + nH2 * (1 - Math.Pow(T / TcH2, 0.5)), 2);
            wN2 = Double.Parse(textBox42.Text.ToString());
            nN2 = 0.48508 + 1.55171 * wN2 - 0.15613 * Math.Pow(wN2, 2);
            alphaN2 = Math.Pow(1 + nN2 * (1 - Math.Pow(T / TcN2, 0.5)), 2);
            wCH4 = Double.Parse(textBox44.Text.ToString());
            nCH4 = 0.48508 + 1.55171 * wCH4 - 0.15613 * Math.Pow(wCH4, 2);
            alphaCH4 = Math.Pow(1 + nCH4 * (1 - Math.Pow(T / TcCH4, 0.5)), 2);
            wNH3 = Double.Parse(textBox41.Text.ToString());
            nNH3 = 0.48508 + 1.55171 * wNH3 - 0.15613 * Math.Pow(wNH3, 2);
            alphaNH3 = Math.Pow(1 + nNH3 * (1 - Math.Pow(T / TcNH3, 0.5)), 2);
            wMG = Double.Parse(textBox43.Text.ToString());
            nMG = 0.48508 + 1.55171 * wMG - 0.15613 * Math.Pow(wMG, 2);
            alphaMG = Math.Pow(1 + nMG * (1 - Math.Pow(T / TcMG, 0.5)), 2);
            /////////////////////////
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //////////////////////////////////
            test = 10;
            ZN = 1000.01; //initialisation NR à changer si plantage
            while (test > 0.000000001)
            {
                FZ = Math.Pow(ZN, 3) - Math.Pow(ZN, 2) + (GRA - Math.Pow(GRB, 2) - GRB) * ZN - GRA * GRB;
                FpZ = 3 * Math.Pow(ZN, 2) - 2 * ZN + (GRA - Math.Pow(GRB, 2) - GRB);
                ZN1 = ZN - FZ / FpZ;
                test = Math.Abs(ZN1 - ZN);
                ZN = ZN1;
            }
            VN = (ZN * R * T / P);
            V = VN * 1000000;
            /////////////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, aialphai et bialphai qui interviennent dans le calcul des coefficients de fugacité
            AH2 = 0.42748 * alphaH2 * (R * Math.Pow(TcH2, 2)) / (PcH2 * 100000);
            BH2 = 0.08664 * R * TcH2 / (PcH2 * 100000);
            BiH2 = BH2; //stockage de bialphai
            ACO2 = 0.42748 * alphaCO2 * (R * Math.Pow(TcCO2, 2)) / (PcCO2 * 100000);
            BCO2 = 0.08664 * R * TcCO2 / (PcCO2 * 100000);
            BiCO2 = BCO2;
            AN2 = 0.42748 * alphaN2 * (R * Math.Pow(TcN2, 2)) / (PcN2 * 100000);
            BN2 = 0.08664 * R * TcN2 / (PcN2 * 100000);
            BiN2 = BN2;
            AH2O = 0.42748 * alphaH2O * (R * Math.Pow(TcH2O, 2)) / (PcH2O * 100000);
            BH2O = 0.08664 * R * TcH2O / (PcH2O * 100000);
            BiH2O = BH2O;
            ACO = 0.42748 * alphaCO * (R * Math.Pow(TcCO, 2)) / (PcCO * 100000);
            BCO = 0.08664 * R * TcCO / (PcCO * 100000);
            BiCO = BCO;
            ACH4 = 0.42748 * alphaCH4 * (R * Math.Pow(TcCH4, 2)) / (PcCH4 * 100000);
            BCH4 = 0.08664 * R * TcCH4 / (PcCH4 * 100000);
            BiCH4 = BCH4;
            ANH3 = 0.42748 * alphaNH3 * (R * Math.Pow(TcNH3, 2)) / (PcNH3 * 100000);
            BNH3 = 0.08664 * R * TcNH3 / (PcNH3 * 100000);
            BiNH3 = BNH3;
            AMG = 0.42748 * alphaMG * (R * Math.Pow(TcMG, 2)) / (PcMG * 100000);
            BMG = 0.08664 * R * TcMG / (PcMG * 100000);
            BiMG = BMG;
            ////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, a et b qui n'interviennent pas dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            A = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            B = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            ////////////////////////////
            //calcul de dérivés de XiXj(1-Kji)racine(aialphai*akalphak)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            /////////////////////////////
            SB = BH2O + BH2 + BCO2 + BN2 + BCO + BNH3 + BCH4 + BMG;
            DVDXH2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXH2O = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArH2O) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCO = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCO) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXN2 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArN2) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXCH4 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArCH4) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXNH3 = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArNH3) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));
            DVDXMG = (-(R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * VN * Math.Pow(VN - B, 2)) * SB + (VN - B) * VN * (Math.Pow(VN, 2) - Math.Pow(B, 2)) * ArMG) / (-R * T * Math.Pow(VN, 2) * Math.Pow(VN + B, 2) + A * (2 * VN + B) * Math.Pow(VN - B, 2));

            VCO2M = (VN * 1 * (XCO2bis) - 1 * (XCO2bis - 0 * XCO2bis) * 1 / 3 / 8 / 2 * DVDXCO2) * 1000000;
            VCOM = (VN * 1 * (XCObis) - 1 * (XCObis - 0 * XCObis) * 1 / 3 / 8 / 2 * DVDXCO) * 1000000;
            VH2M = (VN * 1 * (XH2bis) - 1 * (XH2bis - 0 * XH2bis) * 1 / 3 / 8 / 2 * DVDXH2) * 1000000;
            VN2M = (VN * 1 * (XN2bis) - 1 * (XN2bis - 0 * XN2bis) * 1 / 3 / 8 / 2 * DVDXN2) * 1000000;
            VCH4M = (VN * 1 * (XCH4bis) - 1 * (XCH4bis - 0 * XCH4bis) * 1 / 3 / 8 / 2 * DVDXCH4) * 1000000;
            VNH3M = (VN * 1 * (XNH3bis) - 1 * (XNH3bis - 0 * XNH3bis) * 1 / 3 / 8 / 2 * DVDXNH3) * 1000000;
            VH2OM = (VN * 1 * (XH2Obis) - 1 * (XH2Obis - 0 * XH2Obis) * 1 / 3 / 8 / 2 * DVDXH2O) * 1000000;
            VMGM = (VN * 1 * (XMGbis) - 1 * (XMGbis - 0 * XMGbis) * 1 / 3 / 8 / 2 * DVDXMG) * 1000000;
            //calcul de somme de Xk(1-Kki)racine(aialphai*akalphak)  (avant le 2 dans le calcul du coefficient de fugacité de l'espèce k)
            grAbis = (XMGbis) * Math.Pow(AH2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArH2 = ((XH2bis)) * AH2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO2, 0.5) + grAbis;
            ArCO2 = ((XCO2bis)) * ACO2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO2 * AH2, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AN2 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            ArN2 = ((XN2bis)) * AN2 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AN2, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AN2 * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(AN2 * ACO2, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AN2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(AH2O * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * AH2O, 0.5) + grAbis;
            ArH2O = (XH2Obis) * AH2O + (1 - 0) * (XH2bis) * Math.Pow(AH2O * AH2, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AH2O, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AH2O, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AH2O, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACO * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ACO * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACO, 0.5) + grAbis;
            ArCO = (XCObis) * ACO + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACO, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACO, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACO, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ACO * AH2, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ACH4 * AMG, 0.5);
            grAsuite = (1 - 0) * (XH2bis) * Math.Pow(AH2 * ACH4, 0.5) + (1 - 0) * (XNH3bis) * Math.Pow(ANH3 * ACH4, 0.5) + grAbis;
            ArCH4 = ((XCH4bis)) * ACH4 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ACH4, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ACH4, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ACH4, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ACH4, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XMGbis) * Math.Pow(ANH3 * AMG, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(ANH3 * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(ANH3 * AH2, 0.5) + grAbis;
            ArNH3 = ((XNH3bis)) * ANH3 + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * ANH3, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * ANH3, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * ANH3, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * ANH3, 0.5) + grAsuite;
            grAbis = (1 - 0) * (XNH3bis) * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = (1 - 0) * (XCH4bis) * Math.Pow(AMG * ACH4, 0.5) + (1 - 0) * (XH2bis) * Math.Pow(AMG * AH2, 0.5) + grAbis;
            ArMG = ((XMGbis)) * AMG + (1 - 0) * (XH2Obis) * Math.Pow(AH2O * AMG, 0.5) + (1 - 0) * (XCO2bis) * Math.Pow(ACO2 * AMG, 0.5) + (1 - 0) * (XN2bis) * Math.Pow(AN2 * AMG, 0.5) + (1 - 0) * (XCObis) * Math.Pow(ACO * AMG, 0.5) + grAsuite;
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, Ai et Bi qui interviennent dans le calcul du coefficient de fugacité
            AH2 = 0.42748 * alphaH2 * Math.Pow(TcH2, 2) / (PcH2 * 100000) * P / Math.Pow(T, 2); //avec Tr=T/Tc et Pr=P/Pc
            BH2 = 0.08664 * TcH2 / (PcH2 * 100000) * P / (T);
            ACO2 = 0.42748 * alphaCO2 * Math.Pow(TcCO2, 2) / (PcCO2 * 100000) * P / Math.Pow(T, 2);
            BCO2 = 0.08664 * TcCO2 / (PcCO2 * 100000) * P / (T);
            AN2 = 0.42748 * alphaN2 * Math.Pow(TcN2, 2) / (PcN2 * 100000) * P / Math.Pow(T, 2);
            BN2 = 0.08664 * TcN2 / (PcN2 * 100000) * P / (T);
            AH2O = 0.42748 * alphaH2O * Math.Pow(TcH2O, 2) / (PcH2O * 100000) * P / Math.Pow(T, 2);
            BH2O = 0.08664 * TcH2O / (PcH2O * 100000) * P / (T);
            ACO = 0.42748 * alphaCO * Math.Pow(TcCO, 2) / (PcCO * 100000) * P / Math.Pow(T, 2);
            BCO = 0.08664 * TcCO / (PcCO * 100000) * P / (T);
            ACH4 = 0.42748 * alphaCH4 * Math.Pow(TcCH4, 2) / (PcCH4 * 100000) * P / Math.Pow(T, 2);
            BCH4 = 0.08664 * TcCH4 / (PcCH4 * 100000) * P / (T);
            ANH3 = 0.42748 * alphaNH3 * Math.Pow(TcNH3, 2) / (PcNH3 * 100000) * P / Math.Pow(T, 2);
            BNH3 = 0.08664 * TcNH3 / (PcNH3 * 100000) * P / (T);
            AMG = 0.42748 * alphaMG * Math.Pow(TcMG, 2) / (PcMG * 100000) * P / Math.Pow(T, 2);
            BMG = 0.08664 * TcMG / (PcMG * 100000) * P / (T);
            ///////////////////////////////////
            //calculs des paramètres de repulsion et d'attraction de l'equation d'etat, A et B qui interviennent dans le calcul du coefficient de fugacité
            grAbis = Math.Pow(XMGbis, 2) * AMG + 2 * (1 - 0) * XMGbis * XH2bis * Math.Pow(AMG * AH2, 0.5) + 2 * (1 - 0) * XMGbis * XCO2bis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XN2bis * Math.Pow(AMG * AN2, 0.5) + 2 * (1 - 0) * XMGbis * XH2Obis * Math.Pow(AMG * AH2O, 0.5) + 2 * (1 - 0) * XMGbis * XCObis * Math.Pow(AMG * ACO2, 0.5) + 2 * (1 - 0) * XMGbis * XCH4bis * Math.Pow(AMG * ACH4, 0.5) + 2 * (1 - 0) * XMGbis * XNH3bis * Math.Pow(AMG * ANH3, 0.5);
            grAsuite = Math.Pow(XCH4bis, 2) * ACH4 + Math.Pow(XNH3bis, 2) * ANH3 + 2 * (1 - 0) * XCH4bis * XCObis * Math.Pow(ACO * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2Obis * Math.Pow(AH2O * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XCO2bis * Math.Pow(ACO2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XH2bis * Math.Pow(AH2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XN2bis * Math.Pow(AN2 * ACH4, 0.5) + 2 * (1 - 0) * XCH4bis * XNH3bis * Math.Pow(ANH3 * ACH4, 0.5) + 2 * (1 - 0) * XH2Obis * XNH3bis * Math.Pow(ANH3 * AH2O, 0.5) + 2 * (1 - 0) * XCO2bis * XNH3bis * Math.Pow(ANH3 * ACO2, 0.5) + 2 * (1 - 0) * XCObis * XNH3bis * Math.Pow(ANH3 * ACO, 0.5) + 2 * (1 - 0) * XH2bis * XNH3bis * Math.Pow(ANH3 * AH2, 0.5) + 2 * (1 - 0) * XN2bis * XNH3bis * Math.Pow(ANH3 * AN2, 0.5) + grAbis;
            GRA = Math.Pow(XH2Obis, 2) * AH2O + Math.Pow(XCO2bis, 2) * ACO2 + 2 * (1 - 0) * XH2Obis * XCO2bis * Math.Pow(AH2O * ACO2, 0.5) + Math.Pow(XH2bis, 2) * AH2 + 2 * (1 - 0) * XH2Obis * XH2bis * Math.Pow(AH2O * AH2, 0.5) + Math.Pow(XN2bis, 2) * AN2 + 2 * (1 - 0) * XH2Obis * XN2bis * Math.Pow(AH2O * AN2, 0.5) + 2 * (1 - 0) * XCO2bis * XH2bis * Math.Pow(ACO2 * AH2, 0.5) + 2 * (1 - 0) * XCO2bis * XN2bis * Math.Pow(ACO2 * AN2, 0.5) + 2 * (1 - 0) * XN2bis * XH2bis * Math.Pow(AN2 * AH2, 0.5) + Math.Pow(XCObis, 2) * ACO + 2 * (1 - 0) * XH2Obis * XCObis * Math.Pow(AH2O * ACO, 0.5) + 2 * (1 - 0) * XCObis * XH2bis * Math.Pow(ACO * AH2, 0.5) + 2 * (1 - 0) * XCObis * XN2bis * Math.Pow(ACO * AN2, 0.5) + 2 * (1 - 0) * XCObis * XCO2bis * Math.Pow(ACO * ACO2, 0.5) + grAsuite;
            GRB = XH2Obis * BH2O + XH2bis * BH2 + XCO2bis * BCO2 + XN2bis * BN2 + XCObis * BCO + XNH3bis * BNH3 + XCH4bis * BCH4 + XMGbis * BMG;
            //calculs des coefficients de fugacités   
            //logFIH2Osoave = ZN - 1 - Log(ZN - GRB) - GRA / GRB * Log((ZN + GRB) / ZN)
            //FIH2Oincsoave = 10 ^ (logFIH2Osoave / 2.303)
            //Worksheets(1).Range("C31").Value = FIH2Oincsoave
            logFIH2O = (BH2O / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2O / GRB - 2 / A * ArH2O) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2Oinc = Math.Pow(10, logFIH2O);
            FUH2Oinc = FIH2Oinc * P * XH2Obis;
            FUH2Oi = FUH2Oinc * 0.00001;
            logFIH2 = (BH2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BH2 / GRB - 2 / A * ArH2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIH2inc = Math.Pow(10, logFIH2);
            FUH2inc = FIH2inc * P * XH2bis;
            FUH2i = FUH2inc * 0.00001;
            logFICO = (BCO / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO / GRB - 2 / A * ArCO) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICOinc = Math.Pow(10, logFICO);
            FUCOinc = FICOinc * P * XCObis;
            FUCOi = FUCOinc * 0.00001;
            logFICO2 = (BCO2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCO2 / GRB - 2 / A * ArCO2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICO2inc = Math.Pow(10, logFICO2);
            FUCO2inc = FICO2inc * P * XCO2bis;
            FUCO2i = FUCO2inc * 0.00001; //la même chose mais en bar
            logFIN2 = (BN2 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BN2 / GRB - 2 / A * ArN2) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIN2inc = Math.Pow(10, logFIN2);
            FUN2inc = FIN2inc * P * XN2bis;
            FUN2i = FUN2inc * 0.00001;
            logFICH4 = (BCH4 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BCH4 / GRB - 2 / A * ArCH4) * Math.Log(1 + GRB / ZN)) / 2.303;
            FICH4inc = Math.Pow(10, logFICH4);
            FUCH4inc = FICH4inc * P * XCH4bis;
            FUCH4i = FUCH4inc * 0.00001;
            logFINH3 = (BNH3 / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BNH3 / GRB - 2 / A * ArNH3) * Math.Log(1 + GRB / ZN)) / 2.303;
            FINH3inc = Math.Pow(10, logFINH3);
            FUNH3inc = FINH3inc * P * XNH3bis;
            FUNH3i = FUNH3inc * 0.00001;
            logFIMG = (BMG / GRB * (ZN - 1) - Math.Log(ZN - GRB) + GRA / GRB * (BMG / GRB - 2 / A * ArMG) * Math.Log(1 + GRB / ZN)) / 2.303;
            FIMGinc = Math.Pow(10, logFIMG);
            FUMGinc = FIMGinc * P * XMGbis;
            FUMGi = FUMGinc * 0.00001;
            ///////////////////////////
            textBox96.Text = FUH2i.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogKr = Math.Log(1 / (Math.Pow(Double.Parse(textBox81.Text.ToString()), Double.Parse(textBox98.Text.ToString())) * Math.Pow(Double.Parse(textBox82.Text.ToString()), Double.Parse(textBox99.Text.ToString())) * Math.Pow(Double.Parse(textBox83.Text.ToString()), Double.Parse(textBox100.Text.ToString())) * Math.Pow(Double.Parse(textBox84.Text.ToString()), Double.Parse(textBox101.Text.ToString())) * Math.Pow(Double.Parse(textBox85.Text.ToString()), Double.Parse(textBox102.Text.ToString())) * Math.Pow(Double.Parse(textBox86.Text.ToString()), Double.Parse(textBox103.Text.ToString())) * Math.Pow(Double.Parse(textBox87.Text.ToString()), Double.Parse(textBox104.Text.ToString())) * Math.Pow(Double.Parse(textBox88.Text.ToString()), Double.Parse(textBox105.Text.ToString()))) * (Math.Pow(Double.Parse(textBox81.Text.ToString()), Double.Parse(textBox107.Text.ToString())) * Math.Pow(Double.Parse(textBox82.Text.ToString()), Double.Parse(textBox108.Text.ToString())) * Math.Pow(Double.Parse(textBox83.Text.ToString()), Double.Parse(textBox109.Text.ToString())) * Math.Pow(Double.Parse(textBox84.Text.ToString()), Double.Parse(textBox110.Text.ToString())) * Math.Pow(Double.Parse(textBox85.Text.ToString()), Double.Parse(textBox111.Text.ToString())) * Math.Pow(Double.Parse(textBox86.Text.ToString()), Double.Parse(textBox112.Text.ToString())) * Math.Pow(Double.Parse(textBox87.Text.ToString()), Double.Parse(textBox113.Text.ToString())) * Math.Pow(Double.Parse(textBox88.Text.ToString()), Double.Parse(textBox114.Text.ToString())))) / 2.303;
            LogKeq = Math.Log(1 / (Math.Pow(Double.Parse(textBox89.Text.ToString()), Double.Parse(textBox98.Text.ToString())) * Math.Pow(Double.Parse(textBox90.Text.ToString()), Double.Parse(textBox99.Text.ToString())) * Math.Pow(Double.Parse(textBox91.Text.ToString()), Double.Parse(textBox100.Text.ToString())) * Math.Pow(Double.Parse(textBox92.Text.ToString()), Double.Parse(textBox101.Text.ToString())) * Math.Pow(Double.Parse(textBox93.Text.ToString()), Double.Parse(textBox102.Text.ToString())) * Math.Pow(Double.Parse(textBox94.Text.ToString()), Double.Parse(textBox103.Text.ToString())) * Math.Pow(Double.Parse(textBox95.Text.ToString()), Double.Parse(textBox104.Text.ToString())) * Math.Pow(Double.Parse(textBox96.Text.ToString()), Double.Parse(textBox105.Text.ToString()))) * (Math.Pow(Double.Parse(textBox89.Text.ToString()), Double.Parse(textBox107.Text.ToString())) * Math.Pow(Double.Parse(textBox90.Text.ToString()), Double.Parse(textBox108.Text.ToString())) * Math.Pow(Double.Parse(textBox91.Text.ToString()), Double.Parse(textBox109.Text.ToString())) * Math.Pow(Double.Parse(textBox92.Text.ToString()), Double.Parse(textBox110.Text.ToString())) * Math.Pow(Double.Parse(textBox93.Text.ToString()), Double.Parse(textBox111.Text.ToString())) * Math.Pow(Double.Parse(textBox94.Text.ToString()), Double.Parse(textBox112.Text.ToString())) * Math.Pow(Double.Parse(textBox95.Text.ToString()), Double.Parse(textBox113.Text.ToString())) * Math.Pow(Double.Parse(textBox96.Text.ToString()), Double.Parse(textBox114.Text.ToString())))) / 2.303;
            LogKrLogkeq = LogKr - LogKeq;
            textBox116.Text = Math.Pow(10, LogKrLogkeq).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String charstore;
            System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                charstore = saveFileDialog1.FileName;
                System.IO.StreamWriter file = new System.IO.StreamWriter(charstore);
                file.WriteLine(textBox1.Text);
                file.WriteLine(textBox2.Text);
                file.WriteLine(textBox3.Text);
                file.WriteLine(textBox4.Text);
                file.WriteLine(textBox5.Text);
                file.WriteLine(textBox6.Text);
                file.WriteLine(textBox7.Text);
                file.WriteLine(textBox8.Text);
                file.WriteLine(textBox9.Text);
                file.WriteLine(textBox10.Text);
                file.WriteLine(textBox11.Text);
                file.WriteLine(textBox12.Text);
                file.WriteLine(textBox13.Text);
                file.WriteLine(textBox14.Text);
                file.WriteLine(textBox15.Text);
                file.WriteLine(textBox16.Text);
                file.WriteLine(textBox17.Text);
                file.WriteLine(textBox18.Text);
                file.WriteLine(textBox19.Text);
                file.WriteLine(textBox20.Text);
                file.WriteLine(textBox21.Text);
                file.WriteLine(textBox22.Text);
                file.WriteLine(textBox23.Text);
                file.WriteLine(textBox24.Text);
                file.WriteLine(textBox25.Text);
                file.WriteLine(textBox26.Text);
                file.WriteLine(textBox27.Text);
                file.WriteLine(textBox28.Text);
                file.WriteLine(textBox29.Text);
                file.WriteLine(textBox30.Text);
                file.WriteLine(textBox31.Text);
                file.WriteLine(textBox32.Text);
                file.WriteLine(textBox33.Text);
                file.WriteLine(textBox34.Text);
                file.WriteLine(textBox35.Text);
                file.WriteLine(textBox36.Text);
                file.WriteLine(textBox37.Text);
                file.WriteLine(textBox38.Text);
                file.WriteLine(textBox39.Text);
                file.WriteLine(textBox40.Text);
                file.WriteLine(textBox41.Text);
                file.WriteLine(textBox42.Text);
                file.WriteLine(textBox43.Text);
                file.WriteLine(textBox44.Text);
                file.WriteLine(textBox45.Text);
                file.WriteLine(textBox46.Text);
                file.WriteLine(textBox47.Text);
                file.WriteLine(textBox48.Text);
                file.WriteLine(textBox49.Text);
                file.WriteLine(textBox50.Text);
                file.WriteLine(textBox51.Text);
                file.WriteLine(textBox52.Text);
                file.WriteLine(textBox53.Text);
                file.WriteLine(textBox54.Text);
                file.WriteLine(textBox55.Text);
                file.WriteLine(textBox56.Text);
                file.WriteLine(textBox57.Text);
                file.WriteLine(textBox58.Text);
                file.WriteLine(textBox59.Text);
                file.WriteLine(textBox60.Text);
                file.WriteLine(textBox61.Text);
                file.WriteLine(textBox62.Text);
                file.WriteLine(textBox63.Text);
                file.WriteLine(textBox64.Text);
                file.WriteLine(textBox65.Text);
                file.WriteLine(textBox66.Text);
                file.WriteLine(textBox67.Text);
                file.WriteLine(textBox68.Text);
                file.WriteLine(textBox69.Text);
                file.WriteLine(textBox70.Text);
                file.WriteLine(textBox71.Text);
                file.WriteLine(textBox72.Text);
                file.WriteLine(textBox73.Text);
                file.WriteLine(textBox74.Text);
                file.WriteLine(textBox75.Text);
                file.WriteLine(textBox76.Text);
                file.WriteLine(textBox77.Text);
                file.WriteLine(textBox78.Text);
                file.WriteLine(textBox79.Text);
                file.WriteLine(textBox80.Text);
                file.WriteLine(textBox81.Text);
                file.WriteLine(textBox82.Text);
                file.WriteLine(textBox83.Text);
                file.WriteLine(textBox84.Text);
                file.WriteLine(textBox85.Text);
                file.WriteLine(textBox86.Text);
                file.WriteLine(textBox87.Text);
                file.WriteLine(textBox88.Text);
                file.WriteLine(textBox89.Text);
                file.WriteLine(textBox90.Text);
                file.WriteLine(textBox91.Text);
                file.WriteLine(textBox92.Text);
                file.WriteLine(textBox93.Text);
                file.WriteLine(textBox94.Text);
                file.WriteLine(textBox95.Text);
                file.WriteLine(textBox96.Text);
                file.WriteLine(textBox97.Text);
                file.WriteLine(textBox98.Text);
                file.WriteLine(textBox99.Text);
                file.WriteLine(textBox100.Text);
                file.WriteLine(textBox101.Text);
                file.WriteLine(textBox102.Text);
                file.WriteLine(textBox103.Text);
                file.WriteLine(textBox104.Text);
                file.WriteLine(textBox105.Text);
                file.WriteLine(textBox106.Text);
                file.WriteLine(textBox107.Text);
                file.WriteLine(textBox108.Text);
                file.WriteLine(textBox109.Text);
                file.WriteLine(textBox110.Text);
                file.WriteLine(textBox111.Text);
                file.WriteLine(textBox112.Text);
                file.WriteLine(textBox113.Text);
                file.WriteLine(textBox114.Text);
                file.WriteLine(textBox115.Text);
                file.WriteLine(textBox116.Text);
                file.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String myRead;
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                myRead = openFileDialog1.FileName;
                System.IO.StreamReader file = new System.IO.StreamReader(myRead);
                textBox1.Text = file.ReadLine();
                textBox2.Text = file.ReadLine();
                textBox3.Text = file.ReadLine();
                textBox4.Text = file.ReadLine();
                textBox5.Text = file.ReadLine();
                textBox6.Text = file.ReadLine();
                textBox7.Text = file.ReadLine();
                textBox8.Text = file.ReadLine();
                textBox9.Text = file.ReadLine();
                textBox10.Text = file.ReadLine();
                textBox11.Text = file.ReadLine();
                textBox12.Text = file.ReadLine();
                textBox13.Text = file.ReadLine();
                textBox14.Text = file.ReadLine();
                textBox15.Text = file.ReadLine();
                textBox16.Text = file.ReadLine();
                textBox17.Text = file.ReadLine();
                textBox18.Text = file.ReadLine();
                textBox19.Text = file.ReadLine();
                textBox20.Text = file.ReadLine();
                textBox21.Text = file.ReadLine();
                textBox22.Text = file.ReadLine();
                textBox23.Text = file.ReadLine();
                textBox24.Text = file.ReadLine();
                textBox25.Text = file.ReadLine();
                textBox26.Text = file.ReadLine();
                textBox27.Text = file.ReadLine();
                textBox28.Text = file.ReadLine();
                textBox29.Text = file.ReadLine();
                textBox30.Text = file.ReadLine();
                textBox31.Text = file.ReadLine();
                textBox32.Text = file.ReadLine();
                textBox33.Text = file.ReadLine();
                textBox34.Text = file.ReadLine();
                textBox35.Text = file.ReadLine();
                textBox36.Text = file.ReadLine();
                textBox37.Text = file.ReadLine();
                textBox38.Text = file.ReadLine();
                textBox39.Text = file.ReadLine();
                textBox40.Text = file.ReadLine();
                textBox41.Text = file.ReadLine();
                textBox42.Text = file.ReadLine();
                textBox43.Text = file.ReadLine();
                textBox44.Text = file.ReadLine();
                textBox45.Text = file.ReadLine();
                textBox46.Text = file.ReadLine();
                textBox47.Text = file.ReadLine();
                textBox48.Text = file.ReadLine();
                textBox49.Text = file.ReadLine();
                textBox50.Text = file.ReadLine();
                textBox51.Text = file.ReadLine();
                textBox52.Text = file.ReadLine();
                textBox53.Text = file.ReadLine();
                textBox54.Text = file.ReadLine();
                textBox55.Text = file.ReadLine();
                textBox56.Text = file.ReadLine();
                textBox57.Text = file.ReadLine();
                textBox58.Text = file.ReadLine();
                textBox59.Text = file.ReadLine();
                textBox60.Text = file.ReadLine();
                textBox61.Text = file.ReadLine();
                textBox62.Text = file.ReadLine();
                textBox63.Text = file.ReadLine();
                textBox64.Text = file.ReadLine();
                textBox65.Text = file.ReadLine();
                textBox66.Text = file.ReadLine();
                textBox67.Text = file.ReadLine();
                textBox68.Text = file.ReadLine();
                textBox69.Text = file.ReadLine();
                textBox70.Text = file.ReadLine();
                textBox71.Text = file.ReadLine();
                textBox72.Text = file.ReadLine();
                textBox73.Text = file.ReadLine();
                textBox74.Text = file.ReadLine();
                textBox75.Text = file.ReadLine();
                textBox76.Text = file.ReadLine();
                textBox77.Text = file.ReadLine();
                textBox78.Text = file.ReadLine();
                textBox79.Text = file.ReadLine();
                textBox80.Text = file.ReadLine();
                textBox81.Text = file.ReadLine();
                textBox82.Text = file.ReadLine();
                textBox83.Text = file.ReadLine();
                textBox84.Text = file.ReadLine();
                textBox85.Text = file.ReadLine();
                textBox86.Text = file.ReadLine();
                textBox87.Text = file.ReadLine();
                textBox88.Text = file.ReadLine();
                textBox89.Text = file.ReadLine();
                textBox90.Text = file.ReadLine();
                textBox91.Text = file.ReadLine();
                textBox92.Text = file.ReadLine();
                textBox93.Text = file.ReadLine();
                textBox94.Text = file.ReadLine();
                textBox95.Text = file.ReadLine();
                textBox96.Text = file.ReadLine();
                textBox97.Text = file.ReadLine();
                textBox98.Text = file.ReadLine();
                textBox99.Text = file.ReadLine();
                textBox100.Text = file.ReadLine();
                textBox101.Text = file.ReadLine();
                textBox102.Text = file.ReadLine();
                textBox103.Text = file.ReadLine();
                textBox104.Text = file.ReadLine();
                textBox105.Text = file.ReadLine();
                textBox106.Text = file.ReadLine();
                textBox107.Text = file.ReadLine();
                textBox108.Text = file.ReadLine();
                textBox109.Text = file.ReadLine();
                textBox110.Text = file.ReadLine();
                textBox111.Text = file.ReadLine();
                textBox112.Text = file.ReadLine();
                textBox113.Text = file.ReadLine();
                textBox114.Text = file.ReadLine();
                textBox115.Text = file.ReadLine();
                textBox116.Text = file.ReadLine();
                file.Close();
            }
        }
    }
}
