namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Paragraph objects in a selection, range, or document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs?view=word-pia"/>
public partial interface Paragraphs : InteropObject, InteropCollection<Paragraph>
{
  /// <summary>
  /// The first.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.first?view=word-pia"/>
  public Paragraph First { get; }

  /// <summary>
  /// The last.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.last?view=word-pia"/>
  public Paragraph Last { get; }

  /// <summary>
  /// The format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.format?view=word-pia"/>
  public ParagraphFormat Format { get; set; }

  /// <summary>
  /// The tab stops.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.tabstops?view=word-pia"/>
  public TabStops TabStops { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.alignment?view=word-pia"/>
  public WdParagraphAlignment Alignment { get; set; }

  /// <summary>
  /// The keep together.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.keeptogether?view=word-pia"/>
  public int KeepTogether { get; set; }

  /// <summary>
  /// The keep with next.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.keepwithnext?view=word-pia"/>
  public int KeepWithNext { get; set; }

  /// <summary>
  /// The page break before.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.pagebreakbefore?view=word-pia"/>
  public int PageBreakBefore { get; set; }

  /// <summary>
  /// The no line number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.nolinenumber?view=word-pia"/>
  public int NoLineNumber { get; set; }

  /// <summary>
  /// The right indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.rightindent?view=word-pia"/>
  public float RightIndent { get; set; }

  /// <summary>
  /// The left indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The first line indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.firstlineindent?view=word-pia"/>
  public float FirstLineIndent { get; set; }

  /// <summary>
  /// The line spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.linespacing?view=word-pia"/>
  public float LineSpacing { get; set; }

  /// <summary>
  /// The line spacing rule.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.linespacingrule?view=word-pia"/>
  public WdLineSpacing LineSpacingRule { get; set; }

  /// <summary>
  /// The space before.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spacebefore?view=word-pia"/>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// The space after.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// The hyphenation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.hyphenation?view=word-pia"/>
  public int Hyphenation { get; set; }

  /// <summary>
  /// The widow control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.widowcontrol?view=word-pia"/>
  public int WidowControl { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The far east line break control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.fareastlinebreakcontrol?view=word-pia"/>
  public int FarEastLineBreakControl { get; set; }

  /// <summary>
  /// The word wrap.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// The hanging punctuation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.hangingpunctuation?view=word-pia"/>
  public int HangingPunctuation { get; set; }

  /// <summary>
  /// The half width punctuation on top of line.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.halfwidthpunctuationontopofline?view=word-pia"/>
  public int HalfWidthPunctuationOnTopOfLine { get; set; }

  /// <summary>
  /// The add space between far east and alpha.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.addspacebetweenfareastandalpha?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndAlpha { get; set; }

  /// <summary>
  /// The add space between far east and digit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.addspacebetweenfareastanddigit?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndDigit { get; set; }

  /// <summary>
  /// The base line alignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.baselinealignment?view=word-pia"/>
  public WdBaselineAlignment BaseLineAlignment { get; set; }

  /// <summary>
  /// The auto adjust right indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.autoadjustrightindent?view=word-pia"/>
  public int AutoAdjustRightIndent { get; set; }

  /// <summary>
  /// The disable line height grid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.disablelineheightgrid?view=word-pia"/>
  public int DisableLineHeightGrid { get; set; }

  /// <summary>
  /// The outline level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.outlinelevel?view=word-pia"/>
  public WdOutlineLevel OutlineLevel { get; set; }

  /// <summary>
  /// The character unit right indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.characterunitrightindent?view=word-pia"/>
  public float CharacterUnitRightIndent { get; set; }

  /// <summary>
  /// The character unit left indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.characterunitleftindent?view=word-pia"/>
  public float CharacterUnitLeftIndent { get; set; }

  /// <summary>
  /// The character unit first line indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.characterunitfirstlineindent?view=word-pia"/>
  public float CharacterUnitFirstLineIndent { get; set; }

  /// <summary>
  /// The line unit before.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.lineunitbefore?view=word-pia"/>
  public float LineUnitBefore { get; set; }

  /// <summary>
  /// The line unit after.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.lineunitafter?view=word-pia"/>
  public float LineUnitAfter { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.readingorder?view=word-pia"/>
  public WdReadingOrder ReadingOrder { get; set; }

  /// <summary>
  /// The space before auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spacebeforeauto?view=word-pia"/>
  public int SpaceBeforeAuto { get; set; }

  /// <summary>
  /// The space after auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spaceafterauto?view=word-pia"/>
  public int SpaceAfterAuto { get; set; }
}
