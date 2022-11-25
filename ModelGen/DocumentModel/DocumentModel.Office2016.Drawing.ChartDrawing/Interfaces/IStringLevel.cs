namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
public interface IStringLevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? PtCount { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
}
