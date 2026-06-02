
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat?view=office-pia"/>
public partial interface IFillFormat: IInteropObject
{
  /// <summary>
  /// Gets or sets the `BackColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.backcolor?view=office-pia"/>
  public ColorFormat BackColor { get; set; }
  /// <summary>
  /// Gets or sets the `ForeColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.forecolor?view=office-pia"/>
  public ColorFormat ForeColor { get; set; }
  /// <summary>
  /// Gets the `GradientColorType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientcolortype?view=office-pia"/>
  public GradientColorType GradientColorType { get; }
  /// <summary>
  /// Gets the `GradientDegree` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientdegree?view=office-pia"/>
  public float GradientDegree { get; }
  /// <summary>
  /// Gets the `GradientStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientstyle?view=office-pia"/>
  public GradientStyle GradientStyle { get; }
  /// <summary>
  /// Gets the `GradientVariant` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientvariant?view=office-pia"/>
  public int GradientVariant { get; }
  /// <summary>
  /// Gets the `Pattern` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.pattern?view=office-pia"/>
  public PatternType Pattern { get; }
  /// <summary>
  /// Gets the `PresetGradientType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.presetgradienttype?view=office-pia"/>
  public PresetGradientType PresetGradientType { get; }
  /// <summary>
  /// Gets the `PresetTexture` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.presettexture?view=office-pia"/>
  public PresetTexture PresetTexture { get; }
  /// <summary>
  /// Gets the `TextureName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturename?view=office-pia"/>
  public string TextureName { get; }
  /// <summary>
  /// Gets the `TextureType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturetype?view=office-pia"/>
  public TextureType TextureType { get; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.transparency?view=office-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.type?view=office-pia"/>
  public FillType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.visible?view=office-pia"/>
  public TriState Visible { get; set; }
  /// <summary>
  /// Gets the `GradientStops` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientstops?view=office-pia"/>
  public GradientStops GradientStops { get; }
  /// <summary>
  /// Gets or sets the `TextureOffsetX` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.textureoffsetx?view=office-pia"/>
  public float TextureOffsetX { get; set; }
  /// <summary>
  /// Gets or sets the `TextureOffsetY` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.textureoffsety?view=office-pia"/>
  public float TextureOffsetY { get; set; }
  /// <summary>
  /// Gets or sets the `TextureAlignment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturealignment?view=office-pia"/>
  public TextureAlignment TextureAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `TextureHorizontalScale` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturehorizontalscale?view=office-pia"/>
  public float TextureHorizontalScale { get; set; }
  /// <summary>
  /// Gets or sets the `TextureVerticalScale` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.textureverticalscale?view=office-pia"/>
  public float TextureVerticalScale { get; set; }
  /// <summary>
  /// Gets or sets the `TextureTile` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturetile?view=office-pia"/>
  public TriState TextureTile { get; set; }
  /// <summary>
  /// Gets or sets the `RotateWithObject` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.rotatewithobject?view=office-pia"/>
  public TriState RotateWithObject { get; set; }
  /// <summary>
  /// Gets the `PictureEffects` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.pictureeffects?view=office-pia"/>
  public PictureEffects PictureEffects { get; }
  /// <summary>
  /// Gets or sets the `GradientAngle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientangle?view=office-pia"/>
  public float GradientAngle { get; set; }
}

