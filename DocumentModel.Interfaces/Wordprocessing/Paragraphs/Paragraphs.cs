using DocumentModel.Wordprocessing;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Paragraph objects in a selection, range, or document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs?view=word-pia"/>
public partial interface IParagraphs : IModelCollection<IParagraph>
{
  /// <summary>
  /// Returns a Paragraph object that represents the first item in the Paragraphs collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.first?view=word-pia"/>
  public IParagraph First { get; }

  /// <summary>
  /// Returns the last item in the Paragraphs collection as a Paragraph object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.last?view=word-pia"/>
  public IParagraph Last { get; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the formatting of the specified paragraph or
  /// paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.format?view=word-pia"/>
  public IParagraphFormat Format { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a TabStops collection that represents all the custom tab stops for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.tabstops?view=word-pia"/>
  public ITabStops TabStops { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Borders collection that represents all the borders for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the style for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.style?view=word-pia"/>
  public object Style { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a ParagraphAlignment constant that represents the alignment for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.alignment?view=word-pia"/>
  public ParagraphAlignment Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if all lines in the specified paragraphs remain on the same page when Microsoft Word repaginates
  /// the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.keeptogether?view=word-pia"/>
  public int KeepTogether { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the specified paragraph remains on the same page as the paragraph that follows it when Microsoft
  /// Word repaginates the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.keepwithnext?view=word-pia"/>
  public int KeepWithNext { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if a page break is forced before the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.pagebreakbefore?view=word-pia"/>
  public int PageBreakBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if line numbers are repressed for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.nolinenumber?view=word-pia"/>
  public int NoLineNumber { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the right indent (in points) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.rightindent?view=word-pia"/>
  public float RightIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a Single that represents the left indent value (in points) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.leftindent?view=word-pia"/>
  public float LeftIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the value (in points) for a first line or hanging indent.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.firstlineindent?view=word-pia"/>
  public float FirstLineIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the line spacing (in points) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.linespacing?view=word-pia"/>
  public float LineSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the line spacing for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.linespacingrule?view=word-pia"/>
  public LineSpacing LineSpacingRule { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the spacing (in points) before the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spacebefore?view=word-pia"/>
  public float SpaceBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of spacing (in points) after the specified paragraph or text column.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spaceafter?view=word-pia"/>
  public float SpaceAfter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the specified paragraphs are included in automatic hyphenation.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.hyphenation?view=word-pia"/>
  public int Hyphenation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if the first and last lines in the specified paragraph remain on the same page as the rest of the
  /// paragraph when Microsoft Word repaginates the document.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.widowcontrol?view=word-pia"/>
  public int WidowControl { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns a Shading object that refers to the shading formatting for the specified object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Determines if Microsoft Word applies East Asian line-breaking rules to the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.fareastlinebreakcontrol?view=word-pia"/>
  public int FarEastLineBreakControl { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word wraps Latin text in the middle of a word in the specified paragraphs or text
  /// frames.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.wordwrap?view=word-pia"/>
  public int WordWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if hanging punctuation is enabled for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.hangingpunctuation?view=word-pia"/>
  public int HangingPunctuation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a ParagraphFormat object that represents the formatting of the specified paragraph or
  /// paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.halfwidthpunctuationontopofline?view=word-pia"/>
  public int HalfWidthPunctuationOnTopOfLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word is set to automatically add spaces between Japanese and Latin text for the
  /// specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.addspacebetweenfareastandalpha?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndAlpha { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word is set to automatically add spaces between Japanese and Latin text for the
  /// specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.addspacebetweenfareastanddigit?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndDigit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets a BaselineAlignment constant that represents the vertical position of fonts on a line.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.baselinealignment?view=word-pia"/>
  public BaselineAlignment BaseLineAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word is set to automatically adjust the right indent for the specified paragraphs if
  /// you’ve specified a set number of characters per line.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.autoadjustrightindent?view=word-pia"/>
  public int AutoAdjustRightIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word aligns characters in the specified paragraphs to the line grid when a set number
  /// of lines per page is specified.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.disablelineheightgrid?view=word-pia"/>
  public int DisableLineHeightGrid { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the outline level for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.outlinelevel?view=word-pia"/>
  public OutlineLevel OutlineLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the right indent value (in characters) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.characterunitrightindent?view=word-pia"/>
  public float CharacterUnitRightIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the left indent value (in characters) for the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.characterunitleftindent?view=word-pia"/>
  public float CharacterUnitLeftIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the value (in characters) for a first-line or hanging indent.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.characterunitfirstlineindent?view=word-pia"/>
  public float CharacterUnitFirstLineIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of spacing (in gridlines) before the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.lineunitbefore?view=word-pia"/>
  public float LineUnitBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the amount of spacing (in gridlines) after the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.lineunitafter?view=word-pia"/>
  public float LineUnitAfter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the reading order of the specified paragraphs without changing their alignment.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.readingorder?view=word-pia"/>
  public ReadingOrder ReadingOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word automatically sets the amount of spacing before the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spacebeforeauto?view=word-pia"/>
  public int SpaceBeforeAuto { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Determines if Microsoft Word automatically sets the amount of spacing after the specified paragraphs.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphs.spaceafterauto?view=word-pia"/>
  public int SpaceAfterAuto { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
