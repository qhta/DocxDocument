namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Shape Text Body.
/// </summary>
public static class TextBodyConverter
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  private static DMD.BodyProperties? GetBodyProperties(DXDCD.TextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BodyProperties>();
    if (element != null)
      return DMXD.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXDCD.TextBody openXmlElement, DMD.BodyProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BodyProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetBodyProperties(DXDCD.TextBody openXmlElement, DMD.BodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BodyPropertiesConverter.CreateOpenXmlElement<DXD.BodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  private static DMD.ListStyle? GetListStyle(DXDCD.TextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ListStyle>();
    if (element != null)
      return DMXD.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXDCD.TextBody openXmlElement, DMD.ListStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ListStyle>(), value, diffs, objName, propName);
  }
  
  private static void SetListStyle(DXDCD.TextBody openXmlElement, DMD.ListStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ListStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ListStyleConverter.CreateOpenXmlElement<DXD.ListStyle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.Paragraph? GetParagraph(DXDCD.TextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Paragraph>();
    if (element != null)
      return DMXD.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXDCD.TextBody openXmlElement, DMD.Paragraph? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Paragraph>(), value, diffs, objName, propName);
  }
  
  private static void SetParagraph(DXDCD.TextBody openXmlElement, DMD.Paragraph? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Paragraph>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphConverter.CreateOpenXmlElement<DXD.Paragraph>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.ChartDrawing.TextBody? CreateModelElement(DXDCD.TextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.ChartDrawing.TextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDCD.TextBody? openXmlElement, DMDCD.TextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBodyProperties(openXmlElement, value.BodyProperties, diffs, objName, propName))
        ok = false;
      if (!CmpListStyle(openXmlElement, value.ListStyle, diffs, objName, propName))
        ok = false;
      if (!CmpParagraph(openXmlElement, value.Paragraph, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.TextBody value)
    where OpenXmlElementType: DXDCD.TextBody, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.TextBody openXmlElement, DMDCD.TextBody value)
  {
    SetBodyProperties(openXmlElement, value?.BodyProperties);
    SetListStyle(openXmlElement, value?.ListStyle);
    SetParagraph(openXmlElement, value?.Paragraph);
  }
}
