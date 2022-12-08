namespace DocumentModel.Packaging;

/// <summary>
/// Defines the TableDefinitionPart
/// </summary>
public class TableDefinitionPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, TableDefinitionPart
{
  public new DocumentFormat.OpenXml.Packaging.TableDefinitionPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.TableDefinitionPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public QueryTablePart? QueryTableParts
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
}
