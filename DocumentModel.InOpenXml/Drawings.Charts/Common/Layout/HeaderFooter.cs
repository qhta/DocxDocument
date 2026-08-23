namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Header and Footer.
/// </summary>
[OpenXmlType(typeof(DXDC.HeaderFooter))]
[DataContract]
[XmlRoot("HeaderFooter", Namespace = "DocumentModel.Drawings.Charts")]
public partial class HeaderFooter: ModelElement<DXDC.HeaderFooter>
{
  /// <summary>
  ///   Align With Margins
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.AlignWithMargins))]
  public bool? AlignWithMargins
  {
    get => _AlignWithMargins ??= GetProperty<bool?>(GetUpdatableElement()?.AlignWithMargins);
    set => UpdateField(ref _AlignWithMargins, value, nameof(AlignWithMargins));
  }

  private bool? _AlignWithMargins;

  /// <summary>
  ///   Different Odd Even
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.DifferentOddEven))]
  public bool? DifferentOddEven
  {
    get => _DifferentOddEven ??= GetProperty<bool?>(GetUpdatableElement()?.DifferentOddEven);
    set => UpdateField(ref _DifferentOddEven, value, nameof(DifferentOddEven));
  }

  private bool? _DifferentOddEven;

  /// <summary>
  ///   Different First
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.DifferentFirst))]
  public bool? DifferentFirst
  {
    get => _DifferentFirst ??= GetProperty<bool?>(GetUpdatableElement()?.DifferentFirst);
    set => UpdateField(ref _DifferentFirst, value, nameof(DifferentFirst));
  }

  private bool? _DifferentFirst;

  /// <summary>
  ///   Odd Header.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.OddHeader))]
  public string? OddHeader
  {
    get => _OddHeader ??= GetProperty<string?>(GetUpdatableElement()?.OddHeader);
    set => UpdateField(ref _OddHeader, value, nameof(OddHeader));
  }

  private string? _OddHeader;

  /// <summary>
  ///   Odd Footer.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.OddFooter))]
  public string? OddFooter
  {
    get => _OddFooter ??= GetProperty<string?>(GetUpdatableElement()?.OddFooter);
    set => UpdateField(ref _OddFooter, value, nameof(OddFooter));
  }

  private string? _OddFooter;

  /// <summary>
  ///   Even Header.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.EvenHeader))]
  public string? EvenHeader
  {
    get => _EvenHeader ??= GetProperty<string?>(GetUpdatableElement()?.EvenHeader);
    set => UpdateField(ref _EvenHeader, value, nameof(EvenHeader));
  }

  private string? _EvenHeader;

  /// <summary>
  ///   Even Footer.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.EvenFooter))]
  public string? EvenFooter
  {
    get => _EvenFooter ??= GetProperty<string?>(GetUpdatableElement()?.EvenFooter);
    set => UpdateField(ref _EvenFooter, value, nameof(EvenFooter));
  }

  private string? _EvenFooter;

  /// <summary>
  ///   First Header.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.FirstHeader))]
  public string? FirstHeader
  {
    get => _FirstHeader ??= GetProperty<string?>(GetUpdatableElement()?.FirstHeader);
    set => UpdateField(ref _FirstHeader, value, nameof(FirstHeader));
  }

  private string? _FirstHeader;

  /// <summary>
  ///   First Footer.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.HeaderFooter.FirstFooter))]
  public string? FirstFooter
  {
    get => _FirstFooter ??= GetProperty<string?>(GetUpdatableElement()?.FirstFooter);
    set => UpdateField(ref _FirstFooter, value, nameof(FirstFooter));
  }

  private string? _FirstFooter;
}