namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public static class TableStyleConditionalFormattingTableCellPropertiesConverter
{
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  private static DMW.TableCellBorders? GetTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellBorders>();
    if (itemElement != null)
      return DMXW.TableCellBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellBorders(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellBordersConverter.CreateOpenXmlElement<DXW.TableCellBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DMW.Shading? GetShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      return DMXW.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  private static DMW.OnOffOnlyKind? GetNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoWrap>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoWrap(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.NoWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.NoWrap, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  private static DMW.TableCellMargin? GetTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      return DMXW.TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellMargin(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  private static DMW.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableCellVerticalAlignment(DXW.TableStyleConditionalFormattingTableCellProperties openXmlElement, DMW.TableVerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableStyleConditionalFormattingTableCellProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableStyleConditionalFormattingTableCellProperties();
      value.TableCellBorders = GetTableCellBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.NoWrap = GetNoWrap(openXmlElement);
      value.TableCellMargin = GetTableCellMargin(openXmlElement);
      value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalFormattingTableCellProperties? value)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableCellProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableCellBorders(openXmlElement, value?.TableCellBorders);
      SetShading(openXmlElement, value?.Shading);
      SetNoWrap(openXmlElement, value?.NoWrap);
      SetTableCellMargin(openXmlElement, value?.TableCellMargin);
      SetTableCellVerticalAlignment(openXmlElement, value?.TableCellVerticalAlignment);
      return openXmlElement;
    }
    return default;
  }
}
