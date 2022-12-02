namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Property.
/// </summary>
public interface ICustomProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Custom Property Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public String? Id { get ; set; }
  
}
