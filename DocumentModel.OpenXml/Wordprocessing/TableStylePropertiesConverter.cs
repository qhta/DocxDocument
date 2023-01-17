namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
public static class TableStylePropertiesConverter
{
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  private static DocumentModel.Wordprocessing.TableStyleOverrideKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DocumentModel.Wordprocessing.TableStyleOverrideKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement, DocumentModel.Wordprocessing.TableStyleOverrideKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DocumentModel.Wordprocessing.TableStyleOverrideKind>(value);
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.StyleParagraphProperties? GetStyleParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.StyleParagraphPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStyleParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement, DocumentModel.Wordprocessing.StyleParagraphProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.StyleParagraphPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.StyleParagraphProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.RunPropertiesBaseStyleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRunPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement, DocumentModel.Wordprocessing.RunPropertiesBaseStyle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.RunPropertiesBaseStyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesBaseStyle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? GetTableStyleConditionalFormattingTableProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableStyleConditionalFormattingTableProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement, DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTablePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableStyleConditionalFormattingTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement, DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  private static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? GetTableStyleConditionalFormattingTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTableStyleConditionalFormattingTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties openXmlElement, DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableCellProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TableStyleProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TableStyleProperties();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TableStyleProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties, new()
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
