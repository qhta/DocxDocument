namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Custom File Properties.
/// </summary>
public static class CustomPropertiesConverter
{
  private static Collection<DMProps.CustomDocumentProperty>? GetCustomDocumentProperties(DXCustProps.Properties openXmlElement)
  {
    var collection = new Collection<DMProps.CustomDocumentProperty>();
    foreach (var item in openXmlElement.Elements<DXCustProps.CustomDocumentProperty>())
    {
      var newItem = DMXProps.CustomDocumentPropertyConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpCustomDocumentProperties(DXCustProps.Properties openXmlElement, Collection<DMProps.CustomDocumentProperty>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXCustProps.CustomDocumentProperty>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXProps.CustomDocumentPropertyConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetCustomDocumentProperties(DXCustProps.Properties openXmlElement, Collection<DMProps.CustomDocumentProperty>? value)
  {
    openXmlElement.RemoveAllChildren<DXCustProps.CustomDocumentProperty>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXProps.CustomDocumentPropertyConverter.CreateOpenXmlElement<DXCustProps.CustomDocumentProperty>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Properties.CustomProperties? CreateModelElement(DXCustProps.Properties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.CustomProperties();
      value.CustomDocumentProperties = GetCustomDocumentProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCustProps.Properties? openXmlElement, DMProps.CustomProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomDocumentProperties(openXmlElement, value.CustomDocumentProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.CustomProperties value)
    where OpenXmlElementType: DXCustProps.Properties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXCustProps.Properties openXmlElement, DMProps.CustomProperties value)
  {
    SetCustomDocumentProperties(openXmlElement, value?.CustomDocumentProperties);
  }
}
