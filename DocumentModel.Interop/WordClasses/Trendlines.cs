namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the Trendline objects for the specified series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendlines?view=word-pia"/>
public partial class Trendlines : InteropCollection<Trendline>
{


  #region methods

/// <summary>
  /// Adds a new trendline to the collection.
  /// </summary>
  /// <param name="Type">The type of trendline to add.</param>
  /// <param name="Order">The order of the polynomial trendline (if applicable).</param>
  /// <param name="Period">The period for the moving average trendline (if applicable).</param>
  /// <param name="Forward">The number of periods the trendline extends forward.</param>
  /// <param name="Backward">The number of periods the trendline extends backward.</param>
  /// <param name="Intercept">The intercept value for the trendline.</param>
  /// <param name="DisplayEquation">true to display the trendline equation on the chart; otherwise, false.</param>
  /// <param name="DisplayRSquared">true to display the R-squared value on the chart; otherwise, false.</param>
  /// <param name="Name">The name of the trendline.</param>
  /// <returns>The created <see cref="Trendline"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendlines.add?view=word-pia"/>
  public Trendline Add(TrendlineType Type, object Order, int Period, int Forward, int Backward, 
    object Intercept, bool DisplayEquation, bool DisplayRSquared, string Name)
  {
    throw new NotImplementedException();
  }

  #endregion methods
}
