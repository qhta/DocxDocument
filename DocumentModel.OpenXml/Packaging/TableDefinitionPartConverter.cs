namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the TableDefinitionPart
/// </summary>
public static class TableDefinitionPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.TableDefinitionPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.QueryTablePart>? GetQueryTableParts(DocumentFormat.OpenXml.Packaging.TableDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.QueryTablePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.QueryTablePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.TableDefinitionPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.TableDefinitionPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.TableDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.TableDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.QueryTableParts = GetQueryTableParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.TableDefinitionPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.TableDefinitionPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
