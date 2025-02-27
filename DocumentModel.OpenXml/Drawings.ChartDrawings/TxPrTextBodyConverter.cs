namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the TxPrTextBody Class.
/// </summary>
public static class TxPrTextBodyConverter
{
  private static DMD.BodyProperties? GetBodyProperties(DXO16DCD.TxPrTextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BodyProperties>();
    if (element != null)
      return DMXD.BodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBodyProperties(DXO16DCD.TxPrTextBody openXmlElement, DMD.BodyProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BodyProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetBodyProperties(DXO16DCD.TxPrTextBody openXmlElement, DMD.BodyProperties? value)
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
  
  private static DMD.ListStyle? GetListStyle(DXO16DCD.TxPrTextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ListStyle>();
    if (element != null)
      return DMXD.ListStyleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpListStyle(DXO16DCD.TxPrTextBody openXmlElement, DMD.ListStyle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ListStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ListStyle>(), value, diffs, objName, propName);
  }
  
  private static void SetListStyle(DXO16DCD.TxPrTextBody openXmlElement, DMD.ListStyle? value)
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
  
  private static DMD.Paragraph? GetParagraph(DXO16DCD.TxPrTextBody openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Paragraph>();
    if (element != null)
      return DMXD.ParagraphConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraph(DXO16DCD.TxPrTextBody openXmlElement, DMD.Paragraph? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ParagraphConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Paragraph>(), value, diffs, objName, propName);
  }
  
  private static void SetParagraph(DXO16DCD.TxPrTextBody openXmlElement, DMD.Paragraph? value)
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
  
  public static DMDCDs.TxPrTextBody? CreateModelElement(DXO16DCD.TxPrTextBody? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.TxPrTextBody();
      value.BodyProperties = GetBodyProperties(openXmlElement);
      value.ListStyle = GetListStyle(openXmlElement);
      value.Paragraph = GetParagraph(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.TxPrTextBody? openXmlElement, DMDCDs.TxPrTextBody? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.TxPrTextBody value)
    where OpenXmlElementType: DXO16DCD.TxPrTextBody, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.TxPrTextBody openXmlElement, DMDCDs.TxPrTextBody value)
  {
    SetBodyProperties(openXmlElement, value?.BodyProperties);
    SetListStyle(openXmlElement, value?.ListStyle);
    SetParagraph(openXmlElement, value?.Paragraph);
  }
}
