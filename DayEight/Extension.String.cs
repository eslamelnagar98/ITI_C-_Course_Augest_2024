using System.Globalization;
using System.Numerics;
namespace DayEight;
public static partial class Extension
{
    public delegate bool TryParse<T>(string value, out T number) where T : INumber<T>;

    public static TNumber ToNumber<TNumber>(this string value, TryParse<TNumber> parse)
        where TNumber : struct, INumber<TNumber>
    {
        if (string.IsNullOrWhiteSpace(value)) return default;   

        TNumber.TryParse(value, CultureInfo.InvariantCulture, out var number);

        return number;
    }

    public static T GetSafeValue<T>(this T? value, T defaultValue = default)
       where T : struct
    {
        return value.GetValueOrDefault(defaultValue);
    }
}
