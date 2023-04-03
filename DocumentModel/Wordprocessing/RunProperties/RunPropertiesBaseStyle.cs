namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Base class for all RunProperties classes.
///   Contains common properties
/// </summary>
public class RunPropertiesBaseStyle: ModelElement
{
    #region Common run properties
  /// <summary>
  ///   Specifies the fonts which shall be used to display the text contents of this run. 
  ///   Within a single run, there can be up to four types of font slot which shall each be allowed to use a unique font: 
  ///   <list type="bullet">
  ///     <item>
  ///       ASCII (i.e., the first 128 Unicode code points) 
  ///     </item>
  ///     <item>
  ///       High ANSI 
  ///     </item>
  ///     <item>
  ///       Complex Script 
  ///     </item>
  ///     <item>
  ///       East Asian 
  ///     </item>
  ///   </list>
  /// </summary>
  public RunFonts? RunFonts { get; set; }

  /// <summary>
  ///   Specifies whether the bold property shall be applied to characters in the contents of this run when displayed in a document.
  ///   There can be two toggle properties:
  ///   <list type="bullet">
  ///     <item>
  ///       first applied to regular script,
  ///     </item>
  ///     <item>
  ///       second applied to complex script.
  ///     </item>
  ///   </list>
  /// </summary>
  public DualBoolean? Bold { get; set; }

  /// <summary>
  ///   Specifies whether the italic property shall be applied to characters in the contents of this run when displayed in a document.
  ///   There can be two toggle properties:
  ///   <list type="bullet">
  ///     <item>
  ///       first applied to regular script,
  ///     </item>
  ///     <item>
  ///       second applied to complex script,
  ///     </item>
  ///   </list>
  /// </summary>
  public DualBoolean? Italic { get; set; }


  /// <summary>
  ///   Specifies the size of font in the contents of this run when displayed in a document.
  ///   There can be two int properties (measured in half points):
  ///   <list type="bullet">
  ///     <item>
  ///       first applied to regular script,
  ///     </item>
  ///     <item>
  ///       second applied to complex script,
  ///     </item>
  ///   </list>
  /// </summary>
  public DualHPS? FontSize { get; set; }

  /// <summary>
  ///   Specifies that any lowercase characters in this text run 
  ///   shall be formatted for display only as their capital letter character equivalents. 
  ///   This property does not affect any non-alphabetic character in this run, 
  ///   and does not change the Unicode character for lowercase text, only the method in which it is displayed.
  /// </summary>
  public Boolean? Caps { get; set; }

  /// <summary>
  ///   Element specifies that all small letter characters in this text run 
  ///   shall be formatted for display only as their capital letter character equivalents 
  ///   in a font size two points smaller than the actual font size specified for this text. 
  ///   This property does not affect any non-alphabetic character in this run, 
  ///   and does not change the Unicode character for lowercase text, only the method in which it is displayed. 
  ///   If this font cannot be made two point smaller than the current size, 
  ///   then it shall be displayed as the smallest possible font size in capital letters.
  /// </summary>
  public Boolean? SmallCaps { get; set; }


  /// <summary>
  ///   Specifies that the contents of this run should be displayed along with an underline 
  ///   appearing directly below the character height (less all spacing above and below the characters on the line).
  /// </summary>
  public Underline? Underline { get; set; }

  /// <summary>
  ///   Specifies that the contents of this run shall be displayed with a single horizontal line through the center of the line. 
  /// </summary>
  public Boolean? Strike { get; set; }

  /// <summary>
  ///   Specifies that the contents of this run shall be displayed with two horizontal lines through each character displayed on the line.
  /// </summary>
  public Boolean? DoubleStrike { get; set; }

  /// <summary>
  ///   Specifies the color which shall be used to display the contents of this run in the document. 
  ///   This color can be explicitly specified, or set to allow the consumer to automatically choose 
  ///   an appropriate color based on the background color behind the run's content. 
  /// </summary>
  public Color? Color { get; set; }

  /// <summary>
  ///   Specifies the amount of character pitch which shall be added or removed after each character in this run 
  ///   before the following character is rendered in the document. This property has an effect equivalent 
  ///   to the additional character pitched added by a document grid applied to the contents of a run. 
  /// </summary>
  public Twips? Spacing { get; set; }

  /// <summary>
  ///   Specifies the amount by which each character shall be expanded or when the character is rendered in the document. 
  ///   This property has an of stretching or compressing each character in the run, as opposed to the spacing element 
  ///   which expands/compresses the text by adding additional character pitch but not changing the width of the actual characters 
  ///   displayed on the line.
  /// </summary>
  public Percent? CharacterScale { get; set; }

  /// <summary>
  ///   specifies whether font kerning shall be applied to the contents of this run. 
  ///   If it is specified, then kerning shall be automatically adjusted when displaying characters in this run as needed. 
  ///   The Value specifies the smallest font size which shall have its kerning automatically adjusted if this setting is specified. 
  ///   If the font size in the sz element (§17.3.2.38) is smaller than this value, then no font kerning shall be performed. 
  /// </summary>
  public HalfPoints? Kern { get; set; }

  /// <summary>
  ///   Specifies whether the current run should use the document grid characters per line settings defined in the docGrid element 
  ///   when laying out the contents in this run. This setting determines whether the additional character pitch 
  ///   specified in the document grid shall be added to each character in this run as specified by the document grid.
  /// </summary>
  public Boolean? SnapToGrid { get; set; }

  /// <summary>
  ///   Specifies the alignment which shall be applied to the contents of this run 
  ///   in relation to the default appearance of the run's text. 
  ///   This allows the text to be repositioned as subscript or superscript without altering the font size of the run properties.
  /// </summary>
  public VerticalPositionKind? VerticalTextAlignment { get; set; }

  /// <summary>
  ///   Specifies the amount by which text shall be raised or lowered for this run 
  ///   in relation to the default baseline of the surrounding non-positioned text. 
  ///   This allows the text to be repositioned without altering the font size of the contents. 
  ///   If the valuee is positive, then the parent run shall be raised above the baseline 
  ///   of the surrounding text by the specified number of half-points. 
  ///   If the value is negative, then the parent run shall be lowered below the baseline 
  ///   of the surrounding text by the specified number of half-points. 
  /// </summary>
  public HalfPoints? Position { get; set; }

  /// <summary>
  ///   Specifies that the contents of this run should be displayed as if they have an outline, 
  ///   by drawing a one pixel wide border around the inside and outside borders of each character glyph in the run..
  /// </summary>
  public Boolean? Outline { get; set; }

  /// <summary>
  ///   Specifies that the contents of this run should be displayed as if embossed, 
  ///   which makes text appear as if it is raised off the page in relief.
  /// </summary>
  public Boolean? Emboss { get; set; }

  /// <summary>
  ///   specifies that the contents of this run should be displayed as if imprinted, 
  ///   which makes text appear to be imprinted or pressed into page (also referred to as 'engrave').
  /// </summary>
  public Boolean? Imprint { get; set; }

  /// <summary>
  ///   Specifies that the contents of this run shall be displayed as if each character has a shadow. 
  ///   For left-to-right text, the shadow is beneath the text and to its right; 
  ///   for right-to-left text, the shadow is beneath the text and to its left..
  /// </summary>
  public Boolean? Shadow { get; set; }

  /// <summary>
  ///   Specifies the languages which shall be used to check spelling and grammar (if requested) when processing the contents of this run.
  ///   There can be up to three values:
  ///   <list type="bullet">
  ///     <item>
  ///       first applied to regular script,
  ///     </item>
  ///     <item>
  ///       second applied to complex script,
  ///     </item>
  ///     <item>
  ///       third applied to east asian script.
  ///     </item>
  ///   </list>
  /// </summary>
  public Languages? Language { get; set; }

  /// <summary>
  ///   Specifies that the contents of this run shall not report any errors when the document is scanned for spelling and grammar.
  /// </summary>
  public Boolean? NoProof { get; set; }

  /// <summary>
  ///   Like paragraph shading, this element specifies the shading applied to the contents of the run.
  ///   This shading consists of three components:
  ///   <list type="bullet">
  ///     <item>
  ///       Background Color 
  ///     </item>
  ///     <item>
  ///       (optional) Pattern
  ///     </item>
  ///       (optional) Pattern Color
  ///     <item>
  ///     </item>
  ///   </list>
  ///   The resulting shading is applied by setting the background color behind the paragraph, 
  ///   then applying the pattern color using the mask supplied by the pattern over that background.
  /// </summary>
  public Shading? Shading { get; set; }

  /// <summary>
  ///   Specifies information about the border applied to the text in the current run. 
  ///   The first piece of information specified by the bdr element is that the current shall have a border when displayed. 
  ///   This information is specified simply by the presence of the bdr element in run's properties. 
  ///  The second piece of information concerns the set of runs which share the current run border. 
  ///  This is determined based on the attributes on the bdr element. 
  ///  If the set of attribute values specifies on two adjacent runs is identical, 
  ///  then those two runs shall be considered to be part of the same run border group and rendered 
  ///  within the same set of borders in the document.
  /// </summary>
  public Border? Border { get; set; }

  /// <summary>
  ///   Specifies an animated text effect which should be displayed when rendering the contents of this run. 
  ///   This effect is rendered around the extents of the text in the run in the same location as a run border with zero pixels of padding would be rendered (if such a run border was present).
  /// </summary>
  public TextEffectKind? TextEffect { get; set; }

  /// <summary>
  ///   Specifies that the contents of this run shall not be automatically displayed based on the width of its contents, 
  ///   rather its contents shall be resized to fit the width specified by the value. 
  ///   This expansion/contraction shall be performed by equally increasing/decreasing the size of each character 
  ///   in this run's contents when displayed.
  /// </summary>
  public FitText? FitText { get; set; }

  /// <summary>
  ///   Specifies the emphasis mark that shall be applied to each non-space character in this run. 
  ///   An emphasis mark is an additional character whose display position relative to the character 
  ///   to which it is applied is language- and writing-direction-dependent. 
  /// </summary>
  public EmphasisMarkKind? Emphasis { get; set; }

  /// <summary>
  ///   specifies any East Asian typography settings which shall be applied to the contents of the run. 
  ///   The specific typography settings represented by this element include the two lines in one and horizontal in vertical text options. 
  ///   The two lines in one setting specifies that the characters in this run should be written out on a single line in the document 
  ///   by creating two sub-lines within the regular line, and laying out this text equally between those sub lines. .
  /// </summary>
  public EastAsianLayout? EastAsianLayout { get; set; }

  /// <summary>
  ///   Specifies whether the contents of this run shall be hidden from display at display time in a document. 
  ///   The setting should affect the normal display of text, but an application can have settings to force hidden text to be displayed.
  /// </summary>
  public Boolean? Vanish { get; set; }

  /// <summary>
  ///   Specifies that the given run shall always behave as if it is hidden, 
  ///   even when hidden text is being  displayed in the current document. 
  ///   This property shall only be used to specify that a paragraph mark 
  ///   shall never be used to break the end of a paragraph for display, 
  ///   even if it is being shown on the document, as would be the case 
  ///   if a regularly hidden paragraph was not being displayed in the document. 
  ///   This property was typically used to ensure that a paragraph style 
  ///   can be applied to a part of a paragraph, and still appear as in the Table of Contents 
  ///   which in previous word processors would ignore the use of the style if it were being used as a character style. 
  ///   If this element is applied to any other run, it can be ignored.
  /// </summary>
  public Boolean? SpecVanish { get; set; }

  /// <summary>
  ///   Specifies whether the contents of this run shall be hidden from display 
  ///   at display time in a document when the document is being displayed in a web page view. 
  ///   The setting should affect the normal display of text in a web page view, 
  ///   but an application can have settings to force hidden text to be displayed.
  /// </summary>
  public Boolean? WebHidden { get; set; }
  #endregion

}