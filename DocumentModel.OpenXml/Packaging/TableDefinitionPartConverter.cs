namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the TableDefinitionPart
/// </summary>
public static class TableDefinitionPartConverter
{
  private static String? GetContentType(DXPack.TableDefinitionPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  private static Collection<DMPack.QueryTablePart> GetQueryTableParts(DXPack.TableDefinitionPart openXmlElement)
  {
    var collection = new Collection<DMPack.QueryTablePart>();
    foreach (var item in openXmlElement.GetPartsOfType<DXPack.QueryTablePart>())
    {
      var newItem = DMXPack.QueryTablePartConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static String? GetRelationshipType(DXPack.TableDefinitionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DMPack.TableDefinitionPart? CreateModelElement(DXPack.TableDefinitionPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.TableDefinitionPart();
      value.ContentType = GetContentType(openXmlElement);
      value.QueryTableParts = GetQueryTableParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.TableDefinitionPart? value)
    where OpenXmlElementType: DXPack.TableDefinitionPart, new()
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
