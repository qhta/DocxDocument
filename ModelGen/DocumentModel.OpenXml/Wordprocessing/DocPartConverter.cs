namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public static class DocPartConverter
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  private static DMW.DocPartProperties? GetDocPartProperties(DXW.DocPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocPartProperties>();
    if (element != null)
      return DMXW.DocPartPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocPartProperties(DXW.DocPart openXmlElement, DMW.DocPartProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocPartPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocPartProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocPartProperties(DXW.DocPart openXmlElement, DMW.DocPartProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocPartPropertiesConverter.CreateOpenXmlElement<DXW.DocPartProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  private static DMW.DocPartBody? GetDocPartBody(DXW.DocPart openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocPartBody>();
    if (element != null)
      return DMXW.DocPartBodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocPartBody(DXW.DocPart openXmlElement, DMW.DocPartBody? value, DiffList? diffs, string? objName)
  {
    return DMXW.DocPartBodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocPartBody>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDocPartBody(DXW.DocPart openXmlElement, DMW.DocPartBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocPartBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocPartBodyConverter.CreateOpenXmlElement<DXW.DocPartBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.DocPart? CreateModelElement(DXW.DocPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocPart();
      value.DocPartProperties = GetDocPartProperties(openXmlElement);
      value.DocPartBody = GetDocPartBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocPart? openXmlElement, DMW.DocPart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDocPartProperties(openXmlElement, value.DocPartProperties, diffs, objName))
        ok = false;
      if (!CmpDocPartBody(openXmlElement, value.DocPartBody, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPart value)
    where OpenXmlElementType: DXW.DocPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocPart openXmlElement, DMW.DocPart value)
  {
    SetDocPartProperties(openXmlElement, value?.DocPartProperties);
    SetDocPartBody(openXmlElement, value?.DocPartBody);
  }
}
