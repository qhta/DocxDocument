namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SharpenSoften Class.
/// </summary>
public interface ISharpenSoften // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// amount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Amount { get ; set; }
  
}
