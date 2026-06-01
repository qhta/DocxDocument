using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents an object used to remove a portion of an image.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop?view=office-pia"/>
public partial class Crop: InteropObject
{
  /// <summary>
  /// Gets or sets the `PictureOffsetX` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureoffsetx?view=office-pia"/>
  public float PictureOffsetX { get; set; }
  /// <summary>
  /// Gets or sets the `PictureOffsetY` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureoffsety?view=office-pia"/>
  public float PictureOffsetY { get; set; }
  /// <summary>
  /// Gets or sets the `PictureWidth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.picturewidth?view=office-pia"/>
  public float PictureWidth { get; set; }
  /// <summary>
  /// Gets or sets the `PictureHeight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureheight?view=office-pia"/>
  public float PictureHeight { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeLeft` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapeleft?view=office-pia"/>
  public float ShapeLeft { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeTop` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapetop?view=office-pia"/>
  public float ShapeTop { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeWidth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapewidth?view=office-pia"/>
  public float ShapeWidth { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeHeight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapeheight?view=office-pia"/>
  public float ShapeHeight { get; set; }
}

