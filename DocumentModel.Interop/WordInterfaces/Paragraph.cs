namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single paragraph in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph?view=word-pia"/>
public partial interface Paragraph : InteropObject
{
  /// <summary>
  /// The range.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.range?view=word-pia"/>
  public Range Range { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.format?view=word-pia"/>
  public ParagraphFormat Format { get; set; }

  /// <summary>
  /// The tab stops.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.tabstops?view=word-pia"/>
  public TabStops TabStops { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The drop cap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.dropcap?view=word-pia"/>
  public DropCap DropCap { get; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.alignment?view=word-pia"/>
  public WdParagraphAlignment Alignment { get; set; }

  /// <summary>
  /// The keep together.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.keeptogether?view=word-pia"/>
  public int KeepTogether { get; set; }

  /// <summary>
  /// The keep with next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.keepwithnext?view=word-pia"/>
  public int KeepWithNext { get; set; }

  /// <summary>
  /// The page break before.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.pagebreakbefore?view=word-pia"/>
  public int PageBreakBefore { get; set; }

  /// <summary>
  /// The no line number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.nolinenumber?view=word-pia"/>
  public int NoLineNumber { get; set; }

  /// <summary>
  /// The right indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.rightindent?view=word-pia"/>
  public float RightIndent { get; set; }

  /// <summary>
  /// The left indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The first line indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.firstlineindent?view=word-pia"/>
  public float FirstLineIndent { get; set; }

  /// <summary>
  /// The line spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.linespacing?view=word-pia"/>
  public float LineSpacing { get; set; }

  /// <summary>
  /// The line spacing rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.linespacingrule?view=word-pia"/>
  public WdLineSpacing LineSpacingRule { get; set; }

  /// <summary>
  /// The space before.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spacebefore?view=word-pia"/>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// The space after.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// The hyphenation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.hyphenation?view=word-pia"/>
  public int Hyphenation { get; set; }

  /// <summary>
  /// The widow control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.widowcontrol?view=word-pia"/>
  public int WidowControl { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The far east line break control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.fareastlinebreakcontrol?view=word-pia"/>
  public int FarEastLineBreakControl { get; set; }

  /// <summary>
  /// The word wrap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// The hanging punctuation.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.hangingpunctuation?view=word-pia"/>
  public int HangingPunctuation { get; set; }

  /// <summary>
  /// The half width punctuation on top of line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.halfwidthpunctuationontopofline?view=word-pia"/>
  public int HalfWidthPunctuationOnTopOfLine { get; set; }

  /// <summary>
  /// The add space between far east and alpha.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.addspacebetweenfareastandalpha?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndAlpha { get; set; }

  /// <summary>
  /// The add space between far east and digit.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.addspacebetweenfareastanddigit?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndDigit { get; set; }

  /// <summary>
  /// The base line alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.baselinealignment?view=word-pia"/>
  public WdBaselineAlignment BaseLineAlignment { get; set; }

  /// <summary>
  /// The auto adjust right indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.autoadjustrightindent?view=word-pia"/>
  public int AutoAdjustRightIndent { get; set; }

  /// <summary>
  /// The disable line height grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.disablelineheightgrid?view=word-pia"/>
  public int DisableLineHeightGrid { get; set; }

  /// <summary>
  /// The outline level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.outlinelevel?view=word-pia"/>
  public WdOutlineLevel OutlineLevel { get; set; }

  /// <summary>
  /// The character unit right indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.characterunitrightindent?view=word-pia"/>
  public float CharacterUnitRightIndent { get; set; }

  /// <summary>
  /// The character unit left indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.characterunitleftindent?view=word-pia"/>
  public float CharacterUnitLeftIndent { get; set; }

  /// <summary>
  /// The character unit first line indent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.characterunitfirstlineindent?view=word-pia"/>
  public float CharacterUnitFirstLineIndent { get; set; }

  /// <summary>
  /// The line unit before.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.lineunitbefore?view=word-pia"/>
  public float LineUnitBefore { get; set; }

  /// <summary>
  /// The line unit after.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.lineunitafter?view=word-pia"/>
  public float LineUnitAfter { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.readingorder?view=word-pia"/>
  public WdReadingOrder ReadingOrder { get; set; }

  /// <summary>
  /// The id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.id?view=word-pia"/>
  public string ID { get; set; }

  /// <summary>
  /// The space before auto.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spacebeforeauto?view=word-pia"/>
  public int SpaceBeforeAuto { get; set; }

  /// <summary>
  /// The space after auto.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.spaceafterauto?view=word-pia"/>
  public int SpaceAfterAuto { get; set; }

  /// <summary>
  /// The is style separator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.isstyleseparator?view=word-pia"/>
  public bool IsStyleSeparator { get; }

  /// <summary>
  /// The mirror indents.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.mirrorindents?view=word-pia"/>
  public int MirrorIndents { get; set; }

  /// <summary>
  /// The textbox tight wrap.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.textboxtightwrap?view=word-pia"/>
  public WdTextboxTightWrap TextboxTightWrap { get; set; }

  /// <summary>
  /// The para id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.paraid?view=word-pia"/>
  public int ParaID { get; }

  /// <summary>
  /// The text id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.textid?view=word-pia"/>
  public int TextID { get; }

  /// <summary>
  /// The collapsed state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.collapsedstate?view=word-pia"/>
  public bool CollapsedState { get; set; }

  /// <summary>
  /// The collapse heading by default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraph.collapseheadingbydefault?view=word-pia"/>
  public bool CollapseHeadingByDefault { get; set; }
}
