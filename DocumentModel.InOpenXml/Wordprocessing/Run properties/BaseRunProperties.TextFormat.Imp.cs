namespace DocumentModel.Wordprocessing;

/// <summary>
/// Contains font attributes (font name, font size, color, and so on) for an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.font?view=word-pia"/>
public partial class BaseRunProperties<T> : ITextFormat
{

  /// <summary>
  /// The name of the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.name?view=word-pia"/>
  string? ITextFormat.Name { get; set; }

  /// <summary>
  /// The name of the font for East Asian scripts.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.namefareast?view=word-pia"/>
  string? ITextFormat.NameFarEast { get; set; }

  /// <summary>
  /// The name of the font for used for Latin text (characters with character codes from 0 (zero) through 127).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.nameascii?view=word-pia"/>
  string? ITextFormat.NameAscii { get; set; }

  /// <summary>
  /// The name of the font for characters with character codes from 128 through 255.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.nameother?view=word-pia"/>
  string? ITextFormat.NameOther { get; set; }

  /// <summary>
  /// The font size in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.size?view=word-pia"/>
  float? ITextFormat.FontSize
  {
    get => (float?)this.FontSize?.ToPoints();
    set => this.FontSize = value;
  }


  /// <summary>
  /// The font size in points for complex script.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.sizebi?view=word-pia"/>
  float? ITextFormat.FontSizeCS
  {
    get => (float?)this.FontSizeCS?.ToPoints();
    set => this.FontSizeCS = value;
  }

  /// <summary>
  /// True if the text is formatted as bold.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.bold?view=word-pia"/>
  OnOffToggle? ITextFormat.Bold
  {
    get => this.Bold.ToOnOffToggle();
    set => this.Bold = value.ToBoolean();
  }


  /// <summary>
  /// True if the text is formatted as bold for complex script.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.boldbi?view=word-pia"/>
  OnOffToggle? ITextFormat.BoldCS
  {
    get => this.BoldCS.ToOnOffToggle();
    set => this.BoldCS = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as italic.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.italic?view=word-pia"/>
  OnOffToggle? ITextFormat.Italic
  {
    get => this.Italic.ToOnOffToggle();
    set => this.Italic = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as italic for complex script.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.italicbi?view=word-pia"/>
  OnOffToggle? ITextFormat.ItalicCS
  {
    get => this.ItalicCS.ToOnOffToggle();
    set => this.ItalicCS = value.ToBoolean(); 
  }

  /// <summary>
  /// True if the text is formatted as hidden.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.hidden?view=word-pia"/>
  OnOffToggle? ITextFormat.Hidden
  {
    get => this.Hidden.ToOnOffToggle();
    set => this.Hidden = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as small capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.smallcaps?view=word-pia"/>
  OnOffToggle? ITextFormat.SmallCaps
  {
    get => this.SmallCaps.ToOnOffToggle();
    set => this.SmallCaps = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as all capital letters.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.allcaps?view=word-pia"/>
  OnOffToggle? ITextFormat.AllCaps
  {
    get => this.AllCaps.ToOnOffToggle();
    set => this.AllCaps = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.strikethrough?view=word-pia"/>
  OnOffToggle? ITextFormat.StrikeThrough
  {
    get => this.Strike.ToOnOffToggle();
    set => this.Strike = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as double strike-through.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.doublestrikethrough?view=word-pia"/>
  OnOffToggle? ITextFormat.DoubleStrikeThrough
  {
    get => this.DoubleStrike.ToOnOffToggle();
    set => this.DoubleStrike = value.ToBoolean();
  }

  /// <summary>
  /// Gets or sets the color index for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.colorindex?view=word-pia"/>
  ColorIndex? ITextFormat.ColorIndex
  {
    get => (this.Color is null) ? null : (ColorIndex?)ColorIndexTools.ToColorIndex(this.Color);
    set => this.Color = value.ToHexColor();
  }

  /// <summary>
  /// True if the text is formatted as subscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.subscript?view=word-pia"/>
  OnOffToggle? ITextFormat.Subscript
  {
    get => this.Subscript.ToOnOffToggle();
    set => this.Subscript = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as superscript.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.superscript?view=word-pia"/>
  OnOffToggle? ITextFormat.Superscript
  {
    get => this.Superscript.ToOnOffToggle();
    set => this.Superscript = value.ToBoolean();
  }

  /// <summary>
  /// Gets or sets the underline style for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.underline?view=word-pia"/>
  UnderlineType? ITextFormat.Underline
  {
    get => this.Underline?.Type;
    set => this.Underline = (value != null) ? new Underline { Type = value.Value } : null;
  }

  /// <summary>
  /// The position of text (in points) relative to the baseline. A positive number raises the text, and a negative number lowers it.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.position?view=word-pia"/>
  int? ITextFormat.Position
  {
    get => (this.Position is null) ? null : (int?)System.Math.Round(this.Position.ToPoints());
    set => this.Position = value;
  }

  /// <summary>
  /// The spacing (in points) between characters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.spacing?view=word-pia"/>
  float? ITextFormat.Spacing
  {
    get => (float?)this.Spacing?.ToPoints();
    set => this.Spacing = value;
  }

  /// <summary>
  /// The scaling percentage applied to the font. This property stretches or compresses text horizontally as a percentage of the current size (the scaling range is from 1 through 600).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.scaling?view=word-pia"/>
  int? ITextFormat.Scaling
  {
    get => this.CharacterScale; 
    set => this.CharacterScale = value;
  }

  /// <summary>
  /// True if the specified font is formatted as shadowed. Can be True, False, or Undefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.shadow?view=word-pia"/>
  OnOff? ITextFormat.Shadow
  {
    get => this.Shadow.ToOnOff(); 
    set => this.Shadow = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as outlined.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.outline?view=word-pia"/>
  OnOffToggle? ITextFormat.Outline
  {
    get => this.Outline.ToOnOffToggle(); 
    set => this.Outline = value.ToBoolean();
  }

  /// <summary>
  /// True if the text is formatted as embossed.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.emboss?view=word-pia"/>
  OnOffToggle? ITextFormat.Emboss
  {
    get => this.Emboss.ToOnOffToggle(); 
    set => this.Emboss = value.ToBoolean();
  }

  /// <summary>
  /// The minimum font size for which kerning should be applied automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.kerning?view=word-pia"/>
  float? ITextFormat.Kerning
  {
    get => (float?)this.Kern?.ToPoints();
    set => this.Kern = value;
  }

  /// <summary>
  /// True if the text is formatted as engraved.
  /// Returns True, False, or Undefined.
  /// Can be set to True, False, or Toggle (reverses the current setting).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.engrave?view=word-pia"/>
  OnOffToggle? ITextFormat.Engrave
  {
    get => this.Imprint.ToOnOffToggle();
    set => this.Imprint = value.ToBoolean();
  }

  /// <summary>
  /// Gets or sets the animation effect for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.animation?view=word-pia"/>
  Animation? ITextFormat.Animation { get; set; }

  /// <summary>
  /// Gets or sets the border formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.borders?view=word-pia"/>
  IBorders? ITextFormat.Borders { get; set; }

  /// <summary>
  /// Gets or sets the emphasis mark for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.emphasismark?view=word-pia"/>
  EmphasisMark? ITextFormat.EmphasisMark
  {
    get => this.Emphasis;
    set => this.Emphasis = value;
  }

  /// <summary>
  /// Gets or sets a value indicating whether to disable character spacing on the document grid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.disablecharacterspacegrid?view=word-pia"/>
  bool? ITextFormat.DisableCharacterSpaceGrid
  {
    get => !this.SnapToGrid;
    set => this.SnapToGrid = !value;
  }

  /// <summary>
  /// The 24-bit color for the specified TextFormat object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.color?view=word-pia"/>
  IColor? ITextFormat.Color
  {
    get => this.Color;
    set => this.Color = value?.RGB;
  }



  /// <summary>
  /// The name of the font for complex script.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.namebi?view=word-pia"/>
  string? ITextFormat.NameCS { get; set; }

  /// <summary>
  /// Gets or sets the color index for complex-script text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.colorindexbi?view=word-pia"/>
  ColorIndex? ITextFormat.ColorIndexCS { get; set; }

  /// <summary>
  /// Gets or sets the color of diacritical marks.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.diacriticcolor?view=word-pia"/>
  IColor? ITextFormat.DiacriticColor { get; set; }

  /// <summary>
  /// Gets or sets the underline color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.underlinecolor?view=word-pia"/>
  IColor? ITextFormat.UnderlineColor { get; set; }


  /// <summary>
  /// Gets or sets the shading formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.shading?view=word-pia"/>
  DMD.IShading? ITextFormat.Shading { get; set; }

  /// <summary>
  /// Gets or sets the glow formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.glow?view=word-pia"/>
  DMD.IGlowFormat? ITextFormat.Glow { get; set; }

  /// <summary>
  /// Gets or sets the reflection formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.reflection?view=word-pia"/>
  DMD.IReflectionFormat? ITextFormat.Reflection { get; set; }

  /// <summary>
  /// Gets or sets the shadow formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.textshadow?view=word-pia"/>
  DMD.IShadowFormat? ITextFormat.TextShadow { get; set; }

  /// <summary>
  /// Gets or sets the fill formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.fill?view=word-pia"/>
  DMD.IFillFormat? ITextFormat.Fill { get; set; }

  /// <summary>
  /// Gets or sets the line formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.line?view=word-pia"/>
  DMD.ILineFormat? ITextFormat.Line { get; set; }

  /// <summary>
  /// Gets or sets the 3D formatting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.threed?view=word-pia"/>
  DMD.IThreeDFormat? ITextFormat.ThreeD { get; set; }

  /// <summary>
  /// Gets or sets the text color formatting.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.textcolor?view=word-pia"/>
  DMD.IColorFormat? ITextFormat.TextColor { get; set; }

  /// <summary>
  /// Gets or sets the ligature setting for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.ligatures?view=word-pia"/>
  Ligatures? ITextFormat.Ligatures { get; set; }

  /// <summary>
  /// Gets or sets the number form for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.numberform?view=word-pia"/>
  NumberForm? ITextFormat.NumberForm { get; set; }

  /// <summary>
  /// Gets or sets the number spacing for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.numberspacing?view=word-pia"/>
  NumberSpacing? ITextFormat.NumberSpacing { get; set; }

  /// <summary>
  /// Gets or sets whether contextual alternates are enabled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.contextualalternates?view=word-pia"/>
  int? ITextFormat.ContextualAlternates { get; set; }

  /// <summary>
  /// Gets or sets the stylistic set for the font.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.stylisticset?view=word-pia"/>
  StylisticSet? ITextFormat.StylisticSet { get; set; }

}
