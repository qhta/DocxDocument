namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains properties and methods that apply to pictures and OLE objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat?view=word-pia"/>
public partial interface PictureFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the brightness.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.brightness?view=word-pia"/>
  public float Brightness { get; set; }

  /// <summary>
  /// Returns or sets the color type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.colortype?view=word-pia"/>
  public Core.MsoPictureColorType ColorType { get; set; }

  /// <summary>
  /// Returns or sets the contrast.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.contrast?view=word-pia"/>
  public float Contrast { get; set; }

  /// <summary>
  /// Returns or sets the crop bottom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropbottom?view=word-pia"/>
  public float CropBottom { get; set; }

  /// <summary>
  /// Returns or sets the crop left.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropleft?view=word-pia"/>
  public float CropLeft { get; set; }

  /// <summary>
  /// Returns or sets the crop right.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropright?view=word-pia"/>
  public float CropRight { get; set; }

  /// <summary>
  /// Returns or sets the crop top.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.croptop?view=word-pia"/>
  public float CropTop { get; set; }

  /// <summary>
  /// Returns or sets the transparency color.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.transparencycolor?view=word-pia"/>
  public int TransparencyColor { get; set; }

  /// <summary>
  /// Returns or sets whether transparent background.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.transparentbackground?view=word-pia"/>
  public Core.MsoTriState TransparentBackground { get; set; }

  /// <summary>
  /// Returns or sets the crop.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.crop?view=word-pia"/>
  public Core.Crop Crop { get; set; }
}
