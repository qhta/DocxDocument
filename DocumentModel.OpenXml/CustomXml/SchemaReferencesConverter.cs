namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public static class SchemaReferencesConverter
{
  private static Collection<DMCustXml.SchemaReference> GetItems(DXCustXmlDataProps.SchemaReferences openXmlElement)
  {
    var collection = new Collection<DMCustXml.SchemaReference>();
    foreach (var item in openXmlElement.Elements<DXCustXmlDataProps.SchemaReference>())
    {
      var newItem = DMXCustXml.SchemaReferenceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXCustXmlDataProps.SchemaReferences openXmlElement, Collection<DMCustXml.SchemaReference>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXCustXmlDataProps.SchemaReference>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().ToString()+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXCustXml.SchemaReferenceConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  private static void SetItems(DXCustXmlDataProps.SchemaReferences openXmlElement, Collection<DMCustXml.SchemaReference>? value)
  {
    openXmlElement.RemoveAllChildren<DXCustXmlDataProps.SchemaReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXCustXml.SchemaReferenceConverter.CreateOpenXmlElement<DXCustXmlDataProps.SchemaReference>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMCustXml.SchemaReferences? CreateModelElement(DXCustXmlDataProps.SchemaReferences? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMCustXml.SchemaReferences();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCustXmlDataProps.SchemaReferences? openXmlElement, DMCustXml.SchemaReferences? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.SchemaReferences? value)
    where OpenXmlElementType: DXCustXmlDataProps.SchemaReferences, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
