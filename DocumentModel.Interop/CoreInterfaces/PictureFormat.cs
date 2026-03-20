
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PictureFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PictureFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Brightness` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.brightness?view=office-pia
  /// </remarks>
  public float Brightness { get; set; }
  /// <summary>
  /// Gets or sets the `ColorType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.colortype?view=office-pia
  /// </remarks>
  public MsoPictureColorType ColorType { get; set; }
  /// <summary>
  /// Gets or sets the `Contrast` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.contrast?view=office-pia
  /// </remarks>
  public float Contrast { get; set; }
  /// <summary>
  /// Gets or sets the `CropBottom` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.cropbottom?view=office-pia
  /// </remarks>
  public float CropBottom { get; set; }
  /// <summary>
  /// Gets or sets the `CropLeft` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.cropleft?view=office-pia
  /// </remarks>
  public float CropLeft { get; set; }
  /// <summary>
  /// Gets or sets the `CropRight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.cropright?view=office-pia
  /// </remarks>
  public float CropRight { get; set; }
  /// <summary>
  /// Gets or sets the `CropTop` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.croptop?view=office-pia
  /// </remarks>
  public float CropTop { get; set; }
  /// <summary>
  /// Gets or sets the `TransparencyColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.transparencycolor?view=office-pia
  /// </remarks>
  public int TransparencyColor { get; set; }
  /// <summary>
  /// Gets or sets the `TransparentBackground` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.transparentbackground?view=office-pia
  /// </remarks>
  public MsoTriState TransparentBackground { get; set; }
  /// <summary>
  /// Gets the `Crop` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.crop?view=office-pia
  /// </remarks>
  public Crop Crop { get; }
}
