namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM object, see ParagraphFormat
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat?view=word-pia"/>
public partial interface _ParagraphFormat : InteropObject
{
  /// <summary>
  /// The duplicate.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.duplicate?view=word-pia"/>
  public ParagraphFormat Duplicate { get; }

  /// <summary>
  /// The style.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// The alignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.alignment?view=word-pia"/>
  public WdParagraphAlignment Alignment { get; set; }

  /// <summary>
  /// The keep together.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.keeptogether?view=word-pia"/>
  public int KeepTogether { get; set; }

  /// <summary>
  /// The keep with next.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.keepwithnext?view=word-pia"/>
  public int KeepWithNext { get; set; }

  /// <summary>
  /// The page break before.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.pagebreakbefore?view=word-pia"/>
  public int PageBreakBefore { get; set; }

  /// <summary>
  /// The no line number.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.nolinenumber?view=word-pia"/>
  public int NoLineNumber { get; set; }

  /// <summary>
  /// The right indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.rightindent?view=word-pia"/>
  public float RightIndent { get; set; }

  /// <summary>
  /// The left indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// The first line indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.firstlineindent?view=word-pia"/>
  public float FirstLineIndent { get; set; }

  /// <summary>
  /// The line spacing.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.linespacing?view=word-pia"/>
  public float LineSpacing { get; set; }

  /// <summary>
  /// The line spacing rule.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.linespacingrule?view=word-pia"/>
  public WdLineSpacing LineSpacingRule { get; set; }

  /// <summary>
  /// The space before.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spacebefore?view=word-pia"/>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// The space after.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// The hyphenation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.hyphenation?view=word-pia"/>
  public int Hyphenation { get; set; }

  /// <summary>
  /// The widow control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.widowcontrol?view=word-pia"/>
  public int WidowControl { get; set; }

  /// <summary>
  /// The far east line break control.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.fareastlinebreakcontrol?view=word-pia"/>
  public int FarEastLineBreakControl { get; set; }

  /// <summary>
  /// The word wrap.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// The hanging punctuation.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.hangingpunctuation?view=word-pia"/>
  public int HangingPunctuation { get; set; }

  /// <summary>
  /// The half width punctuation on top of line.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.halfwidthpunctuationontopofline?view=word-pia"/>
  public int HalfWidthPunctuationOnTopOfLine { get; set; }

  /// <summary>
  /// The add space between far east and alpha.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.addspacebetweenfareastandalpha?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndAlpha { get; set; }

  /// <summary>
  /// The add space between far east and digit.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.addspacebetweenfareastanddigit?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndDigit { get; set; }

  /// <summary>
  /// The base line alignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.baselinealignment?view=word-pia"/>
  public WdBaselineAlignment BaseLineAlignment { get; set; }

  /// <summary>
  /// The auto adjust right indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.autoadjustrightindent?view=word-pia"/>
  public int AutoAdjustRightIndent { get; set; }

  /// <summary>
  /// The disable line height grid.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.disablelineheightgrid?view=word-pia"/>
  public int DisableLineHeightGrid { get; set; }

  /// <summary>
  /// The tab stops.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.tabstops?view=word-pia"/>
  public TabStops TabStops { get; set; }

  /// <summary>
  /// The borders.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// The shading.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// The outline level.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.outlinelevel?view=word-pia"/>
  public WdOutlineLevel OutlineLevel { get; set; }

  /// <summary>
  /// The character unit right indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitrightindent?view=word-pia"/>
  public float CharacterUnitRightIndent { get; set; }

  /// <summary>
  /// The character unit left indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitleftindent?view=word-pia"/>
  public float CharacterUnitLeftIndent { get; set; }

  /// <summary>
  /// The character unit first line indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitfirstlineindent?view=word-pia"/>
  public float CharacterUnitFirstLineIndent { get; set; }

  /// <summary>
  /// The line unit before.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.lineunitbefore?view=word-pia"/>
  public float LineUnitBefore { get; set; }

  /// <summary>
  /// The line unit after.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.lineunitafter?view=word-pia"/>
  public float LineUnitAfter { get; set; }

  /// <summary>
  /// The reading order.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.readingorder?view=word-pia"/>
  public WdReadingOrder ReadingOrder { get; set; }

  /// <summary>
  /// The space before auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spacebeforeauto?view=word-pia"/>
  public int SpaceBeforeAuto { get; set; }

  /// <summary>
  /// The space after auto.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spaceafterauto?view=word-pia"/>
  public int SpaceAfterAuto { get; set; }

  /// <summary>
  /// The mirror indents.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.mirrorindents?view=word-pia"/>
  public int MirrorIndents { get; set; }

  /// <summary>
  /// The textbox tight wrap.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.textboxtightwrap?view=word-pia"/>
  public WdTextboxTightWrap TextboxTightWrap { get; set; }

  /// <summary>
  /// The collapsed by default.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.collapsedbydefault?view=word-pia"/>
  public int CollapsedByDefault { get; set; }
}
