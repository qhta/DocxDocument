namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the properties for a phonetic guide (ruby text) in WordprocessingML documents.
/// This class provides options for alignment, font size, distance between guide and base text, base text size, language, and field cache status, enabling advanced formatting and localization of ruby annotations.
/// </summary>
[OpenXmlType(typeof(DXW.RubyProperties))]
[DataContract]
[XmlRoot("RubyProperties", Namespace = "DocumentModel.Wordprocessing")]
public partial class RubyProperties: ModelElement<DXW.RubyProperties>
{
  /// <summary>
  /// Alignment of the phonetic guide text relative to the base text.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RubyProperties.RubyAlign))]
  public RubyAlign? RubyAlign
  {
    get => _RubyAlign ??= GetProperty<RubyAlign?>(GetUpdatableElement()?.RubyAlign);
    set => UpdateField(ref _RubyAlign, value, nameof(RubyAlign));
  }

  private RubyAlign? _RubyAlign;

  /// <summary>
  /// TextFormat size of the phonetic guide text, specified in half-points.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RubyProperties.PhoneticGuideTextFontSize))]
  public HPS? PhoneticGuideTextFontSize
  {
    get => _PhoneticGuideTextFontSize ??= GetProperty<HPS?>(GetUpdatableElement()?.PhoneticGuideTextFontSize);
    set => UpdateField(ref _PhoneticGuideTextFontSize, value, nameof(PhoneticGuideTextFontSize));
  }

  private HPS? _PhoneticGuideTextFontSize;

  /// <summary>
  /// Distance between the phonetic guide text and the base text, specified in twips.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RubyProperties.PhoneticGuideRaise))]
  public Int16? PhoneticGuideRaise
  {
    get => _PhoneticGuideRaise ??= GetProperty<Int16?>(GetUpdatableElement()?.PhoneticGuideRaise);
    set => UpdateField(ref _PhoneticGuideRaise, value, nameof(PhoneticGuideRaise));
  }

  private Int16? _PhoneticGuideRaise;

  /// <summary>
  /// TextFormat size of the phonetic guide base text, specified in half-points.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RubyProperties.PhoneticGuideBaseTextSize))]
  public HPS? PhoneticGuideBaseTextSize
  {
    get => _PhoneticGuideBaseTextSize ??= GetProperty<HPS?>(GetUpdatableElement()?.PhoneticGuideBaseTextSize);
    set => UpdateField(ref _PhoneticGuideBaseTextSize, value, nameof(PhoneticGuideBaseTextSize));
  }

  private HPS? _PhoneticGuideBaseTextSize;

  /// <summary>
  /// Language ID for the phonetic guide, specifying the language used for annotation.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RubyProperties.LanguageId))]
  public string? LanguageId
  {
    get => _LanguageId ??= GetProperty<string?>(GetUpdatableElement()?.LanguageId);
    set => UpdateField(ref _LanguageId, value, nameof(LanguageId));
  }

  private string? _LanguageId;

  /// <summary>
  /// Indicates whether the field cache is invalidated for the phonetic guide.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.RubyProperties.Dirty))]
  public bool? Dirty
  {
    get => _Dirty ??= GetProperty<bool?>(GetUpdatableElement()?.Dirty);
    set => UpdateField(ref _Dirty, value, nameof(Dirty));
  }

  private bool? _Dirty;
}