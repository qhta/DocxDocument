
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat?view=office-pia"/>
public partial interface FillFormat: InteropObject
{
  /// <summary>
  /// Sets the fill to use the background style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.background?view=office-pia"/>
  public void Background();
  /// <summary>
  /// Applies a one-color gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <param name="Degree">The `Degree` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.onecolorgradient?view=office-pia"/>
  public void OneColorGradient(MsoGradientStyle Style, int Variant, float Degree);
  /// <summary>
  /// Applies a patterned fill.
  /// </summary>
  /// <param name="Pattern">The `Pattern` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.patterned?view=office-pia"/>
  public void Patterned(MsoPatternType Pattern);
  /// <summary>
  /// Applies a preset gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <param name="PresetGradientType">The `PresetGradientType` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.presetgradient?view=office-pia"/>
  public void PresetGradient(MsoGradientStyle Style, int Variant, MsoPresetGradientType PresetGradientType);
  /// <summary>
  /// Applies a preset texture fill.
  /// </summary>
  /// <param name="PresetTexture">The `PresetTexture` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.presettextured?view=office-pia"/>
  public void PresetTextured(MsoPresetTexture PresetTexture);
  /// <summary>
  /// Applies a solid fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.solid?view=office-pia"/>
  public void Solid();
  /// <summary>
  /// Applies a two-color gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.twocolorgradient?view=office-pia"/>
  public void TwoColorGradient(MsoGradientStyle Style, int Variant);
  /// <summary>
  /// Uses a picture file as the fill source.
  /// </summary>
  /// <param name="PictureFile">The `PictureFile` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.userpicture?view=office-pia"/>
  public void UserPicture(string PictureFile);
  /// <summary>
  /// Uses a custom texture file as the fill source.
  /// </summary>
  /// <param name="TextureFile">The `TextureFile` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.fillformat.usertextured?view=office-pia"/>
  public void UserTextured(string TextureFile);
}

