namespace DocumentModel.Interop.Word;

/// <summary>
/// Contains properties and methods that apply to pictures and OLE objects.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat?view=word-pia"/>
public partial interface PictureFormat : InteropObject
{
  /// <summary>
  /// The brightness.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.brightness?view=word-pia"/>
  public float Brightness { get; set; }

  /// <summary>
  /// The color type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.colortype?view=word-pia"/>
  public Core.MsoPictureColorType ColorType { get; set; }

  /// <summary>
  /// The contrast.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.contrast?view=word-pia"/>
  public float Contrast { get; set; }

  /// <summary>
  /// The crop bottom.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropbottom?view=word-pia"/>
  public float CropBottom { get; set; }

  /// <summary>
  /// The crop left.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropleft?view=word-pia"/>
  public float CropLeft { get; set; }

  /// <summary>
  /// The crop right.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.cropright?view=word-pia"/>
  public float CropRight { get; set; }

  /// <summary>
  /// The crop top.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.croptop?view=word-pia"/>
  public float CropTop { get; set; }

  /// <summary>
  /// The transparency color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.transparencycolor?view=word-pia"/>
  public int TransparencyColor { get; set; }

  /// <summary>
  /// The transparent background.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.transparentbackground?view=word-pia"/>
  public Core.MsoTriState TransparentBackground { get; set; }

  /// <summary>
  /// The crop.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pictureformat.crop?view=word-pia"/>
  public Core.Crop Crop { get; set; }
}
