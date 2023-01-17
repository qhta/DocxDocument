namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Cell Properties.
/// </summary>
public static class TableStyleConditionalFormattingTableCellPropertiesConverter
{
  /// <summary>
  /// TableCellBorders.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableCellBorders? GetTableCellBorders(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellBorders(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableCellBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableCellBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement, DocumentModel.Wordprocessing.Shading? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Shading>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NoWrap.
  /// </summary>
  private static DocumentModel.Wordprocessing.OnOffOnlyKind? GetNoWrap(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoWrap>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNoWrap(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoWrap>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoWrap, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellMargin.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableCellMargin? GetTableCellMargin(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellMarginConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellMargin(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableCellMargin? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableCellMarginConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMargin>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableCellVerticalAlignment.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableVerticalAlignmentKind? GetTableCellVerticalAlignment(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DocumentModel.Wordprocessing.TableVerticalAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableCellVerticalAlignment(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties openXmlElement, DocumentModel.Wordprocessing.TableVerticalAlignmentKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DocumentModel.Wordprocessing.TableVerticalAlignmentKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties();
      value.TableCellBorders = GetTableCellBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.NoWrap = GetNoWrap(openXmlElement);
      value.TableCellMargin = GetTableCellMargin(openXmlElement);
      value.TableCellVerticalAlignment = GetTableCellVerticalAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties, new()
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
