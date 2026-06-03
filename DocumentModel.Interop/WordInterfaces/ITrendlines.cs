namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the Trendline objects for the specified series.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendlines?view=word-pia"/>
public interface ITrendlines : IInteropObject, IInteropCollection<ITrendline>
{


  #region methods

/// <summary>
  /// Adds a new trendline to the collection.
  /// </summary>
  /// <param name="type">The type of trendline to add.</param>
  /// <param name="order">The order of the polynomial trendline (if applicable).</param>
  /// <param name="period">The period for the moving average trendline (if applicable).</param>
  /// <param name="forward">The number of periods the trendline extends forward.</param>
  /// <param name="backward">The number of periods the trendline extends backward.</param>
  /// <param name="intercept">The intercept value for the trendline.</param>
  /// <param name="displayEquation">true to display the trendline equation on the chart; otherwise, false.</param>
  /// <param name="displayRSquared">true to display the R-squared value on the chart; otherwise, false.</param>
  /// <param name="name">The name of the trendline.</param>
  /// <returns>The created <see cref="ITrendline"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.trendlines.add?view=word-pia"/>
  public ITrendline Add(TrendlineType type, object order, int period, int forward, int backward, 
    object intercept, bool displayEquation, bool displayRSquared, string name);

  #endregion methods
}
