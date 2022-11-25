namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public interface ISaturation // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? SaturationAmount { get ; set; }
  
}
