namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TableDefinitionPart
/// </summary>
public class TableDefinitionPart: DocumentModel.Packaging.OpenXmlPartContainer
{
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public OpenXmlPartContainer? QueryTableParts
  {
    get;
    set;
  }
  
}
