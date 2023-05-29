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
  
  private static bool CmpContentType(DXPack.TableDefinitionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ContentType == value) return true;
    diffs?.Add(objName, "ContentType", openXmlElement?.ContentType, value);
    return false;
  }
  
  /// <summary>
  /// Gets the QueryTableParts of the TableDefinitionPart
  /// </summary>
  private static Collection<DMPack.QueryTablePart>? GetQueryTableParts(DXPack.TableDefinitionPart openXmlElement)
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
  
  private static bool CmpQueryTableParts(DXPack.TableDefinitionPart openXmlElement, Collection<DMPack.QueryTablePart>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static String? GetRelationshipType(DXPack.TableDefinitionPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  private static bool CmpRelationshipType(DXPack.TableDefinitionPart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.RelationshipType == value) return true;
    diffs?.Add(objName, "RelationshipType", openXmlElement?.RelationshipType, value);
    return false;
  }
  
  public static DocumentModel.Packaging.TableDefinitionPart? CreateModelElement(DXPack.TableDefinitionPart? openXmlElement)
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
  
  public static bool CompareModelElement(DXPack.TableDefinitionPart? openXmlElement, DMPack.TableDefinitionPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpContentType(openXmlElement, value.ContentType, diffs, objName))
        ok = false;
      if (!CmpQueryTableParts(openXmlElement, value.QueryTableParts, diffs, objName))
        ok = false;
      if (!CmpRelationshipType(openXmlElement, value.RelationshipType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.TableDefinitionPart value)
    where OpenXmlElementType: DXPack.TableDefinitionPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.TableDefinitionPart openXmlElement, DMPack.TableDefinitionPart value)
  {
    //SetContentType(openXmlElement, value?.ContentType);
    //SetQueryTableParts(openXmlElement, value?.QueryTableParts);
    //SetRelationshipType(openXmlElement, value?.RelationshipType);
  }
}
