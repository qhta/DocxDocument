namespace DocumentModel.Drawings;

/// <summary>
///   Represents properties for a text paragraph, including margins, indentation, alignment, tab size, line breaks, font alignment, spacing, and other formatting options.
/// </summary>
[OpenXmlType(typeof(DXD.ParagraphProperties))]
[DataContract]
[XmlRoot("ParagraphProperties", Namespace = "DocumentModel.Drawings")]
public partial class ParagraphProperties: ModelElement<DXD.ParagraphProperties>
{
  /// <summary>
  ///   Left margin of the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.LeftMargin))]
  public Int32? LeftMargin
  {
    get => _LeftMargin ??= GetProperty<Int32?>(GetUpdatableElement()?.LeftMargin);
    set => UpdateField(ref _LeftMargin, value, nameof(LeftMargin));
  }

  private Int32? _LeftMargin;

  /// <summary>
  ///   Right margin of the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.RightMargin))]
  public Int32? RightMargin
  {
    get => _RightMargin ??= GetProperty<Int32?>(GetUpdatableElement()?.RightMargin);
    set => UpdateField(ref _RightMargin, value, nameof(RightMargin));
  }

  private Int32? _RightMargin;

  /// <summary>
  ///   Outline level of the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.Level))]
  public Int32? Level
  {
    get => _Level ??= GetProperty<Int32?>(GetUpdatableElement()?.Level);
    set => UpdateField(ref _Level, value, nameof(Level));
  }

  private Int32? _Level;

  /// <summary>
  ///   Indentation value for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.Indent))]
  public Int32? Indent
  {
    get => _Indent ??= GetProperty<Int32?>(GetUpdatableElement()?.Indent);
    set => UpdateField(ref _Indent, value, nameof(Indent));
  }

  private Int32? _Indent;

  /// <summary>
  ///   Alignment of the paragraph text.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.Alignment))]
  public TextAlignment? Alignment
  {
    get => _Alignment ??= GetProperty<TextAlignment?>(GetUpdatableElement()?.Alignment);
    set => UpdateField(ref _Alignment, value, nameof(Alignment));
  }

  private TextAlignment? _Alignment;

  /// <summary>
  ///   Default tab size for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.DefaultTabSize))]
  public Int32? DefaultTabSize
  {
    get => _DefaultTabSize ??= GetProperty<Int32?>(GetUpdatableElement()?.DefaultTabSize);
    set => UpdateField(ref _DefaultTabSize, value, nameof(DefaultTabSize));
  }

  private Int32? _DefaultTabSize;

  /// <summary>
  ///   Indicates right-to-left text direction.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.RightToLeft))]
  public bool? RightToLeft
  {
    get => _RightToLeft ??= GetProperty<bool?>(GetUpdatableElement()?.RightToLeft);
    set => UpdateField(ref _RightToLeft, value, nameof(RightToLeft));
  }

  private bool? _RightToLeft;

  /// <summary>
  ///   Enables East Asian line break rules.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.EastAsianLineBreak))]
  public bool? EastAsianLineBreak
  {
    get => _EastAsianLineBreak ??= GetProperty<bool?>(GetUpdatableElement()?.EastAsianLineBreak);
    set => UpdateField(ref _EastAsianLineBreak, value, nameof(EastAsianLineBreak));
  }

  private bool? _EastAsianLineBreak;

  /// <summary>
  ///   TextFormat alignment within the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.FontAlignment))]
  public TextFontAlignment? FontAlignment
  {
    get => _FontAlignment ??= GetProperty<TextFontAlignment?>(GetUpdatableElement()?.FontAlignment);
    set => UpdateField(ref _FontAlignment, value, nameof(FontAlignment));
  }

  private TextFontAlignment? _FontAlignment;

  /// <summary>
  ///   Enables Latin line break rules.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.LatinLineBreak))]
  public bool? LatinLineBreak
  {
    get => _LatinLineBreak ??= GetProperty<bool?>(GetUpdatableElement()?.LatinLineBreak);
    set => UpdateField(ref _LatinLineBreak, value, nameof(LatinLineBreak));
  }

  private bool? _LatinLineBreak;

  /// <summary>
  ///   Enables hanging punctuation.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.Height))]
  public bool? Height
  {
    get => _Height ??= GetProperty<bool?>(GetUpdatableElement()?.Height);
    set => UpdateField(ref _Height, value, nameof(Height));
  }

  private bool? _Height;

  /// <summary>
  ///   Line spacing for the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.LineSpacing))]
  public LineSpacing? LineSpacing
  {
    get => _LineSpacing ??= GetProperty<LineSpacing?>(GetUpdatableElement()?.LineSpacing);
    set => UpdateField(ref _LineSpacing, value, nameof(LineSpacing));
  }

  private LineSpacing? _LineSpacing;

  /// <summary>
  ///   Space before the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.SpaceBefore))]
  public SpaceBefore? SpaceBefore
  {
    get => _SpaceBefore ??= GetProperty<SpaceBefore?>(GetUpdatableElement()?.SpaceBefore);
    set => UpdateField(ref _SpaceBefore, value, nameof(SpaceBefore));
  }

  private SpaceBefore? _SpaceBefore;

  /// <summary>
  ///   Space after the paragraph.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ParagraphProperties.SpaceAfter))]
  public SpaceAfter? SpaceAfter
  {
    get => _SpaceAfter ??= GetProperty<SpaceAfter?>(GetUpdatableElement()?.SpaceAfter);
    set => UpdateField(ref _SpaceAfter, value, nameof(SpaceAfter));
  }

  private SpaceAfter? _SpaceAfter;

  /// <summary>
  ///  Specifies the paragraph has an auto-numbered bullet applied to it.
  /// </summary>
  [OpenXmlElement(typeof(DXD.AutoNumberedBullet))]
  public Boolean? AutoNumberedBullet
  {
    get => _AutoNumberedBullet ??= GetElement<Boolean, DXD.AutoNumberedBullet>(GetUpdatableElement());
    set => UpdateField(ref _AutoNumberedBullet, value, nameof(AutoNumberedBullet));
  }

  private Boolean? _AutoNumberedBullet;

  /// <summary>
  ///  Specifies the color to be used on bullet characters.
  /// </summary>
  [OpenXmlElement(typeof(DXD.BulletColor))]
  public ColorType? BulletColor
  {
    get => _BulletColor ??= GetElement<ColorType, DXD.BulletColor>(GetUpdatableElement());
    set => UpdateField(ref _BulletColor, value, nameof(BulletColor));
  }

  private ColorType? _BulletColor;

  /// <summary>
  ///  Specifies the color of the bullets should be the same as of the text run.
  /// </summary>
  [OpenXmlElement(typeof(DXD.BulletColorText))]
  public Boolean? BulletColorText
  {
    get => _BulletColorText ??= GetElement<Boolean, DXD.BulletColorText>(GetUpdatableElement());
    set => UpdateField(ref _BulletColorText, value, nameof(BulletColorText));
  }

  private Boolean? _BulletColorText;

  /// <summary>
  ///  Specifies the typeface name of the font of bullet characters.
  /// </summary>
  [OpenXmlElement(typeof(DXD.BulletFont))]
  public string? BulletFont
  {
    get => _BulletFont ??= GetElement<string, DXD.BulletFont>(GetUpdatableElement());
    set => UpdateField(ref _BulletFont, value, nameof(BulletFont));
  }

  private string? _BulletFont;

  /// <summary>
  ///  Specifies the font of the bullets should be the same as of the text run.
  /// </summary>
  [OpenXmlElement(typeof(DXD.BulletFontText))]
  public Boolean? BulletFontText
  {
    get => _BulletFontText ??= GetElement<Boolean, DXD.BulletFontText>(GetUpdatableElement());
    set => UpdateField(ref _BulletFontText, value, nameof(BulletFontText));
  }

  private Boolean? _BulletFontText;

  /// <summary>
  ///  Specifies the percentage of the text size of the bullets. This attribute should not be lower than 25% and not be higher than 400%..
  /// </summary>
  [OpenXmlElement(typeof(DXD.BulletSizePercentage))]
  public Percentage? BulletSizePercentage
  {
    get => _BulletSizePercentage ??= GetElement<Percentage, DXD.BulletSizePercentage>(GetUpdatableElement());
    set => UpdateField(ref _BulletSizePercentage, value, nameof(BulletSizePercentage));
  }

  private Percentage? _BulletSizePercentage;

  /// <summary>
  ///  Specifies text size of the bullets in hundredths of a point. 
  /// </summary>
  [OpenXmlElement(typeof(DXD.BulletSizePoints))]
  public CPS? BulletSizePoints
  {
    get => _BulletSizePoints ??= GetElement<CPS, DXD.BulletSizePoints>(GetUpdatableElement());
    set => UpdateField(ref _BulletSizePoints, value, nameof(BulletSizePoints));
  }

  private CPS? _BulletSizePoints;
}