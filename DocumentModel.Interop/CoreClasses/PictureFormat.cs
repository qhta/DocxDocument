
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains properties for formatting pictures and OLE objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat?view=office-pia"/>
public partial class PictureFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Brightness` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.brightness?view=office-pia"/>
  public float Brightness { get; set; }
  /// <summary>
  /// Gets or sets the `ColorType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.colortype?view=office-pia"/>
  public PictureColorType ColorType { get; set; }
  /// <summary>
  /// Gets or sets the `Contrast` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.contrast?view=office-pia"/>
  public float Contrast { get; set; }
  /// <summary>
  /// Gets or sets the `CropBottom` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.cropbottom?view=office-pia"/>
  public float CropBottom { get; set; }
  /// <summary>
  /// Gets or sets the `CropLeft` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.cropleft?view=office-pia"/>
  public float CropLeft { get; set; }
  /// <summary>
  /// Gets or sets the `CropRight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.cropright?view=office-pia"/>
  public float CropRight { get; set; }
  /// <summary>
  /// Gets or sets the `CropTop` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.croptop?view=office-pia"/>
  public float CropTop { get; set; }
  /// <summary>
  /// Gets or sets the `TransparencyColor` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.transparencycolor?view=office-pia"/>
  public int TransparencyColor { get; set; }
  /// <summary>
  /// Gets or sets the `TransparentBackground` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.transparentbackground?view=office-pia"/>
  public TriState TransparentBackground { get; set; }
  /// <summary>
  /// Gets the `Crop` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.crop?view=office-pia"/>
  public Crop Crop { get; }
}

