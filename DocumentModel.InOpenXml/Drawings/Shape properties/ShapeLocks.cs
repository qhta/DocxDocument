namespace DocumentModel.Drawings;

/// <summary>
///   Represents locking options for a shape, restricting user actions such as grouping, selection, rotation, resizing, and editing.
/// </summary>
public class ShapeLocks : ModelElement<DXD.ShapeLocks>, IExtendableElement
{
  /// <summary>
  ///   Disallows grouping of the shape.
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallows selection of the shape.
  /// </summary>
  public bool? NoSelection { get; set; }

  /// <summary>
  ///   Disallows rotation of the shape.
  /// </summary>
  public bool? NoRotation { get; set; }

  /// <summary>
  ///   Disallows changing the aspect ratio of the shape.
  /// </summary>
  public bool? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallows moving the shape.
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallows resizing the shape.
  /// </summary>
  public bool? NoResize { get; set; }

  /// <summary>
  ///   Disallows editing the points of the shape.
  /// </summary>
  public bool? NoEditPoints { get; set; }

  /// <summary>
  ///   Disallows showing adjustment handles on the shape.
  /// </summary>
  public bool? NoAdjustHandles { get; set; }

  /// <summary>
  ///   Disallows changing arrowheads on the shape.
  /// </summary>
  public bool? NoChangeArrowheads { get; set; }

  /// <summary>
  ///   Disallows changing the shape type.
  /// </summary>
  public bool? NoChangeShapeType { get; set; }

  /// <summary>
  ///   Disallows editing the shape's text.
  /// </summary>
  public bool? NoTextEdit { get; set; }

  public IExtensionList? ExtensionList { get; set; }
}