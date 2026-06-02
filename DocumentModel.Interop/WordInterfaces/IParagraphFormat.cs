namespace DocumentModel.Interop.Word;

/// <summary>
/// This is a primary interface in a COM coclass that is required by managed code for interoperability with the corresponding COM object. Use this primary interface only when the method you want to use shares the same name as an event of the COM object; in this case, cast to this interface to call the method, and cast to the latest events interface to connect to the event. Otherwise, use the .NET interface that is derived from the COM coclass to access methods, properties, and events of the COM object. For more information about the COM object, see ParagraphFormat.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat?view=word-pia"/>
public partial interface IParagraphFormat : IInteropObject
{
  /// <summary>
  /// Gets a duplicate of the paragraph formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.duplicate?view=word-pia"/>
  public ParagraphFormat Duplicate { get; }

  /// <summary>
  /// Gets or sets the style for the paragraph format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.style?view=word-pia"/>
  public object Style { get; set; }

  /// <summary>
  /// Gets or sets the paragraph alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.alignment?view=word-pia"/>
  public ParagraphAlignment Alignment { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether all lines in the paragraph stay on the same page.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.keeptogether?view=word-pia"/>
  public int KeepTogether { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the paragraph stays on the same page as the following paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.keepwithnext?view=word-pia"/>
  public int KeepWithNext { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether a page break is inserted before the paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.pagebreakbefore?view=word-pia"/>
  public int PageBreakBefore { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether line numbering is suppressed for the paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.nolinenumber?view=word-pia"/>
  public int NoLineNumber { get; set; }

  /// <summary>
  /// Gets or sets the right indent value, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.rightindent?view=word-pia"/>
  public float RightIndent { get; set; }

  /// <summary>
  /// Gets or sets the left indent value, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.leftindent?view=word-pia"/>
  public float LeftIndent { get; set; }

  /// <summary>
  /// Gets or sets the first-line indent value, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.firstlineindent?view=word-pia"/>
  public float FirstLineIndent { get; set; }

  /// <summary>
  /// Gets or sets the line spacing, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.linespacing?view=word-pia"/>
  public float LineSpacing { get; set; }

  /// <summary>
  /// Gets or sets the line spacing rule.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.linespacingrule?view=word-pia"/>
  public LineSpacing LineSpacingRule { get; set; }

  /// <summary>
  /// Gets or sets the spacing before the paragraph, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spacebefore?view=word-pia"/>
  public float SpaceBefore { get; set; }

  /// <summary>
  /// Gets or sets the spacing after the paragraph, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether automatic hyphenation is enabled for the paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.hyphenation?view=word-pia"/>
  public int Hyphenation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether widow and orphan control is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.widowcontrol?view=word-pia"/>
  public int WidowControl { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether Far East line-break control is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.fareastlinebreakcontrol?view=word-pia"/>
  public int FarEastLineBreakControl { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether word wrapping is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.wordwrap?view=word-pia"/>
  public int WordWrap { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether hanging punctuation is enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.hangingpunctuation?view=word-pia"/>
  public int HangingPunctuation { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether half-width punctuation can hang at line ends.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.halfwidthpunctuationontopofline?view=word-pia"/>
  public int HalfWidthPunctuationOnTopOfLine { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing is added between Far East and Latin text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.addspacebetweenfareastandalpha?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndAlpha { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing is added between Far East text and digits.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.addspacebetweenfareastanddigit?view=word-pia"/>
  public int AddSpaceBetweenFarEastAndDigit { get; set; }

  /// <summary>
  /// Gets or sets the baseline alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.baselinealignment?view=word-pia"/>
  public BaselineAlignment BaseLineAlignment { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the right indent is adjusted automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.autoadjustrightindent?view=word-pia"/>
  public int AutoAdjustRightIndent { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether line-height grid adjustment is disabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.disablelineheightgrid?view=word-pia"/>
  public int DisableLineHeightGrid { get; set; }

  /// <summary>
  /// Gets or sets the tab stops.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.tabstops?view=word-pia"/>
  public TabStops TabStops { get; set; }

  /// <summary>
  /// Gets or sets the border formatting for the paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.borders?view=word-pia"/>
  public Borders Borders { get; set; }

  /// <summary>
  /// Gets the shading formatting for the paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.shading?view=word-pia"/>
  public Shading Shading { get; }

  /// <summary>
  /// Gets or sets the outline level.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.outlinelevel?view=word-pia"/>
  public OutlineLevel OutlineLevel { get; set; }

  /// <summary>
  /// Gets or sets the right indent in character units.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitrightindent?view=word-pia"/>
  public float CharacterUnitRightIndent { get; set; }

  /// <summary>
  /// Gets or sets the left indent in character units.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitleftindent?view=word-pia"/>
  public float CharacterUnitLeftIndent { get; set; }

  /// <summary>
  /// Gets or sets the first-line indent in character units.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.characterunitfirstlineindent?view=word-pia"/>
  public float CharacterUnitFirstLineIndent { get; set; }

  /// <summary>
  /// Gets or sets the spacing before the paragraph in line units.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.lineunitbefore?view=word-pia"/>
  public float LineUnitBefore { get; set; }

  /// <summary>
  /// Gets or sets the spacing after the paragraph in line units.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.lineunitafter?view=word-pia"/>
  public float LineUnitAfter { get; set; }

  /// <summary>
  /// Gets or sets the reading order for the paragraph.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.readingorder?view=word-pia"/>
  public ReadingOrder ReadingOrder { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing before is adjusted automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spacebeforeauto?view=word-pia"/>
  public int SpaceBeforeAuto { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether spacing after is adjusted automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.spaceafterauto?view=word-pia"/>
  public int SpaceAfterAuto { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether indents are mirrored for facing pages.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.mirrorindents?view=word-pia"/>
  public int MirrorIndents { get; set; }

  /// <summary>
  /// Gets or sets the text box tight-wrap setting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.textboxtightwrap?view=word-pia"/>
  public TextboxTightWrap TextboxTightWrap { get; set; }

  /// <summary>
  /// Gets or sets a value indicating whether the paragraph is collapsed by default.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.collapsedbydefault?view=word-pia"/>
  public int CollapsedByDefault { get; set; }


  #region methods

/// <summary>
  /// Removes any spacing before the specified paragraphs.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._paragraphformat.closeup?view=word-pia"/>
  public void CloseUp();

  #endregion methods
}
