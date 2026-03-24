
namespace DocumentModel.Interfaces;

/// <summary>
/// Contains font attributes for an object, such as name, size, style, and color.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2?view=office-pia"/>
public partial interface Font2: InteropObject
{
  /// <summary>
  /// Gets or sets the `Bold` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.bold?view=office-pia"/>
  public MsoTriState Bold { get; set; }
  /// <summary>
  /// Gets or sets the `Italic` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.italic?view=office-pia"/>
  public MsoTriState Italic { get; set; }
  /// <summary>
  /// Gets or sets the `Strike` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.strike?view=office-pia"/>
  public MsoTextStrike Strike { get; set; }
  /// <summary>
  /// Gets or sets the `Caps` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.caps?view=office-pia"/>
  public MsoTextCaps Caps { get; set; }
  /// <summary>
  /// Gets or sets the `AutorotateNumbers` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.autorotatenumbers?view=office-pia"/>
  public MsoTriState AutorotateNumbers { get; set; }
  /// <summary>
  /// Gets or sets the `BaselineOffset` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.baselineoffset?view=office-pia"/>
  public float BaselineOffset { get; set; }
  /// <summary>
  /// Gets or sets the `Kerning` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.kerning?view=office-pia"/>
  public float Kerning { get; set; }
  /// <summary>
  /// Gets or sets the `Size` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.size?view=office-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the `Spacing` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.spacing?view=office-pia"/>
  public float Spacing { get; set; }
  /// <summary>
  /// Gets or sets the `UnderlineStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.underlinestyle?view=office-pia"/>
  public MsoTextUnderlineType UnderlineStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Allcaps` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.allcaps?view=office-pia"/>
  public MsoTriState Allcaps { get; set; }
  /// <summary>
  /// Gets or sets the `DoubleStrikeThrough` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.doublestrikethrough?view=office-pia"/>
  public MsoTriState DoubleStrikeThrough { get; set; }
  /// <summary>
  /// Gets or sets the `Equalize` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.equalize?view=office-pia"/>
  public MsoTriState Equalize { get; set; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.fill?view=office-pia"/>
  public FillFormat Fill { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.glow?view=office-pia"/>
  public GlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Reflection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.reflection?view=office-pia"/>
  public ReflectionFormat Reflection { get; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.line?view=office-pia"/>
  public LineFormat Line { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.shadow?view=office-pia"/>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `Highlight` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.highlight?view=office-pia"/>
  public ColorFormat Highlight { get; }
  /// <summary>
  /// Gets the `UnderlineColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.underlinecolor?view=office-pia"/>
  public ColorFormat UnderlineColor { get; }
  /// <summary>
  /// Gets or sets the `Smallcaps` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.smallcaps?view=office-pia"/>
  public MsoTriState Smallcaps { get; set; }
  /// <summary>
  /// Gets or sets the `SoftEdgeFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.softedgeformat?view=office-pia"/>
  public MsoSoftEdgeType SoftEdgeFormat { get; set; }
  /// <summary>
  /// Gets or sets the `StrikeThrough` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.strikethrough?view=office-pia"/>
  public MsoTriState StrikeThrough { get; set; }
  /// <summary>
  /// Gets or sets the `Subscript` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.subscript?view=office-pia"/>
  public MsoTriState Subscript { get; set; }
  /// <summary>
  /// Gets or sets the `Superscript` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.superscript?view=office-pia"/>
  public MsoTriState Superscript { get; set; }
  /// <summary>
  /// Gets or sets the `WordArtformat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.wordartformat?view=office-pia"/>
  public MsoPresetTextEffect WordArtformat { get; set; }
  /// <summary>
  /// Gets the `Embeddable` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.embeddable?view=office-pia"/>
  public MsoTriState Embeddable { get; }
  /// <summary>
  /// Gets the `Embedded` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.embedded?view=office-pia"/>
  public MsoTriState Embedded { get; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `NameAscii` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.nameascii?view=office-pia"/>
  public string NameAscii { get; set; }
  /// <summary>
  /// Gets or sets the `NameComplexScript` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.namecomplexscript?view=office-pia"/>
  public string NameComplexScript { get; set; }
  /// <summary>
  /// Gets or sets the `NameFarEast` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.namefareast?view=office-pia"/>
  public string NameFarEast { get; set; }
  /// <summary>
  /// Gets or sets the `NameOther` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.nameother?view=office-pia"/>
  public string NameOther { get; set; }
}

