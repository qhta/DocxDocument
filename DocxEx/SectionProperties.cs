namespace DocumentModel;

/// <summary>
/// Model of section properties.
/// </summary>
public class SectionProperties : ModelElement
{
  /// <summary>
  /// Wrapped Wordprocessing element.
  /// </summary>
  public DXW.SectionProperties Element { get; private set; }

  /// <summary>
  /// Constructor based on Wordprocessing element.
  /// </summary>
  /// <param name="element"></param>
  public SectionProperties(DXW.SectionProperties element)
  {
    Element = element;
  }

  public IEnumerable<DXW.HeaderReference> HeaderReferences { get => Element.GetHeaderReferences(); set => Element.SetHeaderReferences(value); }

  public IEnumerable<DXW.FooterReference> FooterReferences { get => Element.GetFooterReferences(); set => Element.SetFooterReferences(value); }

  public DXW.FootnoteProperties FootnoteProperties { get => Element.GetFootnoteProperties(); set => Element.SetFootnoteProperties(value); }

  public DXW.EndnoteProperties EndnoteProperties { get => Element.GetEndnoteProperties(); set => Element.SetEndnoteProperties(value); }

  public DXW.SectionType SectionType { get => Element.GetSectionType(); set => Element.SetSectionType(value); }

  public DXW.PageSize PageSize { get => Element.GetPageSize(); set => Element.SetPageSize(value); }

  public DXW.PageMargin PageMargin { get => Element.GetPageMargin(); set => Element.SetPageMargin(value); }

  public DXW.PaperSource PaperSource { get => Element.GetPaperSource(); set => Element.SetPaperSource(value); }

  public DXW.PageBorders PageBorders { get => Element.GetPageBorders(); set => Element.SetPageBorders(value); }

  public DXW.LineNumberType LineNumberType { get => Element.GetLineNumberType(); set => Element.SetLineNumberType(value); }

  public DXW.PageNumberType PageNumberType { get => Element.GetPageNumberType(); set => Element.SetPageNumberType(value); }

  public DXW.Columns Columns { get => Element.GetColumns(); set => Element.SetColumns(value); }

  public DXW.FormProtection FormProtection { get => Element.GetFormProtection(); set => Element.SetFormProtection(value); }

  public DXW.VerticalTextAlignmentOnPage VerticalTextAlignmentOnPage { get => Element.GetVerticalTextAlignmentOnPage(); set => Element.SetVerticalTextAlignmentOnPage(value); }

  public DXW.NoEndnote NoEndnote { get => Element.GetNoEndnote(); set => Element.SetNoEndnote(value); }

  public DXW.TitlePage TitlePage { get => Element.GetTitlePage(); set => Element.SetTitlePage(value); }

  public DXW.TextDirection TextDirection { get => Element.GetTextDirection(); set => Element.SetTextDirection(value); }

  public DXW.BiDi BiDi { get => Element.GetBiDi(); set => Element.SetBiDi(value); }

  public DXW.GutterOnRight GutterOnRight { get => Element.GetGutterOnRight(); set => Element.SetGutterOnRight(value); }

  public DXW.DocGrid DocGrid { get => Element.GetDocGrid(); set => Element.SetDocGrid(value); }

  public DXW.PrinterSettingsReference PrinterSettingsReference { get => Element.GetPrinterSettingsReference(); set => Element.SetPrinterSettingsReference(value); }

  public DXO13W.FootnoteColumns FootnoteColumns { get => Element.GetFootnoteColumns(); set => Element.SetFootnoteColumns(value); }

  public DXW.SectionPropertiesChange SectionPropertiesChange { get => Element.GetSectionPropertiesChange(); set => Element.SetSectionPropertiesChange(value); }


}
