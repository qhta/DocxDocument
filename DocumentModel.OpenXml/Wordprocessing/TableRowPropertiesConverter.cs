namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Table Row Properties.
/// </summary>
public static class TableRowPropertiesConverter
{
  public static DocumentModel.Wordprocessing.ConditionalFormatStyle? GetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetConditionalFormatStyle(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.ConditionalFormatStyle? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static String? GetDivId(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.DivId");
  }
  
  public static void SetDivId(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGridBefore(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGridBefore(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetGridAfter(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGridAfter(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TableWidthType? GetWidthBeforeTableRow(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidthBeforeTableRow(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TableWidthType? GetWidthAfterTableRow(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetWidthAfterTableRow(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TableRowHeight? GetTableRowHeight(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableRowHeight(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableRowHeight? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetHidden(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHidden(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetCantSplit(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
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
  
  public static void SetCantSplit(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
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
  
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetTableHeader(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
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
  
  public static void SetTableHeader(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
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
  
  public static DocumentModel.Wordprocessing.TableWidthType? GetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableCellSpacing(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableWidthType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TableRowAlignmentKind? GetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
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
  
  public static void SetTableJustification(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableRowAlignmentKind? value)
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
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetInserted(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetInserted(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType? GetDeleted(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDeleted(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TableRowPropertiesChange? GetTableRowPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTableRowPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TableRowPropertiesChange? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetConflictInsertion(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TrackChangeType2? GetConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetConflictDeletion(DocumentFormat.OpenXml.Wordprocessing.TableRowProperties? openXmlElement, DocumentModel.Wordprocessing.TrackChangeType2? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
