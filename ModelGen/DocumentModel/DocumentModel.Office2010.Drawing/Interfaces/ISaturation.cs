namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public interface ISaturation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  public int? SaturationAmount { get ; set; }
  
}
