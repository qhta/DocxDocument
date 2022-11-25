namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DataField Class.
/// </summary>
public interface IDataField // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// isCountDistinct, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? IsCountDistinct { get ; set; }
  
}
