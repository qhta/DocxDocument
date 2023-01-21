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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocPartProperties>();
    if (itemElement != null)
      return DMXW.DocPartPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocPartBody>();
    if (itemElement != null)
      return DMXW.DocPartBodyConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMW.DocPart? CreateModelElement(DXW.DocPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocPart();
      value.DocPartProperties = GetDocPartProperties(openXmlElement);
      value.DocPartBody = GetDocPartBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocPart? value)
    where OpenXmlElementType: DXW.DocPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDocPartProperties(openXmlElement, value?.DocPartProperties);
      SetDocPartBody(openXmlElement, value?.DocPartBody);
      return openXmlElement;
    }
    return default;
  }
}
