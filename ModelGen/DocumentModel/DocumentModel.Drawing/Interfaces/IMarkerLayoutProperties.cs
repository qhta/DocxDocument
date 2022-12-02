namespace DocumentModel.Drawing;

/// <summary>
/// Defines the MarkerLayoutProperties Class.
/// </summary>
public interface IMarkerLayoutProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public MarkerStyle? Symbol { get ; set; }
  
  /// <summary>
  /// size, this property is only available in Office 2013 and later.
  /// </summary>
  public Byte? Size { get ; set; }
  
}
