namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public static class DocumentConverter
{
  /// <summary>
  /// conformance
  /// </summary>
  private static DMW.DocumentConformance? GetConformance(DXW.Document openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance, DMW.DocumentConformance>(openXmlElement?.Conformance?.Value);
  }
  
  private static void SetConformance(DXW.Document openXmlElement, DMW.DocumentConformance? value)
  {
    openXmlElement.Conformance = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DocumentConformance, DMW.DocumentConformance>(value);
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  private static DMW.DocumentBackground? GetDocumentBackground(DXW.Document openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.DocumentBackground>();
    if (itemElement != null)
      return DMXW.DocumentBackgroundConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDocumentBackground(DXW.Document openXmlElement, DMW.DocumentBackground? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentBackground>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocumentBackgroundConverter.CreateOpenXmlElement<DXW.DocumentBackground>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Body.
  /// </summary>
  private static DMW.Body? GetBody(DXW.Document openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Body>();
    if (itemElement != null)
      return DMXW.BodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBody(DXW.Document openXmlElement, DMW.Body? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Body>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BodyConverter.CreateOpenXmlElement<DXW.Body>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.Document? CreateModelElement(DXW.Document? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Document();
      value.Conformance = GetConformance(openXmlElement);
      value.DocumentBackground = GetDocumentBackground(openXmlElement);
      value.Body = GetBody(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Document? value)
    where OpenXmlElementType: DXW.Document, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConformance(openXmlElement, value?.Conformance);
      SetDocumentBackground(openXmlElement, value?.DocumentBackground);
      SetBody(openXmlElement, value?.Body);
      return openXmlElement;
    }
    return default;
  }
}
