namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Represents header and footer configuration for printed chart output.
/// </summary>
/// <remarks>
///   This class defines header and footer settings that control how
///   text appears at the top and bottom of printed chart pages. Headers and footers provide consistent page decoration
///   for printed charts, displaying information such as chart titles, page numbers, dates, author names, or other
///   contextual information that helps identify and organize printed output. The class supports sophisticated
///   header/footer configurations including separate content for odd and even pages (<see cref = "DifferentOddEven"/>),
///   distinct first-page headers/footers (<see cref = "DifferentFirst"/>), and margin alignment options
///   (<see cref = "AlignWithMargins"/>). This flexibility enables professional document formatting where headers and
///   footers can mirror each other on facing pages (for bound documents), provide special first-page treatment (such
///   as omitting headers on title pages), or align consistently with page margins. The header and footer content is
///   specified through string properties for different page scenarios: odd pages, even pages, and first page, with
///   separate properties for headers and footers in each case. These strings may contain plain text, formatting codes,
///   or field references that are resolved during printing. Header and footer configuration is referenced by
///   <see cref = "PrintSettings"/> within the <see cref = "ChartSpace"/>, controlling how charts appear when printed or
///   exported to print-oriented formats such as PDF. This configuration ensures that printed charts maintain consistent,
///   professional appearance with appropriate page decoration that aids in document organization and identification.
/// </remarks>
[OpenXmlType(typeof(DXO16DCD.HeaderFooter))]
[DataContract]
[XmlRoot("HeaderFooter", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class HeaderFooter : ModelElement<DXO16DCD.HeaderFooter>
{
  /// <summary>
  /// Specifies the align with margins.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.AlignWithMargins))]
  public bool? AlignWithMargins { get => _AlignWithMargins ??= GetProperty<bool?>(GetUpdatableElement()?.AlignWithMargins); set => UpdateField(ref _AlignWithMargins, value, nameof(AlignWithMargins)); }

  private bool? _AlignWithMargins;
  /// <summary>
  /// Specifies the different odd even.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.DifferentOddEven))]
  public bool? DifferentOddEven { get => _DifferentOddEven ??= GetProperty<bool?>(GetUpdatableElement()?.DifferentOddEven); set => UpdateField(ref _DifferentOddEven, value, nameof(DifferentOddEven)); }

  private bool? _DifferentOddEven;
  /// <summary>
  /// Specifies the different first.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.DifferentFirst))]
  public bool? DifferentFirst { get => _DifferentFirst ??= GetProperty<bool?>(GetUpdatableElement()?.DifferentFirst); set => UpdateField(ref _DifferentFirst, value, nameof(DifferentFirst)); }

  private bool? _DifferentFirst;
  /// <summary>
  /// Specifies the odd header xsd string.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.OddHeaderXsdstring))]
  public string? OddHeaderXsdString { get => _OddHeaderXsdString ??= GetProperty<string?>(GetUpdatableElement()?.OddHeaderXsdstring); set => UpdateField(ref _OddHeaderXsdString, value, nameof(OddHeaderXsdString)); }

  private string? _OddHeaderXsdString;
  /// <summary>
  /// Specifies the odd footer xsd string.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.OddFooterXsdstring))]
  public string? OddFooterXsdString { get => _OddFooterXsdString ??= GetProperty<string?>(GetUpdatableElement()?.OddFooterXsdstring); set => UpdateField(ref _OddFooterXsdString, value, nameof(OddFooterXsdString)); }

  private string? _OddFooterXsdString;
  /// <summary>
  /// Specifies the even header xsd string.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.EvenHeaderXsdstring))]
  public string? EvenHeaderXsdString { get => _EvenHeaderXsdString ??= GetProperty<string?>(GetUpdatableElement()?.EvenHeaderXsdstring); set => UpdateField(ref _EvenHeaderXsdString, value, nameof(EvenHeaderXsdString)); }

  private string? _EvenHeaderXsdString;
  /// <summary>
  /// Specifies the even footer xsd string.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.EvenFooterXsdstring))]
  public string? EvenFooterXsdString { get => _EvenFooterXsdString ??= GetProperty<string?>(GetUpdatableElement()?.EvenFooterXsdstring); set => UpdateField(ref _EvenFooterXsdString, value, nameof(EvenFooterXsdString)); }

  private string? _EvenFooterXsdString;
  /// <summary>
  /// Specifies the first header xsd string.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.FirstHeaderXsdstring))]
  public string? FirstHeaderXsdString { get => _FirstHeaderXsdString ??= GetProperty<string?>(GetUpdatableElement()?.FirstHeaderXsdstring); set => UpdateField(ref _FirstHeaderXsdString, value, nameof(FirstHeaderXsdString)); }

  private string? _FirstHeaderXsdString;
  /// <summary>
  /// Specifies the first footer xsd string.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.HeaderFooter.FirstFooterXsdstring))]
  public string? FirstFooterXsdString { get => _FirstFooterXsdString ??= GetProperty<string?>(GetUpdatableElement()?.FirstFooterXsdstring); set => UpdateField(ref _FirstFooterXsdString, value, nameof(FirstFooterXsdString)); }

  private string? _FirstFooterXsdString;
}