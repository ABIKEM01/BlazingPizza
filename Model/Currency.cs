using System.Globalization;

namespace BlazingPizza;

/// <summary>
/// One place that decides how prices are shown across the app.
/// en-NG formats as Nigerian naira, e.g. "₦12.75".
/// </summary>
public static class Currency
{
    public static readonly CultureInfo Culture = CultureInfo.GetCultureInfo("en-NG");

    public static string Format(decimal amount) => amount.ToString("C", Culture);
}