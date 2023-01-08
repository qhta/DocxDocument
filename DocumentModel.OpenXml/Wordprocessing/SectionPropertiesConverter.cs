namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Section Properties.
/// </summary>
public static class SectionPropertiesConverter
{
  /// <summary>
  /// Physical Section Mark Character Revision ID
  /// </summary>
  public static DocumentModel.HexBinary? GetRsidRPr(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRsidRPr(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Section Deletion Revision ID
  /// </summary>
  public static DocumentModel.HexBinary? GetRsidDel(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRsidDel(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Section Addition Revision ID
  /// </summary>
  public static DocumentModel.HexBinary? GetRsidR(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRsidR(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Section Properties Revision ID
  /// </summary>
  public static DocumentModel.HexBinary? GetRsidSect(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRsidSect(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.HeaderFooterReferenceType? GetHeaderReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHeaderReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.HeaderFooterReferenceType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.HeaderFooterReferenceType? GetFooterReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFooterReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.HeaderFooterReferenceType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.FootnoteProperties? GetFootnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFootnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.FootnoteProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.EndnoteProperties? GetEndnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEndnoteProperties(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.EndnoteProperties? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SectionMarkKind? GetSectionType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DocumentModel.Wordprocessing.SectionMarkKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSectionType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.SectionMarkKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SectionType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.SectionType, DocumentFormat.OpenXml.Wordprocessing.SectionMarkValues, DocumentModel.Wordprocessing.SectionMarkKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.PageSize? GetPageSize(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPageSize(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.PageSize? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.PageMargin? GetPageMargin(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPageMargin(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.PageMargin? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.PaperSource? GetPaperSource(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPaperSource(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.PaperSource? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.PageBorders? GetPageBorders(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPageBorders(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.PageBorders? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.LineNumberType? GetLineNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLineNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.LineNumberType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.PageNumberType? GetPageNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPageNumberType(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.PageNumberType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.Columns? GetColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.Columns? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetFormProtection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFormProtection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.VerticalJustificationKind? GetVerticalTextAlignmentOnPage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DocumentModel.Wordprocessing.VerticalJustificationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetVerticalTextAlignmentOnPage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.VerticalJustificationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentOnPage, DocumentFormat.OpenXml.Wordprocessing.VerticalJustificationValues, DocumentModel.Wordprocessing.VerticalJustificationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetNoEndnote(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNoEndnote(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetTitlePage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTitlePage(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.TextDirectionKind? GetTextDirection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTextDirection(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.TextDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextDirection, DocumentFormat.OpenXml.Wordprocessing.TextDirectionValues, DocumentModel.Wordprocessing.TextDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetBiDi(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBiDi(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Boolean? GetGutterOnRight(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGutterOnRight(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.DocGrid? GetDocGrid(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDocGrid(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.DocGrid? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.RelationshipType? GetPrinterSettingsReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPrinterSettingsReference(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static Int32? GetFootnoteColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFootnoteColumns(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Wordprocessing.SectionPropertiesChange? GetSectionPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSectionPropertiesChange(DocumentFormat.OpenXml.Wordprocessing.SectionProperties? openXmlElement, DocumentModel.Wordprocessing.SectionPropertiesChange? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
