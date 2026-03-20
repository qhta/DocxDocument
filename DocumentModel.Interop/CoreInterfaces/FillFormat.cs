
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat?view=office-pia
/// </remarks>
public partial interface FillFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `BackColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.backcolor?view=office-pia
  /// </remarks>
  public ColorFormat BackColor { get; set; }
  /// <summary>
  /// Gets or sets the `ForeColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.forecolor?view=office-pia
  /// </remarks>
  public ColorFormat ForeColor { get; set; }
  /// <summary>
  /// Gets the `GradientColorType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientcolortype?view=office-pia
  /// </remarks>
  public MsoGradientColorType GradientColorType { get; }
  /// <summary>
  /// Gets the `GradientDegree` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientdegree?view=office-pia
  /// </remarks>
  public float GradientDegree { get; }
  /// <summary>
  /// Gets the `GradientStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientstyle?view=office-pia
  /// </remarks>
  public MsoGradientStyle GradientStyle { get; }
  /// <summary>
  /// Gets the `GradientVariant` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientvariant?view=office-pia
  /// </remarks>
  public int GradientVariant { get; }
  /// <summary>
  /// Gets the `Pattern` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.pattern?view=office-pia
  /// </remarks>
  public MsoPatternType Pattern { get; }
  /// <summary>
  /// Gets the `PresetGradientType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.presetgradienttype?view=office-pia
  /// </remarks>
  public MsoPresetGradientType PresetGradientType { get; }
  /// <summary>
  /// Gets the `PresetTexture` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.presettexture?view=office-pia
  /// </remarks>
  public MsoPresetTexture PresetTexture { get; }
  /// <summary>
  /// Gets the `TextureName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturename?view=office-pia
  /// </remarks>
  public string TextureName { get; }
  /// <summary>
  /// Gets the `TextureType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturetype?view=office-pia
  /// </remarks>
  public MsoTextureType TextureType { get; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.transparency?view=office-pia
  /// </remarks>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.type?view=office-pia
  /// </remarks>
  public MsoFillType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.visible?view=office-pia
  /// </remarks>
  public MsoTriState Visible { get; set; }
  /// <summary>
  /// Gets the `GradientStops` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientstops?view=office-pia
  /// </remarks>
  public GradientStops GradientStops { get; }
  /// <summary>
  /// Gets or sets the `TextureOffsetX` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.textureoffsetx?view=office-pia
  /// </remarks>
  public float TextureOffsetX { get; set; }
  /// <summary>
  /// Gets or sets the `TextureOffsetY` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.textureoffsety?view=office-pia
  /// </remarks>
  public float TextureOffsetY { get; set; }
  /// <summary>
  /// Gets or sets the `TextureAlignment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturealignment?view=office-pia
  /// </remarks>
  public MsoTextureAlignment TextureAlignment { get; set; }
  /// <summary>
  /// Gets or sets the `TextureHorizontalScale` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturehorizontalscale?view=office-pia
  /// </remarks>
  public float TextureHorizontalScale { get; set; }
  /// <summary>
  /// Gets or sets the `TextureVerticalScale` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.textureverticalscale?view=office-pia
  /// </remarks>
  public float TextureVerticalScale { get; set; }
  /// <summary>
  /// Gets or sets the `TextureTile` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.texturetile?view=office-pia
  /// </remarks>
  public MsoTriState TextureTile { get; set; }
  /// <summary>
  /// Gets or sets the `RotateWithObject` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.rotatewithobject?view=office-pia
  /// </remarks>
  public MsoTriState RotateWithObject { get; set; }
  /// <summary>
  /// Gets the `PictureEffects` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.pictureeffects?view=office-pia
  /// </remarks>
  public PictureEffects PictureEffects { get; }
  /// <summary>
  /// Gets or sets the `GradientAngle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.gradientangle?view=office-pia
  /// </remarks>
  public float GradientAngle { get; set; }
}
