using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents an object used to remove a portion of an image.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop?view=office-pia
/// </remarks>
public partial interface Crop: InteropObject
{
  /// <summary>
  /// Gets or sets the `PictureOffsetX` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureoffsetx?view=office-pia
  /// </remarks>
  public float PictureOffsetX { get; set; }
  /// <summary>
  /// Gets or sets the `PictureOffsetY` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureoffsety?view=office-pia
  /// </remarks>
  public float PictureOffsetY { get; set; }
  /// <summary>
  /// Gets or sets the `PictureWidth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.picturewidth?view=office-pia
  /// </remarks>
  public float PictureWidth { get; set; }
  /// <summary>
  /// Gets or sets the `PictureHeight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureheight?view=office-pia
  /// </remarks>
  public float PictureHeight { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeLeft` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapeleft?view=office-pia
  /// </remarks>
  public float ShapeLeft { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeTop` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapetop?view=office-pia
  /// </remarks>
  public float ShapeTop { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeWidth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapewidth?view=office-pia
  /// </remarks>
  public float ShapeWidth { get; set; }
  /// <summary>
  /// Gets or sets the `ShapeHeight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapeheight?view=office-pia
  /// </remarks>
  public float ShapeHeight { get; set; }
}
