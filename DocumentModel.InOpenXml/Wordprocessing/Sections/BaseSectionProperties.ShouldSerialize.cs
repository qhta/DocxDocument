namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class BaseSectionProperties<T> 
{
  public bool ShouldSerializeRsidRPr() => RsidRPr is not null && ShouldSerialize(RsidRPr);
  public bool ShouldSerializeRsidDel() => RsidDel is not null && ShouldSerialize(RsidDel);
  public bool ShouldSerializeRsidR() => RsidR is not null && ShouldSerialize(RsidR);
  public bool ShouldSerializeRsidSect() => RsidSect is not null && ShouldSerialize(RsidSect);
  public bool ShouldSerializeSectionType() => SectionType is not null && ShouldSerialize(SectionType);
  public bool ShouldSerializeFormProtection() => FormProtection is not null;
  public bool ShouldSerializeVerticalTextAlignmentOnPage() => VerticalTextAlignmentOnPage is not null && ShouldSerialize(VerticalTextAlignmentOnPage);
  public bool ShouldSerializeNoEndnote() => NoEndnote is not null;
  public bool ShouldSerializeTitlePage() => TitlePage is not null;
  public bool ShouldSerializeTextDirection() => TextDirection is not null && ShouldSerialize(TextDirection);
  public bool ShouldSerializeBiDi() => BiDi is not null;
  public bool ShouldSerializeGutterOnRight() => GutterOnRight is not null;
  public bool ShouldSerializeFootnoteColumns() => FootnoteColumns is not null && ShouldSerialize(FootnoteColumns);
  public bool ShouldSerializeFootnoteProperties() => FootnoteProperties is not null && ShouldSerialize(FootnoteProperties);
  public bool ShouldSerializeEndnoteProperties() => EndnoteProperties is not null && ShouldSerialize(EndnoteProperties);
  public bool ShouldSerializePageSize() => PageSize is not null && ShouldSerialize(PageSize);
  public bool ShouldSerializePageMargin() => PageMargin is not null && ShouldSerialize(PageMargin);
  public bool ShouldSerializePaperSource() => PaperSource is not null && ShouldSerialize(PaperSource);
  public bool ShouldSerializePageBorders() => PageBorders is not null && ShouldSerialize(PageBorders);
  public bool ShouldSerializeLineNumberType() => LineNumberType is not null && ShouldSerialize(LineNumberType);
  public bool ShouldSerializePageNumberType() => PageNumberType is not null && ShouldSerialize(PageNumberType);
  public bool ShouldSerializeColumns() => Columns is not null && ShouldSerialize(Columns);
  public bool ShouldSerializeDocGrid() => DocGrid is not null && ShouldSerialize(DocGrid);
  public bool ShouldSerializePrinterSettingsReference() => PrinterSettingsReference is not null && ShouldSerialize(PrinterSettingsReference);
}
