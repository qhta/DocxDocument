namespace DocumentModel.Drawings;

/// <summary>
/// Represents an object used to remove a portion of an image.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop?view=office-pia"/>
public partial interface ICrop : IModelObject
{
  /// <summary>
  /// Gets or sets the `PictureOffsetX` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureoffsetx?view=office-pia"/>
  public float PictureOffsetX { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PictureOffsetY` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureoffsety?view=office-pia"/>
  public float PictureOffsetY { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PictureWidth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.picturewidth?view=office-pia"/>
  public float PictureWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PictureHeight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.pictureheight?view=office-pia"/>
  public float PictureHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ShapeLeft` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapeleft?view=office-pia"/>
  public float ShapeLeft { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ShapeTop` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapetop?view=office-pia"/>
  public float ShapeTop { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ShapeWidth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapewidth?view=office-pia"/>
  public float ShapeWidth { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ShapeHeight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.crop.shapeheight?view=office-pia"/>
  public float ShapeHeight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

