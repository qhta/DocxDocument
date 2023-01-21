namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public static class TableStyleConditionalFormattingTableRowPropertiesConverter
{
  private static Boolean? GetHidden(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.Hidden>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetHidden(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.Hidden>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.Hidden();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.OnOffOnlyKind? GetCantSplit(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CantSplit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetCantSplit(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.CantSplit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.CantSplit, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.OnOffOnlyKind? GetTableHeader(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableHeader>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableHeader(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableHeader, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DMW.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableWidthType? GetTableCellSpacing(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      return DMXW.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellSpacing(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TableWidthTypeConverter.CreateOpenXmlElement<DXW.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMW.TableRowAlignmentKind? GetTableJustification(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableJustification(DXW.TableStyleConditionalFormattingTableRowProperties openXmlElement, DMW.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TableJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TableStyleConditionalFormattingTableRowProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TableStyleConditionalFormattingTableRowProperties();
      value.Hidden = GetHidden(openXmlElement);
      value.CantSplit = GetCantSplit(openXmlElement);
      value.TableHeader = GetTableHeader(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalFormattingTableRowProperties? value)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableRowProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetHidden(openXmlElement, value?.Hidden);
      SetCantSplit(openXmlElement, value?.CantSplit);
      SetTableHeader(openXmlElement, value?.TableHeader);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableJustification(openXmlElement, value?.TableJustification);
      return openXmlElement;
    }
    return default;
  }
}
