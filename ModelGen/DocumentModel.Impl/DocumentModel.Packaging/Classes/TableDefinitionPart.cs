namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TableDefinitionPart
/// </summary>
public class TableDefinitionPartImpl: DocumentModel.Packaging.OpenXmlPartContainerImpl, TableDefinitionPart
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
