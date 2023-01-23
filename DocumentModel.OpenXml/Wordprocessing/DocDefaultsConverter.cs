namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Document Default Paragraph and Run Properties.
/// </summary>
public static class DocDefaultsConverter
{
  /// <summary>
  /// Default Run Properties.
  /// </summary>
  private static DMW.RunPropertiesDefault? GetRunPropertiesDefault(DXW.DocDefaults openXmlElement)
  {
    return DMXW.RunPropertiesDefaultConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.RunPropertiesDefault>());
  }
  
  private static bool CmpRunPropertiesDefault(DXW.DocDefaults openXmlElement, DMW.RunPropertiesDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesDefaultConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.RunPropertiesDefault>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunPropertiesDefault(DXW.DocDefaults openXmlElement, DMW.RunPropertiesDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesDefaultConverter.CreateOpenXmlElement<DXW.RunPropertiesDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Default Paragraph Properties.
  /// </summary>
  private static DMW.ParagraphPropertiesDefault? GetParagraphPropertiesDefault(DXW.DocDefaults openXmlElement)
  {
    return DMXW.ParagraphPropertiesDefaultConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesDefault>());
  }
  
  private static bool CmpParagraphPropertiesDefault(DXW.DocDefaults openXmlElement, DMW.ParagraphPropertiesDefault? value, DiffList? diffs, string? objName)
  {
    return DMXW.ParagraphPropertiesDefaultConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.ParagraphPropertiesDefault>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphPropertiesDefault(DXW.DocDefaults openXmlElement, DMW.ParagraphPropertiesDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.ParagraphPropertiesDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ParagraphPropertiesDefaultConverter.CreateOpenXmlElement<DXW.ParagraphPropertiesDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.DocDefaults? CreateModelElement(DXW.DocDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocDefaults();
      value.RunPropertiesDefault = GetRunPropertiesDefault(openXmlElement);
      value.ParagraphPropertiesDefault = GetParagraphPropertiesDefault(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.DocDefaults? openXmlElement, DMW.DocDefaults? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunPropertiesDefault(openXmlElement, value.RunPropertiesDefault, diffs, objName))
        ok = false;
      if (!CmpParagraphPropertiesDefault(openXmlElement, value.ParagraphPropertiesDefault, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocDefaults? value)
    where OpenXmlElementType: DXW.DocDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunPropertiesDefault(openXmlElement, value?.RunPropertiesDefault);
      SetParagraphPropertiesDefault(openXmlElement, value?.ParagraphPropertiesDefault);
      return openXmlElement;
    }
    return default;
  }
}
