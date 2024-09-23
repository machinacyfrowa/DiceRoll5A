namespace DiceRoll5A
{
    public partial class MainPage : ContentPage
    {
        int score = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void RollDice(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] dice = new int[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = r.Next(1, 7);
            }
            //wynik rzutu
            int rollScore = 0;
            for(int i = 1; i<=6; i++)
            { 
                //ilosc powtorzen danej ilosc oczek (i)
                int count = 0;
                //przeglądamy rzuty kostką
                for (int j = 0; j < dice.Length; j++)
                {
                    //jeśli się zgadza z szukaną
                    if (dice[j] == i)
                    {
                        //dodaj do ilości rzutów danej wartości
                        count++;
                    }
                }
                //mamy policzoną ilość 1 albo 2 albo 3...6
                //dodajemy do wyniku ilość wyrzuconych kośći
                //o danej ilości oczek
                if (count > 1)
                {
                    rollScore += count * i;
                }
                
            }
            //pokaż wynik na kostkach
            Dice0.Source = "k6_" + dice[0] + ".png";
            Dice1.Source = "k6_" + dice[1] + ".png";
            Dice2.Source = "k6_" + dice[2] + ".png";
            Dice3.Source = "k6_" + dice[3] + ".png";
            Dice4.Source = "k6_" + dice[4] + ".png";

            //wynik rzutu
            RollScoreLabel.Text = "Wynik tego losowania: " + rollScore;
            //wynik gry
            score += rollScore;
            ScoreLabel.Text = "Wynik gry: " + score;
        }

        private void ResetScore(object sender, EventArgs e)
        {
            score = 0;
            ScoreLabel.Text = "Wynik gry: " + score;
        }
    }

}
