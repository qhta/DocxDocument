namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the IsCanvas Class.
/// </summary>
public interface IIsCanvas // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Val { get ; set; }
  
}
