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
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="msoLegendKey">The `MsoLegendKey` parameter.</param>
  /// <param name="autoText">The `AutoText` parameter.</param>
  /// <param name="hasLeaderLines">The `HasLeaderLines` parameter.</param>
  /// <param name="showSeriesName">The `ShowSeriesName` parameter.</param>
  /// <param name="showCategoryName">The `ShowCategoryName` parameter.</param>
  /// <param name="showValue">The `ShowValue` parameter.</param>
  /// <param name="showPercentage">The `ShowPercentage` parameter.</param>
  /// <param name="showBubbleSize">The `ShowBubbleSize` parameter.</param>
  /// <param name="separator">The `Separator` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.applydatalabels?view=office-pia"/>
  public object ApplyDataLabels(DataLabelsType type, object msoLegendKey, object autoText, object hasLeaderLines, object showSeriesName, object showCategoryName, object showValue, object showPercentage,  object showBubbleSize, object separator) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PieSliceLocation`.
  /// </summary>
  /// <param name="loc">The `loc` parameter.</param>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartpoint.pieslicelocation?view=office-pia"/>
  public double PieSliceLocation(PieSliceLocation loc, PieSliceIndex index) { throw new NotImplementedException(); }

  #endregion methods
}

