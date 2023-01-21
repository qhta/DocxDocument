namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
public static class TableStylePropertiesConverter
{
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  private static DMW.TableStyleOverrideKind? GetType(DXW.TableStyleProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DMW.TableStyleOverrideKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXW.TableStyleProperties openXmlElement, DMW.TableStyleOverrideKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DMW.TableStyleOverrideKind>(value);
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  private static DMW.StyleParagraphProperties? GetStyleParagraphProperties(DXW.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.StyleParagraphProperties>();
    if (itemElement != null)
      return DMXW.StyleParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleParagraphProperties(DXW.TableStyleProperties openXmlElement, DMW.StyleParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.StyleParagraphPropertiesConverter.CreateOpenXmlElement<DXW.StyleParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  private static DMW.RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (itemElement != null)
      return DMXW.RunPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement, DMW.RunPropertiesBaseStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DXW.RunPropertiesBaseStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  private static DMW.TableStyleConditionalFormattingTableProperties? GetTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>();
    if (itemElement != null)
      return DMXW.TableStyleConditionalFormattingTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalFormattingTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTablePropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  private static DMW.TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalFormattingTableRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  private static DMW.TableStyleConditionalFormattingTableCellProperties? GetTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>();
    if (itemElement != null)
      return DMXW.TableStyleConditionalFormattingTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalFormattingTableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableStyleConditionalFormattingTableCellPropertiesConverter.CreateOpenXmlElement<DXW.TableStyleConditionalFormattingTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableStyleProperties? CreateModelElement(DXW.TableStyleProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableStyleProperties();
      value.Type = GetType(openXmlElement);
      value.StyleParagraphProperties = GetStyleParagraphProperties(openXmlElement);
      value.RunPropertiesBaseStyle = GetRunPropertiesBaseStyle(openXmlElement);
      value.TableStyleConditionalFormattingTableProperties = GetTableStyleConditionalFormattingTableProperties(openXmlElement);
      value.TableStyleConditionalFormattingTableRowProperties = GetTableStyleConditionalFormattingTableRowProperties(openXmlElement);
      value.TableStyleConditionalFormattingTableCellProperties = GetTableStyleConditionalFormattingTableCellProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleProperties? value)
    where OpenXmlElementType: DXW.TableStyleProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetStyleParagraphProperties(openXmlElement, value?.StyleParagraphProperties);
      SetRunPropertiesBaseStyle(openXmlElement, value?.RunPropertiesBaseStyle);
      SetTableStyleConditionalFormattingTableProperties(openXmlElement, value?.TableStyleConditionalFormattingTableProperties);
      SetTableStyleConditionalFormattingTableRowProperties(openXmlElement, value?.TableStyleConditionalFormattingTableRowProperties);
      SetTableStyleConditionalFormattingTableCellProperties(openXmlElement, value?.TableStyleConditionalFormattingTableCellProperties);
      return openXmlElement;
    }
    return default;
  }
}
