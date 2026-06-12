namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents all the formatting for a paragraph.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.paragraphformat?view=word-pia"/>
public partial interface IParagraphFormat
{

  /// <summary>
  /// Gets a duplicate of the paragraph formatting.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.duplicate?view=word-pia"/>
  public IParagraphFormat Duplicate { get; }

  /// <summary>
  /// Gets or sets the style for the paragraph format.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.style?view=word-pia"/>
  public object Style { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the paragraph alignment.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.alignment?view=word-pia"/>
  public ParagraphAlignment Alignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether all lines in the paragraph stay on the same page.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.keeptogether?view=word-pia"/>
  public int KeepTogether { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether the paragraph stays on the same page as the following paragraph.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.keepwithnext?view=word-pia"/>
  public int KeepWithNext { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether a page break is inserted before the paragraph.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.pagebreakbefore?view=word-pia"/>
  public int PageBreakBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether line numbering is suppressed for the paragraph.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.nolinenumber?view=word-pia"/>
  public int NoLineNumber { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the right indent value, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.rightindent?view=word-pia"/>
  public float RightIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the left indent value, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.leftindent?view=word-pia"/>
  public float LeftIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the first-line indent value, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.firstlineindent?view=word-pia"/>
  public float FirstLineIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the line spacing, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.linespacing?view=word-pia"/>
  public float LineSpacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the line spacing rule.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.linespacingrule?view=word-pia"/>
  public LineSpacing LineSpacingRule { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the spacing before the paragraph, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spacebefore?view=word-pia"/>
  public float SpaceBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the spacing after the paragraph, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spaceafter?view=word-pia"/>
  public float SpaceAfter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether automatic hyphenation is enabled for the paragraph.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.hyphenation?view=word-pia"/>
  public int Hyphenation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether widow and orphan control is enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.widowcontrol?view=word-pia"/>
  public int WidowControl { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether Far East line-break control is enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.fareastlinebreakcontrol?view=word-pia"/>
  public int FarEastLineBreakControl { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether word wrapping is enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.wordwrap?view=word-pia"/>
  public int WordWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether hanging punctuation is enabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.hangingpunctuation?view=word-pia"/>
  public int HangingPunctuation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether half-width punctuation can hang at line ends.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.halfwidthpunctuationontopofline?view=word-pia"/>
  public int HalfWidthPunctuationOnTopOfLine { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing is added between Far East and Latin text.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.addspacebetweenfareastandalpha?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndAlpha { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing is added between Far East text and digits.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.addspacebetweenfareastanddigit?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndDigit { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the baseline alignment.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.baselinealignment?view=word-pia"/>
  public BaselineAlignment BaseLineAlignment { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether the right indent is adjusted automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.autoadjustrightindent?view=word-pia"/>
  public int AutoAdjustRightIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether line-height grid adjustment is disabled.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.disablelineheightgrid?view=word-pia"/>
  public int DisableLineHeightGrid { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the tab stops.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.tabstops?view=word-pia"/>
  public ITabStops TabStops { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the border formatting for the paragraph.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets the shading formatting for the paragraph.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }

  /// <summary>
  /// Gets or sets the outline level.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.outlinelevel?view=word-pia"/>
  public OutlineLevel OutlineLevel { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the right indent in character units.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitrightindent?view=word-pia"/>
  public float CharacterUnitRightIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the left indent in character units.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitleftindent?view=word-pia"/>
  public float CharacterUnitLeftIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the first-line indent in character units.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitfirstlineindent?view=word-pia"/>
  public float CharacterUnitFirstLineIndent { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the spacing before the paragraph in line units.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.lineunitbefore?view=word-pia"/>
  public float LineUnitBefore { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the spacing after the paragraph in line units.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.lineunitafter?view=word-pia"/>
  public float LineUnitAfter { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the reading order for the paragraph.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.readingorder?view=word-pia"/>
  public ReadingOrder ReadingOrder { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing before is adjusted automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spacebeforeauto?view=word-pia"/>
  public int SpaceBeforeAuto { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing after is adjusted automatically.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spaceafterauto?view=word-pia"/>
  public int SpaceAfterAuto { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether indents are mirrored for facing pages.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.mirrorindents?view=word-pia"/>
  public int MirrorIndents { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets the text box tight-wrap setting.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.textboxtightwrap?view=word-pia"/>
  public TextBoxTightWrap TextboxTightWrap { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Gets or sets a value indicating whether the paragraph is collapsed by default.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.collapsedbydefault?view=word-pia"/>
  public int CollapsedByDefault { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}
