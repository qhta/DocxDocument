using DocumentFormat.OpenXml.Packaging;
using QueryTablePart = DocumentModel.Packaging.QueryTablePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the TableDefinitionPart
/// </summary>
public static class TableDefinitionPartConverter
{
  public static String? GetContentType(TableDefinitionPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  public static Collection<QueryTablePart>? GetQueryTableParts(TableDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<QueryTablePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.QueryTablePart>())
      {
        var newItem = QueryTablePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetRelationshipType(TableDefinitionPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.TableDefinitionPart? CreateModelElement(TableDefinitionPart? openXmlElement)
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
    where OpenXmlElementType : TableDefinitionPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetQueryTableParts(openXmlElement, value?.QueryTableParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}