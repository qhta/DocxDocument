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
  
  public TableDefinitionPartImpl(): base() {}
  
  public TableDefinitionPartImpl(DocumentFormat.OpenXml.Packaging.TableDefinitionPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.TableDefinitionPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public QueryTablePart? QueryTableParts
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new String? RelationshipType
  {
    get => (String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.TableDefinitionPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
}
