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
    return EnumValueConverter.GetValue<DXW.DocumentConformance, DMW.DocumentConformance>(openXmlElement?.Conformance?.Value);
  }
  
  private static bool CmpConformance(DXW.Document openXmlElement, DMW.DocumentConformance? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.DocumentConformance, DMW.DocumentConformance>(openXmlElement?.Conformance?.Value, value, diffs, objName, propName);
  }
  
  private static void SetConformance(DXW.Document openXmlElement, DMW.DocumentConformance? value)
  {
    openXmlElement.Conformance = EnumValueConverter.CreateEnumValue<DXW.DocumentConformance, DMW.DocumentConformance>(value);
  }
  
  /// <summary>
  /// Document Background.
  /// </summary>
  private static DMW.DocumentBackground? GetDocumentBackground(DXW.Document openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.DocumentBackground>();
    if (element != null)
      return DMXW.DocumentBackgroundConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentBackground(DXW.Document openXmlElement, DMW.DocumentBackground? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.DocumentBackgroundConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.DocumentBackground>(), value, diffs, objName, propName);
  }
  
  private static void SetDocumentBackground(DXW.Document openXmlElement, DMW.DocumentBackground? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.DocumentBackground>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.DocumentBackgroundConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Body.
  /// </summary>
  private static DMW.Body? GetBody(DXW.Document openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.Body>();
    if (element != null)
      return DMXW.BodyConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBody(DXW.Document openXmlElement, DMW.Body? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXW.BodyConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.Body>(), value, diffs, objName, propName);
  }
  
  private static void SetBody(DXW.Document openXmlElement, DMW.Body? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Body>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.BodyConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
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
  
  public static bool CompareModelElement(DXW.Document? openXmlElement, DMW.Document? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpConformance(openXmlElement, value.Conformance, diffs, objName, propName))
        ok = false;
      if (!CmpDocumentBackground(openXmlElement, value.DocumentBackground, diffs, objName, propName))
        ok = false;
      if (!CmpBody(openXmlElement, value.Body, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Document value)
    where OpenXmlElementType: DXW.Document, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.Document openXmlElement, DMW.Document value)
  {
    SetConformance(openXmlElement, value?.Conformance);
    SetDocumentBackground(openXmlElement, value?.DocumentBackground);
    SetBody(openXmlElement, value?.Body);
  }
}
