namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the Style Class.
/// </summary>
public interface IStyle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public Byte? Val { get ; set; }
  
}
