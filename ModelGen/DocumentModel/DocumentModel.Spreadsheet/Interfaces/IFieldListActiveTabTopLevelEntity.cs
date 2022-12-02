namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldListActiveTabTopLevelEntity Class.
/// </summary>
public interface IFieldListActiveTabTopLevelEntity // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Type { get ; set; }
  
}
