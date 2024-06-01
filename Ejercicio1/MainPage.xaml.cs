namespace Ejercicio1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(Uno.Text);
            double N2 = Convert.ToDouble(Dos.Text);
            double N3 = Convert.ToDouble(Tres.Text);
            double N4 = Convert.ToDouble(Cuatro.Text);

            // Intercambiar los valores directamente
            N1 = N1 + N4 - (N4 = N1);
            N2 = N2 + N3 - (N3 = N2);

            // Mostrar el orden invertido en el entry
            Result.Text = $"Invertido: {N1}, {N2}, {N3}, {N4}";
        }
    }

}
