namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the PageMargins Class.
/// </summary>
public interface IPageMargins // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// l, this property is only available in Office 2016 and later.
  /// </summary>
  public double? L { get ; set; }
  
  /// <summary>
  /// r, this property is only available in Office 2016 and later.
  /// </summary>
  public double? R { get ; set; }
  
  /// <summary>
  /// t, this property is only available in Office 2016 and later.
  /// </summary>
  public double? T { get ; set; }
  
  /// <summary>
  /// b, this property is only available in Office 2016 and later.
  /// </summary>
  public double? B { get ; set; }
  
  /// <summary>
  /// header, this property is only available in Office 2016 and later.
  /// </summary>
  public double? Header { get ; set; }
  
  /// <summary>
  /// footer, this property is only available in Office 2016 and later.
  /// </summary>
  public double? Footer { get ; set; }
  
}
