namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public static class FieldConverter
{
  /// <summary>
  /// Field ID
  /// </summary>
  private static String? GetId(DXD.Field openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXD.Field openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXD.Field openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Field Type
  /// </summary>
  private static String? GetType(DXD.Field openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Type);
  }
  
  private static bool CmpType(DXD.Field openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Type, value, diffs, objName, "Type");
  }
  
  private static void SetType(DXD.Field openXmlElement, String? value)
  {
    openXmlElement.Type = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  private static DMD.RunProperties? GetRunProperties(DXD.Field openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RunProperties>();
    if (element != null)
      return DMXD.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXD.Field openXmlElement, DMD.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RunProperties>(), value, diffs, objName);
  }
  
  private static void SetRunProperties(DXD.Field openXmlElement, DMD.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RunPropertiesConverter.CreateOpenXmlElement<DXD.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  private static DMD.ParagraphProperties? GetParagraphProperties(DXD.Field openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ParagraphProperties>();
    if (element != null)
      return DMXD.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraphProperties(DXD.Field openXmlElement, DMD.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ParagraphProperties>(), value, diffs, objName);
  }
  
  private static void SetParagraphProperties(DXD.Field openXmlElement, DMD.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ParagraphPropertiesConverter.CreateOpenXmlElement<DXD.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  private static String? GetText(DXD.Field openXmlElement)
  {
    return openXmlElement?.Text?.Text;
  }
  
  private static bool CmpText(DXD.Field openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Text?.Text == value) return true;
    diffs?.Add(objName, "Text", openXmlElement?.Text?.Text, value);
    return false;
  }
  
  private static void SetText(DXD.Field openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Text = new DXD.Text(value);
    else
      openXmlElement.Text = null;
  }
  
  public static DocumentModel.Drawings.Field? CreateModelElement(DXD.Field? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Field();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.RunProperties = GetRunProperties(openXmlElement);
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.Text = GetText(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Field? openXmlElement, DMD.Field? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      if (!CmpParagraphProperties(openXmlElement, value.ParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpText(openXmlElement, value.Text, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Field value)
    where OpenXmlElementType: DXD.Field, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Field openXmlElement, DMD.Field value)
  {
    SetId(openXmlElement, value?.Id);
    SetType(openXmlElement, value?.Type);
    SetRunProperties(openXmlElement, value?.RunProperties);
    SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
    SetText(openXmlElement, value?.Text);
  }
}
