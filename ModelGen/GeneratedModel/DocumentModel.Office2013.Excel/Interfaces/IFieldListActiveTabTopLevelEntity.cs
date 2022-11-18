namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the FieldListActiveTabTopLevelEntity Class.
/// </summary>
public interface IFieldListActiveTabTopLevelEntity // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Type { get ; set; }
  
}
