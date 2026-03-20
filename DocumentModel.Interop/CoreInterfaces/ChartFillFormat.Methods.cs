
namespace DocumentModel.Interop.Core;

/// <summary>
/// Used only with charts; represents fill formatting for chart elements.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat?view=office-pia
/// </remarks>
public partial interface ChartFillFormat
{
  /// <summary>
  /// Applies a one-color gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <param name="Degree">The `Degree` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.onecolorgradient?view=office-pia
  /// </remarks>
  public void OneColorGradient(int Style, int Variant, float Degree);
  /// <summary>
  /// Applies a two-color gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.twocolorgradient?view=office-pia
  /// </remarks>
  public void TwoColorGradient(int Style, int Variant);
  /// <summary>
  /// Applies a preset texture fill.
  /// </summary>
  /// <param name="PresetTexture">The `PresetTexture` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.presettextured?view=office-pia
  /// </remarks>
  public void PresetTextured(int PresetTexture);
  /// <summary>
  /// Applies a solid fill.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.solid?view=office-pia
  /// </remarks>
  public void Solid();
  /// <summary>
  /// Applies a patterned fill.
  /// </summary>
  /// <param name="Pattern">The `Pattern` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.patterned?view=office-pia
  /// </remarks>
  public void Patterned(int Pattern);
  /// <summary>
  /// Uses a custom picture as the fill.
  /// </summary>
  /// <param name="PictureFile">The `PictureFile` parameter.</param>
  /// <param name="PictureFormat">The `PictureFormat` parameter.</param>
  /// <param name="PictureStackUnit">The `PictureStackUnit` parameter.</param>
  /// <param name="PicturePlacement">The `PicturePlacement` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.userpicture?view=office-pia
  /// </remarks>
  public void UserPicture(object PictureFile, object PictureFormat, object PictureStackUnit, object PicturePlacement);
  /// <summary>
  /// Uses a custom texture file as the fill.
  /// </summary>
  /// <param name="TextureFile">The `TextureFile` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.usertextured?view=office-pia
  /// </remarks>
  public void UserTextured(string TextureFile);
  /// <summary>
  /// Applies a preset gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <param name="PresetGradientType">The `PresetGradientType` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.presetgradient?view=office-pia
  /// </remarks>
  public void PresetGradient(int Style, int Variant, int PresetGradientType);
}
