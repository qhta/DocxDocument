namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DataField Class.
/// </summary>
public interface IDataField // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// isCountDistinct, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? IsCountDistinct { get ; set; }
  
}
