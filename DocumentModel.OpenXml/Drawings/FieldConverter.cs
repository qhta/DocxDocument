namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Field.
/// </summary>
public static class FieldConverter
{
  /// <summary>
  /// Field ID
  /// </summary>
  private static String? GetId(DXDraw.Field openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXDraw.Field openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXDraw.Field openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Field Type
  /// </summary>
  private static String? GetType(DXDraw.Field openXmlElement)
  {
    return openXmlElement?.Type?.Value;
  }
  
  private static bool CmpType(DXDraw.Field openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Type?.Value == value) return true;
    diffs?.Add(objName, "Type", openXmlElement?.Type?.Value, value);
    return false;
  }
  
  private static void SetType(DXDraw.Field openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Type = new StringValue { Value = value };
    else
      openXmlElement.Type = null;
  }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  private static DMDraws.RunProperties? GetRunProperties(DXDraw.Field openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RunProperties>();
    if (element != null)
      return DMXDraws.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXDraw.Field openXmlElement, DMDraws.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunProperties(DXDraw.Field openXmlElement, DMDraws.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RunPropertiesConverter.CreateOpenXmlElement<DXDraw.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text Paragraph Properties.
  /// </summary>
  private static DMDraws.ParagraphProperties? GetParagraphProperties(DXDraw.Field openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ParagraphProperties>();
    if (element != null)
      return DMXDraws.ParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpParagraphProperties(DXDraw.Field openXmlElement, DMDraws.ParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ParagraphProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetParagraphProperties(DXDraw.Field openXmlElement, DMDraws.ParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ParagraphPropertiesConverter.CreateOpenXmlElement<DXDraw.ParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  private static String? GetText(DXDraw.Field openXmlElement)
  {
    return openXmlElement?.Text?.Text;
  }
  
  private static bool CmpText(DXDraw.Field openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Text?.Text == value) return true;
    diffs?.Add(objName, "Text", openXmlElement?.Text?.Text, value);
    return false;
  }
  
  private static void SetText(DXDraw.Field openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Text = new DXDraw.Text(value);
    else
      openXmlElement.Text = null;
  }
  
  public static DocumentModel.Drawings.Field? CreateModelElement(DXDraw.Field? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.Field? openXmlElement, DMDraws.Field? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Field? value)
    where OpenXmlElementType: DXDraw.Field, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetType(openXmlElement, value?.Type);
      SetRunProperties(openXmlElement, value?.RunProperties);
      SetParagraphProperties(openXmlElement, value?.ParagraphProperties);
      SetText(openXmlElement, value?.Text);
      return openXmlElement;
    }
    return default;
  }
}
