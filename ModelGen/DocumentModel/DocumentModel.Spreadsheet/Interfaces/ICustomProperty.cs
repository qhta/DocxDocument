namespace DocumentModel.Spreadsheet;

/// <summary>
/// Custom Property.
/// </summary>
public interface ICustomProperty // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Custom Property Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public System.String? Id { get ; set; }
  
}
