namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Style Conditional Formatting Table Row Properties.
/// </summary>
public static class TableStyleConditionalFormattingTableRowPropertiesConverter
{
  public static Boolean? GetHidden(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHidden(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetCantSplit(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CantSplit>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetCantSplit(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetTableHeader(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableHeader>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTableHeader(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TableJustification>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DocumentModel.Wordprocessing.TableRowAlignmentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableStyleConditionalFormattingTableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
  {
    if (openXmlElement != null)
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
  }
  
}
