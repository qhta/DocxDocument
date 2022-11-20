namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public interface IMarkerLayoutProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public MarkerStyle? Symbol { get ; set; }
  
  /// <summary>
  /// size, this property is only available in Office 2013 and later.
  /// </summary>
  public byte? Size { get ; set; }
  
}
