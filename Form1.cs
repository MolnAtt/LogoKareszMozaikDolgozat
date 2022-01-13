using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void Odatölt(double f, double d, Color szín)
		{
			using (new Rajzol(false))
			using (new Átmenetileg(Jobbra, f))
			using (new Átmenetileg(Előre, d))
				Tölt(szín);
		}
		void Lopva_előre(double m)
		{
			using (new Rajzol(false))
				Előre(m);
		}
		void EJ(double d, double f) 
		{ 
			Előre(d); 
			Jobbra(f); 
		}

        #region Hermann-rács
		/// <summary>
		/// lerajzol egy méret oldalhosszúságú fekete négyzetet
		/// </summary>
		/// <param name="méret">a négyzet oldalhossza</param>
        void Fekete_négyzet(double méret)
		{

		}
		/// <summary>
		/// Letesz megadott számú fekete négyzetet egymás mellé
		/// </summary>
		/// <param name="db">ennyi négyzetet tesz le egymás mellé</param>
		void Hermann_sor(int db, double d)
		{

		}
		/// <summary>
		/// Elkészít egy N sorból és M oszlopból álló fekete négyzetrácsot.
		/// </summary>
		/// <param name="N">sorok száma</param>
		/// <param name="M">oszlopok száma</param>
		/// <param name="méret">méret</param>
		void Hermann_rács(int N, int M, double méret)
		{
			
		}
        #endregion

        #region sávos mozaik


		/// <summary>
		/// Lerajzol egy m oldalhosszúságú fehér négyzetelemet, amelyben két fekete háromszög van a bal alsó és jobb felső sarokban.
		/// </summary>
		/// <param name="m">a négyzet oldalhossza</param>
		void Sávos_fehér_négyzet(double m)
		{

		}
		/// <summary>
		/// Lerajzol egy d befogójú, c színű egyenlő szárú derékszögű háromszöget a derékszögéből kezdve.
		/// </summary>
		/// <param name="d">a befogó hossza</param>
		/// <param name="c">a háromszög színe</param>
		void Félnégyzet(double d, Color c)
		{
			using (new Szín(c))
			{
				EJ(d, 135);
				EJ(d * Math.Sqrt(2), 135);
				EJ(d, 90);
				Odatölt(45, d / 3, c);
			}
		}
		/// <summary>
		/// Lerajzol egy m oldalhosszúságú fekete négyzetelemet, amelyben két fehér háromszög van a bal alsó és a jobb felső sarokban.
		/// </summary>
		/// <param name="m">a négyzet oldalhossza</param>
		void Sávos_fekete_négyzet(double m)
		{

		}
		/// <summary>
		/// Lerajzol egy db darabból álló váltakozó, felváltva fehér és fekete elemekből álló sort a sávos mozaikból. A b változó határozza meg azt, hogy milyen színnel kezd.
		/// </summary>
		/// <param name="db">hány darab elemből áll a sor</param>
		/// <param name="m">mekkora az elemek mérete</param>
		/// <param name="b">Fekete négyzettel kezdődik-e a sor</param>
		void Sávos_sor(int db, double m, bool b)
		{

		}
		/// <summary>
		/// Lerajzol egy N db sorból és M db oszlopból álló sávos mozaikot.
		/// </summary>
		/// <param name="N">sorok száma</param>
		/// <param name="M">oszlopok száma</param>
		/// <param name="m">alapelemek oldalhossza</param>
		void Sávos_mozaik(int N, int M, double m)
		{

		}
		#endregion 

        #region Kávébab-illúzió
		/// <summary>
		/// lerajzol egy x szélességű és y magasságú sz színű téglalapot, amire a kávébabokat teszi majd.
		/// </summary>
		/// <param name="x">szélesség</param>
		/// <param name="y">magasság</param>
		/// <param name="sz">szín</param>
        void Háttér(double x, double y, Color sz)
		{

		}
		/// <summary>
		/// ez egy kitöltetlen félbab alak, amit a megadott színnel rajzol le.
		/// </summary>
		/// <param name="d">méret</param>
		/// <param name="szín">szín</param>
		void Félbab(double d, Color szín)
		{
			Tollvastagság(2);
            using (new Szín(szín))
            {
				Balra(45);
				EJ(d, 45);
				EJ(d, 45);
				EJ(d, 135);
            }
		}
		/// <summary>
		/// Ez egy kitöltött félbab, amit a megadott forgásszögben rajzol le középről.
		/// </summary>
		/// <param name="f">forgásszög</param>
		/// <param name="d">méret</param>
		void Kávébab(double f, double d)
		{
			double ennyit = d *(1+Math.Sqrt(2))/2;
            using (new Átmenetileg(Jobbra, f))
            {
				Lopva_előre(-ennyit);			
				Félbab(d, Color.Black);
				Félbab(d, Color.White);
				Odatölt(0, d, Color.Brown);
				Lopva_előre(ennyit);
            }
		}
		/// <summary>
		/// Létrehoz egy N db sorból és M db oszlopból álló kávébab-illúziót
		/// </summary>
		/// <param name="N">sorok száma</param>
		/// <param name="M">oszlopok száma</param>
		/// <param name="m">babok mérete</param>
		void Kávébab_illúzió(int N, int M, double m)
		{

		}
		#endregion

		void FELADAT()
		{
			//Teleport(20, 400, észak);
		}
	}
}
