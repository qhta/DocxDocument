
namespace DocumentModel.Interop.Core;

/// <summary>
/// Used only with charts; represents fill formatting for chart elements.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat?view=office-pia"/>
public partial class ChartFillFormat
{
  /// <summary>
  /// Applies a one-color gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <param name="Degree">The `Degree` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.onecolorgradient?view=office-pia"/>
  public void OneColorGradient(int Style, int Variant, float Degree) { throw new NotImplementedException(); }
  /// <summary>
  /// Applies a two-color gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.twocolorgradient?view=office-pia"/>
  public void TwoColorGradient(int Style, int Variant) { throw new NotImplementedException(); }
  /// <summary>
  /// Applies a preset texture fill.
  /// </summary>
  /// <param name="PresetTexture">The `PresetTexture` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.presettextured?view=office-pia"/>
  public void PresetTextured(int PresetTexture) { throw new NotImplementedException(); }
  /// <summary>
  /// Applies a solid fill.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.solid?view=office-pia"/>
  public void Solid() { throw new NotImplementedException(); }
  /// <summary>
  /// Applies a patterned fill.
  /// </summary>
  /// <param name="Pattern">The `Pattern` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.patterned?view=office-pia"/>
  public void Patterned(int Pattern) { throw new NotImplementedException(); }
  /// <summary>
  /// Uses a custom picture as the fill.
  /// </summary>
  /// <param name="PictureFile">The `PictureFile` parameter.</param>
  /// <param name="PictureFormat">The `PictureFormat` parameter.</param>
  /// <param name="PictureStackUnit">The `PictureStackUnit` parameter.</param>
  /// <param name="PicturePlacement">The `PicturePlacement` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.userpicture?view=office-pia"/>
  public void UserPicture(object PictureFile, object PictureFormat, object PictureStackUnit, object PicturePlacement) { throw new NotImplementedException(); }
  /// <summary>
  /// Uses a custom texture file as the fill.
  /// </summary>
  /// <param name="TextureFile">The `TextureFile` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.usertextured?view=office-pia"/>
  public void UserTextured(string TextureFile) { throw new NotImplementedException(); }
  /// <summary>
  /// Applies a preset gradient fill.
  /// </summary>
  /// <param name="Style">The `Style` parameter.</param>
  /// <param name="Variant">The `Variant` parameter.</param>
  /// <param name="PresetGradientType">The `PresetGradientType` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.presetgradient?view=office-pia"/>
  public void PresetGradient(int Style, int Variant, int PresetGradientType) { throw new NotImplementedException(); }
}

