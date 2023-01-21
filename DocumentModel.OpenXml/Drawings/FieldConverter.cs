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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.RunProperties>();
    if (itemElement != null)
      return DMXDraws.RunPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ParagraphProperties>();
    if (itemElement != null)
      return DMXDraws.ParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
  
  private static void SetText(DXDraw.Field openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Text = new DXDraw.Text(value);
    else
      openXmlElement.Text = null;
  }
  
  public static DMDraws.Field? CreateModelElement(DXDraw.Field? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Field();
      value.Id = GetId(openXmlElement);
      value.Type = GetType(openXmlElement);
      value.RunProperties = GetRunProperties(openXmlElement);
      value.ParagraphProperties = GetParagraphProperties(openXmlElement);
      value.Text = GetText(openXmlElement);
      return value;
    }
    return null;
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
