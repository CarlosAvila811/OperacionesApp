using Microsoft.Maui.Controls;
using System;

namespace OperacionesApp
{
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private void OnCalculateSquareArea(object sender, EventArgs e)
        {
            if (double.TryParse(SideEntry.Text, out double side))
            {
                double area = side * side;
                SquareAreaResult.Text = $"Área: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor válido para el lado.", "OK");
            }
        }

        private void OnCalculateCircleArea(object sender, EventArgs e)
        {
            if (double.TryParse(RadiusEntry.Text, out double radius))
            {
                double area = Math.PI * radius * radius;
                CircleAreaResult.Text = $"Área: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa un valor válido para el radio.", "OK");
            }
        }

        private void OnCalculateRectangleArea(object sender, EventArgs e)
        {
            if (double.TryParse(WidthEntry.Text, out double width) &&
                double.TryParse(HeightEntry.Text, out double height))
            {
                double area = width * height;
                RectangleAreaResult.Text = $"Área: {area}";
            }
            else
            {
                DisplayAlert("Error", "Por favor ingresa valores válidos para el ancho y la altura.", "OK");
            }
        }

        private void OnClearFields(object sender, EventArgs e)
        {
            SideEntry.Text = "";
            RadiusEntry.Text = "";
            WidthEntry.Text = "";
            HeightEntry.Text = "";
            SquareAreaResult.Text = "Resultado:";
            CircleAreaResult.Text = "Resultado:";
            RectangleAreaResult.Text = "Resultado:";
        }
    }
}
