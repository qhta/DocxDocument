namespace DocumentModel.Drawings;

/// <summary>
///   Represents character-level formatting properties for text, including font, style, language, spacing, underline, strike, and outline settings.
/// </summary>
[OpenXmlType(typeof(DXD.TextCharacterPropertiesType))]
[DataContract]
[XmlRoot("TextCharacterPropertiesType", Namespace = "DocumentModel.Drawings")]
public partial class TextCharacterPropertiesType: ModelElement<DXD.TextCharacterPropertiesType>
{
  /// <summary>
  ///   Value available for backwards compatibility.
  /// </summary>
  public bool? SmtClean { get => _SmtClean; set => UpdateField(ref _SmtClean, value, nameof(SmtClean)); }

  private bool? _SmtClean;

  /// <summary>
  ///   Value available for backwards compatibility.
  /// </summary>
  public UInt32? SmtId { get => _SmtId; set => UpdateField(ref _SmtId, value, nameof(SmtId)); }

  private UInt32? _SmtId;

  /// <summary>
  ///   Indicates kumimoji (grouped characters) usage.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Kumimoji))]
  public bool? Kumimoji
  {
    get => _Kumimoji ??= GetProperty<bool?>(GetUpdatableElement()?.Kumimoji);
    set => UpdateField(ref _Kumimoji, value, nameof(Kumimoji));
  }

  private bool? _Kumimoji;

  /// <summary>
  ///   Language identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Language))]
  public string? Language
  {
    get => _Language ??= GetProperty<string?>(GetUpdatableElement()?.Language);
    set => UpdateField(ref _Language, value, nameof(Language));
  }

  private string? _Language;

  /// <summary>
  ///   Alternative language identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.AlternativeLanguage))]
  public string? AlternativeLanguage
  {
    get => _AlternativeLanguage ??= GetProperty<string?>(GetUpdatableElement()?.AlternativeLanguage);
    set => UpdateField(ref _AlternativeLanguage, value, nameof(AlternativeLanguage));
  }

  private string? _AlternativeLanguage;

  /// <summary>
  ///   TextFormat size.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.FontSize))]
  public Int32? FontSize
  {
    get => _FontSize ??= GetProperty<Int32?>(GetUpdatableElement()?.FontSize);
    set => UpdateField(ref _FontSize, value, nameof(FontSize));
  }

  private Int32? _FontSize;

  /// <summary>
  ///   Bold style.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Bold))]
  public bool? Bold
  {
    get => _Bold ??= GetProperty<bool?>(GetUpdatableElement()?.Bold);
    set => UpdateField(ref _Bold, value, nameof(Bold));
  }

  private bool? _Bold;

  /// <summary>
  ///   Italic style.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Italic))]
  public bool? Italic
  {
    get => _Italic ??= GetProperty<bool?>(GetUpdatableElement()?.Italic);
    set => UpdateField(ref _Italic, value, nameof(Italic));
  }

  private bool? _Italic;

  /// <summary>
  ///   Underline style.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Underline))]
  public TextUnderline? Underline
  {
    get => _Underline ??= GetProperty<TextUnderline?>(GetUpdatableElement()?.Underline);
    set => UpdateField(ref _Underline, value, nameof(Underline));
  }

  private TextUnderline? _Underline;

  /// <summary>
  ///   Strike-through style.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Strike))]
  public TextStrike? Strike
  {
    get => _Strike ??= GetProperty<TextStrike?>(GetUpdatableElement()?.Strike);
    set => UpdateField(ref _Strike, value, nameof(Strike));
  }

  private TextStrike? _Strike;

  /// <summary>
  ///   Kerning value.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Kerning))]
  public Int32? Kerning
  {
    get => _Kerning ??= GetProperty<Int32?>(GetUpdatableElement()?.Kerning);
    set => UpdateField(ref _Kerning, value, nameof(Kerning));
  }

  private Int32? _Kerning;

  /// <summary>
  ///   Capitalization style.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Capital))]
  public TextCaps? Capital
  {
    get => _Capital ??= GetProperty<TextCaps?>(GetUpdatableElement()?.Capital);
    set => UpdateField(ref _Capital, value, nameof(Capital));
  }

  private TextCaps? _Capital;

  /// <summary>
  ///   Spacing value.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Spacing))]
  public Int32? Spacing
  {
    get => _Spacing ??= GetProperty<Int32?>(GetUpdatableElement()?.Spacing);
    set => UpdateField(ref _Spacing, value, nameof(Spacing));
  }

  private Int32? _Spacing;

  /// <summary>
  ///   Indicates normalization of height.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.NormalizeHeight))]
  public bool? NormalizeHeight
  {
    get => _NormalizeHeight ??= GetProperty<bool?>(GetUpdatableElement()?.NormalizeHeight);
    set => UpdateField(ref _NormalizeHeight, value, nameof(NormalizeHeight));
  }

  private bool? _NormalizeHeight;

  /// <summary>
  ///   Baseline offset.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Baseline))]
  public Int32? Baseline
  {
    get => _Baseline ??= GetProperty<Int32?>(GetUpdatableElement()?.Baseline);
    set => UpdateField(ref _Baseline, value, nameof(Baseline));
  }

  private Int32? _Baseline;

  /// <summary>
  ///   Indicates proofing exclusion.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.NoProof))]
  public bool? NoProof
  {
    get => _NoProof ??= GetProperty<bool?>(GetUpdatableElement()?.NoProof);
    set => UpdateField(ref _NoProof, value, nameof(NoProof));
  }

  private bool? _NoProof;

  /// <summary>
  ///   Indicates dirty state.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Dirty))]
  public bool? Dirty
  {
    get => _Dirty ??= GetProperty<bool?>(GetUpdatableElement()?.Dirty);
    set => UpdateField(ref _Dirty, value, nameof(Dirty));
  }

  private bool? _Dirty;

  /// <summary>
  ///   Indicates spelling error.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.SpellingError))]
  public bool? SpellingError
  {
    get => _SpellingError ??= GetProperty<bool?>(GetUpdatableElement()?.SpellingError);
    set => UpdateField(ref _SpellingError, value, nameof(SpellingError));
  }

  private bool? _SpellingError;

  /// <summary>
  ///   Indicates smart tag clean state.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.SmartTagClean))]
  public bool? SmartTagClean
  {
    get => _SmartTagClean ??= GetProperty<bool?>(GetUpdatableElement()?.SmartTagClean);
    set => UpdateField(ref _SmartTagClean, value, nameof(SmartTagClean));
  }

  private bool? _SmartTagClean;

  /// <summary>
  ///   Smart tag identifier.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.SmartTagId))]
  public UInt32? SmartTagId
  {
    get => _SmartTagId ??= GetProperty<UInt32?>(GetUpdatableElement()?.SmartTagId);
    set => UpdateField(ref _SmartTagId, value, nameof(SmartTagId));
  }

  private UInt32? _SmartTagId;

  /// <summary>
  ///   Bookmark name.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Bookmark))]
  public string? Bookmark
  {
    get => _Bookmark ??= GetProperty<string?>(GetUpdatableElement()?.Bookmark);
    set => UpdateField(ref _Bookmark, value, nameof(Bookmark));
  }

  private string? _Bookmark;

  /// <summary>
  ///   Outline properties for the text.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.TextCharacterPropertiesType.Outline))]
  public LineProperties? Outline
  {
    get => _Outline ??= GetProperty<LineProperties?>(GetUpdatableElement()?.Outline);
    set => UpdateField(ref _Outline, value, nameof(Outline));
  }

  private LineProperties? _Outline;
}