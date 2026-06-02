namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single point in a chart series.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint?view=office-pia"/>
public partial class ChartPoint
{


  #region methods

/// <summary>
  /// Invokes `_ApplyDataLabels`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="MsoLegendKey">The `MsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint._applydatalabels?view=office-pia"/>
  public object _ApplyDataLabels
  (DataLabelsType Type, object MsoLegendKey, object AutoText,
    object HasLeaderLines) { throw new NotImplementedException(); }
  /// <summary>
  /// Clears formatting from the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.clearformats?view=office-pia"/>
  public object ClearFormats() { throw new NotImplementedException(); }
  /// <summary>
  /// Copies the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.copy?view=office-pia"/>
  public object Copy() { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.delete?view=office-pia"/>
  public object Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Pastes clipboard contents to the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.paste?view=office-pia"/>
  public object Paste() { throw new NotImplementedException(); }
  /// <summary>
  /// Selects the chart point.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.select?view=office-pia"/>
  public object Select() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ApplyDataLabels`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="MsoLegendKey">The `MsoLegendKey` parameter.</param>
  /// <param name="AutoText">The `AutoText` parameter.</param>
  /// <param name="HasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <param name="ShowSeriesName">The `ShowSeriesName` parameter.</param>
  /// <param name="ShowCategoryName">The `ShowCategoryName` parameter.</param>
  /// <param name="ShowValue">The `ShowValue` parameter.</param>
  /// <param name="ShowPercentage">The `ShowPercentage` parameter.</param>
  /// <param name="ShowBubbleSize">The `ShowBubbleSize` parameter.</param>
  /// <param name="Separator">The `Separator` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.applydatalabels?view=office-pia"/>
  public object ApplyDataLabels(DataLabelsType Type, object MsoLegendKey, object AutoText, object HasLeaderLines, object ShowSeriesName, object ShowCategoryName, object ShowValue, object ShowPercentage,  object ShowBubbleSize, object Separator) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PieSliceLocation`.
  /// </summary>
  /// <param name="loc">The `loc` parameter.</param>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.pieslicelocation?view=office-pia"/>
  public double PieSliceLocation(PieSliceLocation loc, PieSliceIndex Index) { throw new NotImplementedException(); }

  #endregion methods
}

