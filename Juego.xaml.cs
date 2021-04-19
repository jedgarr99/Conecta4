using Connect4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Conecta4 {
    /// <summary>
    /// Lógica de interacción para Juego.xaml
    /// </summary>
    public partial class Juego : Window {
        Boolean turnoRojas;
        int[,] ocupados;
        Rectangle[,] fichasRojas;
        Rectangle[,] fichasAmarillas;
        Game game;

        public Juego() {
            InitializeComponent();
            game = new Game();
           
            ocupados = new int[6, 7]; ///rojas 1 amarillo 2
            fichasRojas = new Rectangle[6, 7];
            fichasAmarillas = new Rectangle[6, 7];
            turnoRojas = true;

            fichasRojas[0, 0] = FR00;
            fichasRojas[0, 1] = FR10;
            fichasRojas[0, 2] = FR20;
            fichasRojas[0, 3] = FR30;
            fichasRojas[0, 4] = FR40;
            fichasRojas[0, 5] = FR50;
            fichasRojas[1, 0] = FR01;
            fichasRojas[1, 1] = FR11;
            fichasRojas[1, 2] = FR21;
            fichasRojas[1, 3] = FR31;
            fichasRojas[1, 4] = FR41;
            fichasRojas[1, 5] = FR51;
            fichasRojas[2, 0] = FR02;
            fichasRojas[2, 1] = FR12;
            fichasRojas[2, 2] = FR22;
            fichasRojas[2, 3] = FR32;
            fichasRojas[2, 4] = FR42;
            fichasRojas[2, 5] = FR52;
            fichasRojas[3, 0] = FR03;
            fichasRojas[3, 1] = FR13;
            fichasRojas[3, 2] = FR23;
            fichasRojas[3, 3] = FR33;
            fichasRojas[3, 4] = FR43;
            fichasRojas[3, 5] = FR53;
            fichasRojas[4, 0] = FR04;
            fichasRojas[4, 1] = FR14;
            fichasRojas[4, 2] = FR24;
            fichasRojas[4, 3] = FR34;
            fichasRojas[4, 4] = FR44;
            fichasRojas[4, 5] = FR54;
            fichasRojas[5, 0] = FR05;
            fichasRojas[5, 1] = FR15;
            fichasRojas[5, 2] = FR25;
            fichasRojas[5, 3] = FR35;
            fichasRojas[5, 4] = FR45;
            fichasRojas[5, 5] = FR55;
            fichasRojas[0, 6] = FR60;
            fichasRojas[1, 6] = FR61;
            fichasRojas[2, 6] = FR62;
            fichasRojas[3, 6] = FR63;
            fichasRojas[4, 6] = FR64;
            fichasRojas[5, 6] = FR65;

            fichasAmarillas[0, 0] = FA00;
            fichasAmarillas[0, 1] = FA10;
            fichasAmarillas[0, 2] = FA20;
            fichasAmarillas[0, 3] = FA30;
            fichasAmarillas[0, 4] = FA40;
            fichasAmarillas[0, 5] = FA50;
            fichasAmarillas[1, 0] = FA01;
            fichasAmarillas[1, 1] = FA11;
            fichasAmarillas[1, 2] = FA21;
            fichasAmarillas[1, 3] = FA31;
            fichasAmarillas[1, 4] = FA41;
            fichasAmarillas[1, 5] = FA51;
            fichasAmarillas[2, 0] = FA02;
            fichasAmarillas[2, 1] = FA12;
            fichasAmarillas[2, 2] = FA22;
            fichasAmarillas[2, 3] = FA32;
            fichasAmarillas[2, 4] = FA42;
            fichasAmarillas[2, 5] = FA52;
            fichasAmarillas[3, 0] = FA03;
            fichasAmarillas[3, 1] = FA13;
            fichasAmarillas[3, 2] = FA23;
            fichasAmarillas[3, 3] = FA33;
            fichasAmarillas[3, 4] = FA43;
            fichasAmarillas[3, 5] = FA53;
            fichasAmarillas[4, 0] = FA04;
            fichasAmarillas[4, 1] = FA14;
            fichasAmarillas[4, 2] = FA24;
            fichasAmarillas[4, 3] = FA34;
            fichasAmarillas[4, 4] = FA44;
            fichasAmarillas[4, 5] = FA54;
            fichasAmarillas[5, 0] = FA05;
            fichasAmarillas[5, 1] = FA15;
            fichasAmarillas[5, 2] = FA25;
            fichasAmarillas[5, 3] = FA35;
            fichasAmarillas[5, 4] = FA45;
            fichasAmarillas[5, 5] = FA55;
            fichasAmarillas[0, 6] = FA60;
            fichasAmarillas[1, 6] = FA61;
            fichasAmarillas[2, 6] = FA62;
            fichasAmarillas[3, 6] = FA63;
            fichasAmarillas[4, 6] = FA64;
            fichasAmarillas[5, 6] = FA65;
        

           


            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 7; j++) {
                    fichasAmarillas[i, j].Opacity = 0;
                }
            }

            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 7; j++) {
                    fichasRojas[i, j].Opacity = 0;
                }
            }


        }

        


        private void insertaFicha(int columna) {
            int i = 5;



            if (ocupados[0, columna] == 0) {
                i = 0;
            }
            else {

                while (ocupados[i, columna] == 0) {
                    i = i - 1;
                }
                i = i + 1;
            }

            if (i < 6) {
                
                    fichasRojas[i, columna].Opacity = 100;
                    ocupados[i, columna] = 1;
                    turnoRojas = false;

            }
        }

        private void insertaFichaCompu(int columna) {
            int i = 5;



            if (ocupados[0, columna] == 0) {
                i = 0;
            }
            else {

                while (ocupados[i, columna] == 0) {
                    i = i - 1;
                }
                i = i + 1;
            }

            if (i < 6) {

                fichasAmarillas[i, columna].Opacity = 100;
                ocupados[i, columna] = 2;
                turnoRojas = false;

            }
        }
        private void bt1_Click(object sender, RoutedEventArgs e) {
            int pos;
            actualizaOcupados();
            if (game.playerMove(0)) {
                insertaFicha(0);
                
            game.printBoard(game.board); // DEBUGGING

            int winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
            
            insertaFichaCompu(game.computerMove());
            game.printBoard(game.board); // DEBUGGING

            winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;

            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
        }

        }

        private void bt2_Click(object sender, RoutedEventArgs e) {
            actualizaOcupados();


            if (game.playerMove(1)) {
                insertaFicha(1);
                
                game.printBoard(game.board); // DEBUGGING

            int winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
                insertaFichaCompu(game.computerMove());
                game.printBoard(game.board); // DEBUGGING

            winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;

            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
        }
        }

        private void bt3_Click(object sender, RoutedEventArgs e) {
            actualizaOcupados();
            if (game.playerMove(2)) {
                insertaFicha(2);
            game.printBoard(game.board); // DEBUGGING

            int winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
                insertaFichaCompu(game.computerMove());
                game.printBoard(game.board); // DEBUGGING

            winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;

            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
        }
        }

        private void bt4_Click(object sender, RoutedEventArgs e) {
            actualizaOcupados();
            if (game.playerMove(3)) {
                insertaFicha(3);
            game.printBoard(game.board); // DEBUGGING

            int winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
                insertaFichaCompu(game.computerMove());
                game.printBoard(game.board); // DEBUGGING

            winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;

            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
        }
        }

        private void bt5_Click(object sender, RoutedEventArgs e) {
            actualizaOcupados();
            if (game.playerMove(4)) {
                insertaFicha(4);
                game.printBoard(game.board); // DEBUGGING

                int winner = game.checkWinner();
                if (winner == Game.PLAYER) {

                    MessageBox.Show("Player wins!", "Winner!");
                    Close();
                    return;
                }
                else if (winner == Game.COMPUTER) {

                    MessageBox.Show("Computer wins!", "Winner!");
                    Close();
                    return;
                }
                else if (winner == Game.DRAW) {

                    MessageBox.Show("The board is full!", "Full!");
                    Close();
                    return;
                }
                insertaFichaCompu(game.computerMove());
                game.printBoard(game.board); // DEBUGGING

                winner = game.checkWinner();
                if (winner == Game.PLAYER) {

                    MessageBox.Show("Player wins!", "Winner!");
                    Close();
                    return;
                }
                else if (winner == Game.COMPUTER) {

                    MessageBox.Show("Computer wins!", "Winner!");
                    Close();
                    return;

                }
                else if (winner == Game.DRAW) {

                    MessageBox.Show("The board is full!", "Full!");
                    Close();
                    return;
                }
            }
        }

        private void bt6_Click(object sender, RoutedEventArgs e) {
            actualizaOcupados();
            if (game.playerMove(5)) {
                insertaFicha(5);
            
            game.printBoard(game.board); // DEBUGGING

            int winner = game.checkWinner();
            if (winner == Game.PLAYER) {

                MessageBox.Show("Player wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.COMPUTER) {

                MessageBox.Show("Computer wins!", "Winner!");
                Close();
                return;
            }
            else if (winner == Game.DRAW) {

                MessageBox.Show("The board is full!", "Full!");
                Close();
                return;
            }
                insertaFichaCompu(game.computerMove());
                game.printBoard(game.board); // DEBUGGING

            winner = game.checkWinner();
                if (winner == Game.PLAYER) {

                    MessageBox.Show("Player wins!", "Winner!");
                    Close();
                    return;
                }
                else if (winner == Game.COMPUTER) {

                    MessageBox.Show("Computer wins!", "Winner!");
                    Close();
                    return;

                }
                else if (winner == Game.DRAW) {

                    MessageBox.Show("The board is full!", "Full!");
                    Close();
                    return;
                }
            }
        }

        private void bt7_Click(object sender, RoutedEventArgs e) {
            actualizaOcupados();
            if (game.playerMove(6)) {
                insertaFicha(6);
                game.printBoard(game.board); // DEBUGGING

                int winner = game.checkWinner();
                if (winner == Game.PLAYER) {

                    MessageBox.Show("Player wins!", "Winner!");
                    Close();
                    return;
                }
                else if (winner == Game.COMPUTER) {

                    MessageBox.Show("Computer wins!", "Winner!");
                    Close();
                    return;
                }
                else if (winner == Game.DRAW) {

                    MessageBox.Show("The board is full!", "Full!");
                    Close();
                    return;
                }
                insertaFichaCompu(game.computerMove());
                game.printBoard(game.board); // DEBUGGING

                winner = game.checkWinner();
                if (winner == Game.PLAYER) {

                    MessageBox.Show("Player wins!", "Winner!");
                    Close();
                    return;
                }
                else if (winner == Game.COMPUTER) {

                    MessageBox.Show("Computer wins!", "Winner!");
                    Close();
                    return;

                }
                else if (winner == Game.DRAW) {

                    MessageBox.Show("The board is full!", "Full!");
                    Close();
                    return;
                }
            }
        }

        private void actualizaOcupados() {
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 7; j++) {
                    ocupados[i, j] = game.board[5 - i, j];
                }
            }
        }
    }
}
