namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single paragraph in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph?view=word-pia"/>
public partial class Paragraph : InteropObject
{
  /// <summary>
  /// Returns a Range object that represents the portion of a document that's contained in the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the formatting of the specified paragraph or
  /// paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.format?view=word-pia"/>
  public ParagraphFormat Format { get; set; }

  /// <summary>
  /// Returns or sets a TabStops collection that represents all the custom tab stops for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.tabstops?view=word-pia"/>
  public TabStops TabStops { get; set; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Returns a DropCap object that represents a dropped capital letter for the specified paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.dropcap?view=word-pia"/>
  public DropCap DropCap { get; }

  /// <summary>
  /// Returns or sets the style for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Returns or sets a ParagraphAlignment constant that represents the alignment for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.alignment?view=word-pia"/>
  public ParagraphAlignment Alignment { get; set; }

  /// <summary>
  /// Determines if all lines in the specified paragraphs remain on the same page when Microsoft Word repaginates
  /// the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.keeptogether?view=word-pia"/>
  public int KeepTogether { get; set; }

  /// <summary>
  /// Determines if the specified paragraph remains on the same page as the paragraph that follows it when Microsoft
  /// Word repaginates the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.keepwithnext?view=word-pia"/>
  public int KeepWithNext { get; set; }

  /// <summary>
  /// Determines if a page break is forced before the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.pagebreakbefore?view=word-pia"/>
  public int PageBreakBefore { get; set; }

  /// <summary>
  /// Determines if line numbers are repressed for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.nolinenumber?view=word-pia"/>
  public int NoLineNumber { get; set; }

  /// <summary>
  /// Returns or sets the right indent (in points) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.rightindent?view=word-pia"/>
  public float RightIndent { get; set; }

  /// <summary>
  /// Returns or sets a Single that represents the left indent value (in points) for the specified paragraphs, table
  /// rows, or HTML division.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// Returns or sets the value (in points) for a first line or hanging indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.firstlineindent?view=word-pia"/>
  public float FirstLineIndent { get; set; }

  /// <summary>
  /// Returns or sets the line spacing (in points) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.linespacing?view=word-pia"/>
  public float LineSpacing { get; set; }

  /// <summary>
  /// Returns or sets the line spacing for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.linespacingrule?view=word-pia"/>
  public LineSpacing LineSpacingRule { get; set; }

  /// <summary>
  /// Returns or sets the spacing (in points) before the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spacebefore?view=word-pia"/>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// Returns or sets the amount of spacing (in points) after the specified paragraph or text column.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// Determines if the specified paragraphs are included in automatic hyphenation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.hyphenation?view=word-pia"/>
  public int Hyphenation { get; set; }

  /// <summary>
  /// Determines if the first and last lines in the specified paragraph remain on the same page as the rest of the
  /// paragraph when Microsoft Word repaginates the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.widowcontrol?view=word-pia"/>
  public int WidowControl { get; set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Determines if Microsoft Word applies East Asian line-breaking rules to the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.fareastlinebreakcontrol?view=word-pia"/>
  public int FarEastLineBreakControl { get; set; }

  /// <summary>
  /// Determines if Microsoft Word wraps Latin text in the middle of a word in the specified paragraphs or text
  /// frames.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// Determines if hanging punctuation is enabled for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.hangingpunctuation?view=word-pia"/>
  public int HangingPunctuation { get; set; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the formatting of the specified paragraph or
  /// paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.halfwidthpunctuationontopofline?view=word-pia"/>
  public int HalfWidthPunctuationOnTopOfLine { get; set; }

  /// <summary>
  /// Determines if Microsoft Word is set to automatically add spaces between Japanese and Latin text for the
  /// specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.addspacebetweenfareastandalpha?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndAlpha { get; set; }

  /// <summary>
  /// Determines if Microsoft Word is set to automatically add spaces between Japanese and Latin text for the
  /// specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.addspacebetweenfareastanddigit?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndDigit { get; set; }

  /// <summary>
  /// Returns or sets a BaselineAlignment constant that represents the vertical position of fonts on a line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.baselinealignment?view=word-pia"/>
  public BaselineAlignment BaseLineAlignment { get; set; }

  /// <summary>
  /// Determines if Microsoft Word is set to automatically adjust the right indent for the specified paragraphs if
  /// you’ve specified a set number of characters per line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.autoadjustrightindent?view=word-pia"/>
  public int AutoAdjustRightIndent { get; set; }

  /// <summary>
  /// Determines if Microsoft Word aligns characters in the specified paragraphs to the line grid when a set number
  /// of lines per page is specified.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.disablelineheightgrid?view=word-pia"/>
  public int DisableLineHeightGrid { get; set; }

  /// <summary>
  /// Returns or sets the outline level for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.outlinelevel?view=word-pia"/>
  public OutlineLevel OutlineLevel { get; set; }

  /// <summary>
  /// Returns or sets the right indent value (in characters) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.characterunitrightindent?view=word-pia"/>
  public float CharacterUnitRightIndent { get; set; }

  /// <summary>
  /// Returns or sets the left indent value (in characters) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.characterunitleftindent?view=word-pia"/>
  public float CharacterUnitLeftIndent { get; set; }

  /// <summary>
  /// Returns or sets the value (in characters) for a first-line or hanging indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.characterunitfirstlineindent?view=word-pia"/>
  public float CharacterUnitFirstLineIndent { get; set; }

  /// <summary>
  /// Returns or sets the amount of spacing (in gridlines) before the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.lineunitbefore?view=word-pia"/>
  public float LineUnitBefore { get; set; }

  /// <summary>
  /// Returns or sets the amount of spacing (in gridlines) after the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.lineunitafter?view=word-pia"/>
  public float LineUnitAfter { get; set; }

  /// <summary>
  /// Returns or sets the reading order of the specified paragraphs without changing their alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.readingorder?view=word-pia"/>
  public ReadingOrder ReadingOrder { get; set; }

  /// <summary>
  /// Returns or sets the identifying label for the specified object when the current document is saved as a Web
  /// page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// Determines if Microsoft Word automatically sets the amount of spacing before the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spacebeforeauto?view=word-pia"/>
  public int SpaceBeforeAuto { get; set; }

  /// <summary>
  /// Determines if Microsoft Word automatically sets the amount of spacing after the specified paragraphs.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spaceafterauto?view=word-pia"/>
  public int SpaceAfterAuto { get; set; }

  /// <summary>
  /// Determines if a paragraph contains a special hidden paragraph mark that allows Microsoft Word to appear to
  /// join paragraphs of different paragraph styles.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.isstyleseparator?view=word-pia"/>
  public bool IsStyleSeparator { get; }

  /// <summary>
  /// Returns or sets a Integer that represents whether left and right indents are the same width. Can be True,
  /// False, or wdUndefined. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.mirrorindents?view=word-pia"/>
  public int MirrorIndents { get; set; }

  /// <summary>
  /// Returns or sets a TextboxTightWrap constant that represents how tightly text wraps around shapes or text
  /// boxes. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.textboxtightwrap?view=word-pia"/>
  public TextboxTightWrap TextboxTightWrap { get; set; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.paraid?view=word-pia"/>
  public int ParaID { get; }

  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.textid?view=word-pia"/>
  public int TextID { get; }

  /// <summary>
  /// Returns or sets whether the specified paragraph is currently in a collapsed state. Read-write Boolean (bool in
  /// C#).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.collapsedstate?view=word-pia"/>
  public bool CollapsedState { get; set; }

  /// <summary>
  /// Returns or sets whether the specified paragraph is collapsed by default when the document loads. Read-write
  /// Boolean (bool in C#).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.collapseheadingbydefault?view=word-pia"/>
  public bool CollapseHeadingByDefault { get; set; }
}
