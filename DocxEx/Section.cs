namespace DocumentModel;

/// <summary>
/// Model of section in the document.
/// </summary>
public class Section : ModelElement
{
  /// <summary>
  /// Wrapped range of the section. Taken from OpenXmlTools.
  /// </summary>
  public SectionRange Range { get; } = null!;

  /// <summary>
  /// Constructor based on SectionRange
  /// </summary>
  /// <param name="range"></param>
  public Section(SectionRange range)
  {
    this.Range = range;
  }

  /// <summary>
  /// Wrapped section properties;
  /// </summary>
  public DXW.SectionProperties SectionProperties => Range.SectionProperties;

  /// <summary>
  /// Wrapped section elements.
  /// </summary>
  public IEnumerable<DX.OpenXmlElement> Elements => Range.Elements;


  /// <summary>
  /// Clean Section Properties.
  /// </summary>
  public void CleanProperties(SectionPropertyMask mask = SectionPropertyMask.All)
  {
    if (mask.HasFlag(SectionPropertyMask.HeaderReference))
      Range.SectionProperties.SetHeaderReferences(null);

    if (mask.HasFlag(SectionPropertyMask.FooterReference))
      Range.SectionProperties.SetFooterReferences(null);

    if (mask.HasFlag(SectionPropertyMask.FootnoteProperties))
      Range.SectionProperties.SetFootnoteProperties(null);

    if (mask.HasFlag(SectionPropertyMask.EndnoteProperties))
      Range.SectionProperties.SetEndnoteProperties(null);

    if (mask.HasFlag(SectionPropertyMask.SectionType))
      Range.SectionProperties.SetSectionType(null);

    if (mask.HasFlag(SectionPropertyMask.PageSize))
      Range.SectionProperties.SetPageSize(null);

    if (mask.HasFlag(SectionPropertyMask.PageMargin))
      Range.SectionProperties.SetPageMargin(null);

    if (mask.HasFlag(SectionPropertyMask.PaperSource))
      Range.SectionProperties.SetPaperSource(null);

    if (mask.HasFlag(SectionPropertyMask.PageBorders))
      Range.SectionProperties.SetPageBorders(null);

    if (mask.HasFlag(SectionPropertyMask.LineNumberType))
      Range.SectionProperties.SetLineNumberType(null);

    if (mask.HasFlag(SectionPropertyMask.PageNumberType))
      Range.SectionProperties.SetPageNumberType(null);

    if (mask.HasFlag(SectionPropertyMask.Columns))
      Range.SectionProperties.SetColumns(null);

    if (mask.HasFlag(SectionPropertyMask.FormProtection))
      Range.SectionProperties.SetFormProtection(null);

    if (mask.HasFlag(SectionPropertyMask.VerticalTextAlignmentOnPage))
      Range.SectionProperties.SetVerticalTextAlignmentOnPage(null);

    if (mask.HasFlag(SectionPropertyMask.NoEndnote))
      Range.SectionProperties.SetNoEndnote(null);

    if (mask.HasFlag(SectionPropertyMask.TitlePage))
      Range.SectionProperties.SetTitlePage(null);

    if (mask.HasFlag(SectionPropertyMask.TextDirection))
      Range.SectionProperties.SetTextDirection(null);

    if (mask.HasFlag(SectionPropertyMask.BiDi))
      Range.SectionProperties.SetBiDi(null);

    if (mask.HasFlag(SectionPropertyMask.GutterOnRight))
      Range.SectionProperties.SetGutterOnRight(null);

    if (mask.HasFlag(SectionPropertyMask.DocGrid))
      Range.SectionProperties.SetDocGrid(null);

    if (mask.HasFlag(SectionPropertyMask.PrinterSettingsReference))
      Range.SectionProperties.SetPrinterSettingsReference(null);

    if (mask.HasFlag(SectionPropertyMask.FootnoteColumns))
      Range.SectionProperties.SetFootnoteColumns(null);
    
    if (mask.HasFlag(SectionPropertyMask.SectionPropertiesChange))
      Range.SectionProperties.SetSectionPropertiesChange(null);

  }
}
