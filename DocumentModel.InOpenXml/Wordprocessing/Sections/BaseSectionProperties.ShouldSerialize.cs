namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseSectionProperties<T> 
{
  public bool ShouldSerializeRsidRPr() => RsidRPr is not null;
  public bool ShouldSerializeRsidDel() => RsidDel is not null;
  public bool ShouldSerializeRsidR() => RsidR is not null;
  public bool ShouldSerializeRsidSect() => RsidSect is not null;
  public bool ShouldSerializeSectionType() => SectionType is not null;
  public bool ShouldSerializeFormProtection() => FormProtection is not null;
  public bool ShouldSerializeVerticalTextAlignmentOnPage() => VerticalTextAlignmentOnPage is not null;
  public bool ShouldSerializeNoEndnote() => NoEndnote is not null;
  public bool ShouldSerializeTitlePage() => TitlePage is not null;
  public bool ShouldSerializeTextDirection() => TextDirection is not null;
  public bool ShouldSerializeBiDi() => BiDi is not null;
  public bool ShouldSerializeGutterOnRight() => GutterOnRight is not null;
  public bool ShouldSerializeFootnoteColumns() => FootnoteColumns is not null;
  public bool ShouldSerializeFootnoteProperties() => FootnoteProperties is not null;
  public bool ShouldSerializeEndnoteProperties() => EndnoteProperties is not null;
  public bool ShouldSerializePageSize() => PageSize is not null;
  public bool ShouldSerializePageMargin() => PageMargin is not null;
  public bool ShouldSerializePaperSource() => PaperSource is not null;
  public bool ShouldSerializePageBorders() => PageBorders is not null;
  public bool ShouldSerializeLineNumberType() => LineNumberType is not null;
  public bool ShouldSerializePageNumberType() => PageNumberType is not null;
  public bool ShouldSerializeColumns() => Columns is not null;
  public bool ShouldSerializeDocGrid() => DocGrid is not null;
  public bool ShouldSerializePrinterSettingsReference() => PrinterSettingsReference is not null;
}
