namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Style Conditional Table Formatting Properties.
/// </summary>
public static class TableStylePropertiesConverter
{
  /// <summary>
  /// Table Style Conditional Formatting Type
  /// </summary>
  public static DocumentModel.Wordprocessing.TableStyleOverrideKind? GetType(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DocumentModel.Wordprocessing.TableStyleOverrideKind>(openXmlElement?.Type?.Value);
  }
  
  public static void SetType(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement, DocumentModel.Wordprocessing.TableStyleOverrideKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.TableStyleOverrideValues, DocumentModel.Wordprocessing.TableStyleOverrideKind>(value);
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Paragraph Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.StyleParagraphProperties? GetStyleParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetStyleParagraphProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement, DocumentModel.Wordprocessing.StyleParagraphProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Run Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.RunPropertiesBaseStyle? GetRunPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRunPropertiesBaseStyle(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement, DocumentModel.Wordprocessing.RunPropertiesBaseStyle? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? GetTableStyleConditionalFormattingTableProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableStyleConditionalFormattingTableProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement, DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Row Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? GetTableStyleConditionalFormattingTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableStyleConditionalFormattingTableRowProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement, DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Table Style Conditional Formatting Table Cell Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? GetTableStyleConditionalFormattingTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableStyleConditionalFormattingTableCellProperties(DocumentFormat.OpenXml.Wordprocessing.TableStyleProperties? openXmlElement, DocumentModel.Wordprocessing.TableStyleConditionalFormattingTableCellProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
