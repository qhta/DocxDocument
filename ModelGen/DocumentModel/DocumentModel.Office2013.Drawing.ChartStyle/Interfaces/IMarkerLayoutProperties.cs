namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public interface IMarkerLayoutProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.MarkerStyle? Symbol { get ; set; }
  
  /// <summary>
  /// size, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Byte? Size { get ; set; }
  
}
