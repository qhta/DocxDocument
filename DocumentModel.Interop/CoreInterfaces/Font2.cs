
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains font attributes for an object, such as name, size, style, and color.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2?view=office-pia
/// </remarks>
public partial interface Font2: InteropObject
{
  /// <summary>
  /// Gets or sets the `Bold` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.bold?view=office-pia
  /// </remarks>
  public MsoTriState Bold { get; set; }
  /// <summary>
  /// Gets or sets the `Italic` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.italic?view=office-pia
  /// </remarks>
  public MsoTriState Italic { get; set; }
  /// <summary>
  /// Gets or sets the `Strike` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.strike?view=office-pia
  /// </remarks>
  public MsoTextStrike Strike { get; set; }
  /// <summary>
  /// Gets or sets the `Caps` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.caps?view=office-pia
  /// </remarks>
  public MsoTextCaps Caps { get; set; }
  /// <summary>
  /// Gets or sets the `AutorotateNumbers` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.autorotatenumbers?view=office-pia
  /// </remarks>
  public MsoTriState AutorotateNumbers { get; set; }
  /// <summary>
  /// Gets or sets the `BaselineOffset` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.baselineoffset?view=office-pia
  /// </remarks>
  public float BaselineOffset { get; set; }
  /// <summary>
  /// Gets or sets the `Kerning` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.kerning?view=office-pia
  /// </remarks>
  public float Kerning { get; set; }
  /// <summary>
  /// Gets or sets the `Size` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.size?view=office-pia
  /// </remarks>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the `Spacing` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.spacing?view=office-pia
  /// </remarks>
  public float Spacing { get; set; }
  /// <summary>
  /// Gets or sets the `UnderlineStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.underlinestyle?view=office-pia
  /// </remarks>
  public MsoTextUnderlineType UnderlineStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Allcaps` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.allcaps?view=office-pia
  /// </remarks>
  public MsoTriState Allcaps { get; set; }
  /// <summary>
  /// Gets or sets the `DoubleStrikeThrough` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.doublestrikethrough?view=office-pia
  /// </remarks>
  public MsoTriState DoubleStrikeThrough { get; set; }
  /// <summary>
  /// Gets or sets the `Equalize` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.equalize?view=office-pia
  /// </remarks>
  public MsoTriState Equalize { get; set; }
  /// <summary>
  /// Gets the `Fill` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.fill?view=office-pia
  /// </remarks>
  public FillFormat Fill { get; }
  /// <summary>
  /// Gets the `Glow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.glow?view=office-pia
  /// </remarks>
  public GlowFormat Glow { get; }
  /// <summary>
  /// Gets the `Reflection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.reflection?view=office-pia
  /// </remarks>
  public ReflectionFormat Reflection { get; }
  /// <summary>
  /// Gets the `Line` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.line?view=office-pia
  /// </remarks>
  public LineFormat Line { get; }
  /// <summary>
  /// Gets the `Shadow` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.shadow?view=office-pia
  /// </remarks>
  public ShadowFormat Shadow { get; }
  /// <summary>
  /// Gets the `Highlight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.highlight?view=office-pia
  /// </remarks>
  public ColorFormat Highlight { get; }
  /// <summary>
  /// Gets the `UnderlineColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.underlinecolor?view=office-pia
  /// </remarks>
  public ColorFormat UnderlineColor { get; }
  /// <summary>
  /// Gets or sets the `Smallcaps` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.smallcaps?view=office-pia
  /// </remarks>
  public MsoTriState Smallcaps { get; set; }
  /// <summary>
  /// Gets or sets the `SoftEdgeFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.softedgeformat?view=office-pia
  /// </remarks>
  public MsoSoftEdgeType SoftEdgeFormat { get; set; }
  /// <summary>
  /// Gets or sets the `StrikeThrough` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.strikethrough?view=office-pia
  /// </remarks>
  public MsoTriState StrikeThrough { get; set; }
  /// <summary>
  /// Gets or sets the `Subscript` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.subscript?view=office-pia
  /// </remarks>
  public MsoTriState Subscript { get; set; }
  /// <summary>
  /// Gets or sets the `Superscript` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.superscript?view=office-pia
  /// </remarks>
  public MsoTriState Superscript { get; set; }
  /// <summary>
  /// Gets or sets the `WordArtformat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.wordartformat?view=office-pia
  /// </remarks>
  public MsoPresetTextEffect WordArtformat { get; set; }
  /// <summary>
  /// Gets the `Embeddable` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.embeddable?view=office-pia
  /// </remarks>
  public MsoTriState Embeddable { get; }
  /// <summary>
  /// Gets the `Embedded` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.embedded?view=office-pia
  /// </remarks>
  public MsoTriState Embedded { get; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `NameAscii` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.nameascii?view=office-pia
  /// </remarks>
  public string NameAscii { get; set; }
  /// <summary>
  /// Gets or sets the `NameComplexScript` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.namecomplexscript?view=office-pia
  /// </remarks>
  public string NameComplexScript { get; set; }
  /// <summary>
  /// Gets or sets the `NameFarEast` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.namefareast?view=office-pia
  /// </remarks>
  public string NameFarEast { get; set; }
  /// <summary>
  /// Gets or sets the `NameOther` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.font2.nameother?view=office-pia
  /// </remarks>
  public string NameOther { get; set; }
}
