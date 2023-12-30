using System.Globalization;

namespace tictactroll.Converters
{
    public sealed class ValeurDeCaseAImageConverter : IValueConverter
	{
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is ValeursPossible valeurDeLaCase)
            {
                return valeurDeLaCase switch
                {
                    ValeursPossible.X => new FileImageSource { File = "x_de_noel.png"},
                    ValeursPossible.O => new FileImageSource { File = "o_de_noel.png"},
                    _ => null
                };
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

