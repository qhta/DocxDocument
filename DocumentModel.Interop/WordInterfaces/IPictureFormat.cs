namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains properties and methods that apply to pictures and OLE objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat?view=word-pia"/>
public partial interface IPictureFormat : IInteropObject
{
  /// <summary>
  /// Returns or sets the brightness of the specified picture or OLE object. The value for this property must be a
  /// number from 0.0 (dimmest) to 1.0 (brightest).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.brightness?view=word-pia"/>
  public float Brightness { get; set; }

  /// <summary>
  /// Returns or sets the type of color transformation applied to the specified picture or OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.colortype?view=word-pia"/>
  public Core.PictureColorType ColorType { get; set; }

  /// <summary>
  /// Returns or sets the contrast for the specified picture or OLE object. The value for this property must be a
  /// number from 0.0 (the least contrast) to 1.0 (the greatest contrast).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.contrast?view=word-pia"/>
  public float Contrast { get; set; }

  /// <summary>
  /// Returns or sets the number of points that are cropped off the bottom of the specified picture or OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropbottom?view=word-pia"/>
  public float CropBottom { get; set; }

  /// <summary>
  /// Returns or sets the number of points that are cropped off the left side of the specified picture or OLE
  /// object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropleft?view=word-pia"/>
  public float CropLeft { get; set; }

  /// <summary>
  /// Returns or sets the number of points that are cropped off the right side of the specified picture or OLE
  /// object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropright?view=word-pia"/>
  public float CropRight { get; set; }

  /// <summary>
  /// Returns or sets the number of points that are cropped off the top of the specified picture or OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.croptop?view=word-pia"/>
  public float CropTop { get; set; }

  /// <summary>
  /// Returns or sets the transparent color for the specified picture as a red-green-blue (RGB) value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.transparencycolor?view=word-pia"/>
  public int TransparencyColor { get; set; }

  /// <summary>
  /// MsoTrue if the parts of the picture that are defined with a transparent color actually appear transparent.
  /// Applies to bitmaps only.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.transparentbackground?view=word-pia"/>
  public Core.TriState TransparentBackground { get; set; }

  /// <summary>
  /// Gets or sets a Crop object that represents an image cropping.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.crop?view=word-pia"/>
  public Core.Crop Crop { get; set; }


  #region methods

/// <summary>
  /// Increases the current brightness level by the specified amount.
  /// </summary>
  /// <param name="Increment">The amount by which to increase the brightness. Must be a positive value.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.incrementbrightness?view=word-pia"/>
  public void IncrementBrightness(float Increment);

  #endregion methods
}
