namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public interface IColorStyle // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Method { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
}
