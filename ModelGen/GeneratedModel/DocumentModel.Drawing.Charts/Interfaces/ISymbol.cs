namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Symbol.
/// </summary>
public interface ISymbol // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Marker Style Value
  /// </summary>
  public MarkerStyle? Val { get ; set; }
  
}
