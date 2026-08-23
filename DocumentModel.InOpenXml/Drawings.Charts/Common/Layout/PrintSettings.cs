namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
[OpenXmlType(typeof(DXDC.PrintSettings))]
[DataContract]
[XmlRoot("PrintSettings", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PrintSettings : ModelElement<DXDC.PrintSettings>
{
  /// <summary>
  ///   Header and Footer.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PrintSettings.HeaderFooter))]
  public HeaderFooter? HeaderFooter { get => _HeaderFooter ??= GetProperty<HeaderFooter?>(GetUpdatableElement()?.HeaderFooter); set => UpdateField(ref _HeaderFooter, value, nameof(HeaderFooter)); }
  private HeaderFooter? _HeaderFooter;

  /// <summary>
  ///   Page Margins.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PrintSettings.PageMargins))]
  public PageMargins? PageMargins { get => _PageMargins ??= GetProperty<PageMargins?>(GetUpdatableElement()?.PageMargins); set => UpdateField(ref _PageMargins, value, nameof(PageMargins)); }
  private PageMargins? _PageMargins;

  /// <summary>
  ///   Page Setup.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PrintSettings.PageSetup))]
  public PageSetup? PageSetup { get => _PageSetup ??= GetProperty<PageSetup?>(GetUpdatableElement()?.PageSetup); set => UpdateField(ref _PageSetup, value, nameof(PageSetup)); }
  private PageSetup? _PageSetup;

  /// <summary>
  ///   Legacy Drawing for Headers and Footers.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PrintSettings.LegacyDrawingHeaderFooter))]
  public RelationshipIdType? LegacyDrawingHeaderFooter { get => _LegacyDrawingHeaderFooter ??= GetProperty<RelationshipIdType?>(GetUpdatableElement()?.LegacyDrawingHeaderFooter); set => UpdateField(ref _LegacyDrawingHeaderFooter, value, nameof(LegacyDrawingHeaderFooter)); }
  private RelationshipIdType? _LegacyDrawingHeaderFooter;
}