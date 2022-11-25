namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public interface IPageMargins // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? L { get ; set; }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? R { get ; set; }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? T { get ; set; }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? B { get ; set; }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? Header { get ; set; }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Double? Footer { get ; set; }
  
}
