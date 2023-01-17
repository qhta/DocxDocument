namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Table Row Properties.
/// </summary>
public static class PreviousTableRowPropertiesConverter
{
  private static DocumentModel.Wordprocessing.ConditionalFormatStyle? GetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ConditionalFormatStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.ConditionalFormatStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ConditionalFormatStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ConditionalFormatStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetDivId(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDivId(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DivId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.DivId { Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGridBefore(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GridBefore>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGridBefore(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GridBefore>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.GridBefore{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetGridAfter(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GridAfter>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGridAfter(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.GridAfter>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.GridAfter{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TableWidthType? GetWidthBeforeTableRow(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidthBeforeTableRow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWidthBeforeTableRow(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidthBeforeTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.WidthBeforeTableRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TableWidthType? GetWidthAfterTableRow(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidthAfterTableRow>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWidthAfterTableRow(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.WidthAfterTableRow>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.WidthAfterTableRow>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TableRowHeight? GetTableRowHeight(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableRowHeightConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableRowHeight(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.TableRowHeight? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableRowHeightConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowHeight>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetHidden(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hidden>();
    return itemElement != null;
  }
  
  private static void SetHidden(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Hidden>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Wordprocessing.Hidden();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetCantSplit(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CantSplit>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetCantSplit(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CantSplit>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CantSplit, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetTableHeader(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableHeader>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableHeader(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableHeader>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableHeader, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DocumentModel.Wordprocessing.TableRowAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DocumentModel.Wordprocessing.TableRowAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.PreviousTableRowProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PreviousTableRowProperties();
      value.ConditionalFormatStyle = GetConditionalFormatStyle(openXmlElement);
      value.DivId = GetDivId(openXmlElement);
      value.GridBefore = GetGridBefore(openXmlElement);
      value.GridAfter = GetGridAfter(openXmlElement);
      value.WidthBeforeTableRow = GetWidthBeforeTableRow(openXmlElement);
      value.WidthAfterTableRow = GetWidthAfterTableRow(openXmlElement);
      value.TableRowHeight = GetTableRowHeight(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.CantSplit = GetCantSplit(openXmlElement);
      value.TableHeader = GetTableHeader(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableJustification = GetTableJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PreviousTableRowProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PreviousTableRowProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConditionalFormatStyle(openXmlElement, value?.ConditionalFormatStyle);
      SetDivId(openXmlElement, value?.DivId);
      SetGridBefore(openXmlElement, value?.GridBefore);
      SetGridAfter(openXmlElement, value?.GridAfter);
      SetWidthBeforeTableRow(openXmlElement, value?.WidthBeforeTableRow);
      SetWidthAfterTableRow(openXmlElement, value?.WidthAfterTableRow);
      SetTableRowHeight(openXmlElement, value?.TableRowHeight);
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
