namespace DocumentModel.Interop.Core;

/// <summary>
/// Used only with charts; represents fill formatting for chart elements.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat?view=office-pia"/>
public interface IChartFillFormat
{


  #region methods

/// <summary>
  /// Applies a one-color gradient fill.
  /// </summary>
  /// <param name="style">The `Style` parameter.</param>
  /// <param name="variant">The `Variant` parameter.</param>
  /// <param name="degree">The `Degree` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.onecolorgradient?view=office-pia"/>
  public void OneColorGradient(int style, int variant, float degree);
  /// <summary>
  /// Applies a two-color gradient fill.
  /// </summary>
  /// <param name="style">The `Style` parameter.</param>
  /// <param name="variant">The `Variant` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.twocolorgradient?view=office-pia"/>
  public void TwoColorGradient(int style, int variant);
  /// <summary>
  /// Applies a preset texture fill.
  /// </summary>
  /// <param name="presetTexture">The `PresetTexture` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.presettextured?view=office-pia"/>
  public void PresetTextured(int presetTexture);
  /// <summary>
  /// Applies a solid fill.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.solid?view=office-pia"/>
  public void Solid();
  /// <summary>
  /// Applies a patterned fill.
  /// </summary>
  /// <param name="pattern">The `Pattern` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.patterned?view=office-pia"/>
  public void Patterned(int pattern);
  /// <summary>
  /// Uses a custom picture as the fill.
  /// </summary>
  /// <param name="pictureFile">The `PictureFile` parameter.</param>
  /// <param name="pictureFormat">The `PictureFormat` parameter.</param>
  /// <param name="pictureStackUnit">The `PictureStackUnit` parameter.</param>
  /// <param name="picturePlacement">The `PicturePlacement` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.userpicture?view=office-pia"/>
  public void UserPicture(object pictureFile, object pictureFormat, object pictureStackUnit, object picturePlacement);
  /// <summary>
  /// Uses a custom texture file as the fill.
  /// </summary>
  /// <param name="textureFile">The `TextureFile` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.usertextured?view=office-pia"/>
  public void UserTextured(string textureFile);
  /// <summary>
  /// Applies a preset gradient fill.
  /// </summary>
  /// <param name="style">The `Style` parameter.</param>
  /// <param name="variant">The `Variant` parameter.</param>
  /// <param name="presetGradientType">The `PresetGradientType` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.chartfillformat.presetgradient?view=office-pia"/>
  public void PresetGradient(int style, int variant, int presetGradientType);

  #endregion methods
}

