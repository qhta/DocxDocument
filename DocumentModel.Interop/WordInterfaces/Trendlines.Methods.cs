namespace DocumentModel.Interop.Word;

public partial interface Trendlines
{
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
  public Trendline Add(XlTrendlineType Type, object Order, int Period, int Forward, int Backward, 
    object Intercept, bool DisplayEquation, bool DisplayRSquared, string Name);
}
