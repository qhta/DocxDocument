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
  
  private static bool CmpType(DXW.TableStyleProperties openXmlElement, DMW.TableStyleOverrideKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DMW.TableStyleOverrideKind>(openXmlElement?.Type?.Value, value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXW.StyleParagraphProperties>();
    if (element != null)
      return DMXW.StyleParagraphPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStyleParagraphProperties(DXW.TableStyleProperties openXmlElement, DMW.StyleParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.StyleParagraphPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.StyleParagraphProperties>(), value, diffs, objName);
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
  private static DMW.TableStyleRunProperties? GetRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (element != null)
      return DMXW.RunPropertiesBaseStyleConverter.CreateModelElement<DMW.TableStyleRunProperties>(element);
    return null;
  }
  
  private static bool CmpRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement, DMW.TableStyleRunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.RunPropertiesBaseStyleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>(), value, diffs, objName);
  }
  
  private static void SetRunPropertiesBaseStyle(DXW.TableStyleProperties openXmlElement, DMW.TableStyleRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.RunPropertiesBaseStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.RunPropertiesBaseStyleConverter.CreateOpenXmlElement(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  private static DMW.TableStyleConditionalTableProperties? GetTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>();
    if (element != null)
      return DMXW.TableStyleConditionalFormattingTablePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalTableProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTablePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableProperties>(), value, diffs, objName);
  }
  
  private static void SetTableStyleConditionalFormattingTableProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalTableProperties? value)
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
  private static DMW.TableStyleConditionalRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>();
    if (element != null)
      return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalRowProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTableRowPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableRowProperties>(), value, diffs, objName);
  }
  
  private static void SetTableStyleConditionalFormattingTableRowProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalRowProperties? value)
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
  private static DMW.TableStyleConditionalCellProperties? GetTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>();
    if (element != null)
      return DMXW.TableStyleConditionalFormattingTableCellPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalCellProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.TableStyleConditionalFormattingTableCellPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TableStyleConditionalFormattingTableCellProperties>(), value, diffs, objName);
  }
  
  private static void SetTableStyleConditionalFormattingTableCellProperties(DXW.TableStyleProperties openXmlElement, DMW.TableStyleConditionalCellProperties? value)
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
      value.TableStyleRunProperties = GetRunPropertiesBaseStyle(openXmlElement);
      value.TableStyleConditionalTableProperties = GetTableStyleConditionalFormattingTableProperties(openXmlElement);
      value.TableStyleConditionalRowProperties = GetTableStyleConditionalFormattingTableRowProperties(openXmlElement);
      value.TableStyleConditionalCellProperties = GetTableStyleConditionalFormattingTableCellProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleProperties? openXmlElement, DMW.TableStyleProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpStyleParagraphProperties(openXmlElement, value.StyleParagraphProperties, diffs, objName))
        ok = false;
      if (!CmpRunPropertiesBaseStyle(openXmlElement, value.TableStyleRunProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleConditionalFormattingTableProperties(openXmlElement, value.TableStyleConditionalTableProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleConditionalFormattingTableRowProperties(openXmlElement, value.TableStyleConditionalRowProperties, diffs, objName))
        ok = false;
      if (!CmpTableStyleConditionalFormattingTableCellProperties(openXmlElement, value.TableStyleConditionalCellProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleProperties value)
    where OpenXmlElementType: DXW.TableStyleProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleProperties openXmlElement, DMW.TableStyleProperties value)
  {
    SetType(openXmlElement, value?.Type);
    SetStyleParagraphProperties(openXmlElement, value?.StyleParagraphProperties);
    SetRunPropertiesBaseStyle(openXmlElement, value?.TableStyleRunProperties);
    SetTableStyleConditionalFormattingTableProperties(openXmlElement, value?.TableStyleConditionalTableProperties);
    SetTableStyleConditionalFormattingTableRowProperties(openXmlElement, value?.TableStyleConditionalRowProperties);
    SetTableStyleConditionalFormattingTableCellProperties(openXmlElement, value?.TableStyleConditionalCellProperties);
  }
}
