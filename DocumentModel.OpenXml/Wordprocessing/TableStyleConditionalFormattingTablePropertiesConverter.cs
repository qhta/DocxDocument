namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Properties.
/// </summary>
public static class TableStyleConditionalFormattingTablePropertiesConverter
{
  /// <summary>
  /// TableJustification.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DocumentModel.Wordprocessing.TableRowAlignmentKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
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
  
  /// <summary>
  /// TableCellSpacing.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellSpacing>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableWidthTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
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
  
  /// <summary>
  /// TableIndentation.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableIndentation? GetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableIndentationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableIndentation(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement, DocumentModel.Wordprocessing.TableIndentation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableIndentationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableIndentation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TableBorders.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableBorders? GetTableBorders(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableBordersConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableBorders(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement, DocumentModel.Wordprocessing.TableBorders? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableBorders>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableBordersConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableBorders>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  private static DocumentModel.Wordprocessing.Shading? GetShading(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Shading>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.ShadingConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShading(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement, DocumentModel.Wordprocessing.Shading? value)
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
  /// TableCellMarginDefault.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableCellMarginDefault? GetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableCellMarginDefaultConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableCellMarginDefault(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties openXmlElement, DocumentModel.Wordprocessing.TableCellMarginDefault? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableCellMarginDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableCellMarginDefault>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties();
      value.TableJustification = GetTableJustification(openXmlElement);
      value.TableCellSpacing = GetTableCellSpacing(openXmlElement);
      value.TableIndentation = GetTableIndentation(openXmlElement);
      value.TableBorders = GetTableBorders(openXmlElement);
      value.Shading = GetShading(openXmlElement);
      value.TableCellMarginDefault = GetTableCellMarginDefault(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTableJustification(openXmlElement, value?.TableJustification);
      SetTableCellSpacing(openXmlElement, value?.TableCellSpacing);
      SetTableIndentation(openXmlElement, value?.TableIndentation);
      SetTableBorders(openXmlElement, value?.TableBorders);
      SetShading(openXmlElement, value?.Shading);
      SetTableCellMarginDefault(openXmlElement, value?.TableCellMarginDefault);
      return openXmlElement;
    }
    return default;
  }
}
