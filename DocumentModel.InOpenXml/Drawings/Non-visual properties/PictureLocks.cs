namespace DocumentModel.Drawings;

/// <summary>
///   Represents locking options for a picture, restricting user actions such as grouping, selection, rotation, resizing, cropping, and editing.
/// </summary>
public class PictureLocks : ModelElement<DXD.PictureLocks>, IExtendableElement
{
  /// <summary>
  ///   Disallows grouping of the picture.
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallows selection of the picture.
  /// </summary>
  public bool? NoSelection { get; set; }

  /// <summary>
  ///   Disallows rotation of the picture.
  /// </summary>
  public bool? NoRotation { get; set; }

  /// <summary>
  ///   Disallows changing the aspect ratio of the picture.
  /// </summary>
  public bool? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallows moving the picture.
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallows resizing the picture.
  /// </summary>
  public bool? NoResize { get; set; }

  /// <summary>
  ///   Disallows editing the points of the picture.
  /// </summary>
  public bool? NoEditPoints { get; set; }

  /// <summary>
  ///   Disallows showing adjustment handles on the picture.
  /// </summary>
  public bool? NoAdjustHandles { get; set; }

  /// <summary>
  ///   Disallows changing arrowheads on the picture.
  /// </summary>
  public bool? NoChangeArrowheads { get; set; }

  /// <summary>
  ///   Disallows changing the picture type.
  /// </summary>
  public bool? NoChangeShapeType { get; set; }

  /// <summary>
  ///   Disallows cropping the picture.
  /// </summary>
  public bool? NoCrop { get; set; }

  public IExtensionList? ExtensionList { get; set; }
}