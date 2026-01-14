namespace DocumentModel.Drawings;

/// <summary>
///   Represents the set of locks that can be applied to a content part in a drawing.
///   These locks restrict certain user actions such as grouping, selection, rotation, and resizing.
/// </summary>
public interface ContentPartLocks : OfficeArtExtendableElement
{
  /// <summary>
  ///   Disallows grouping of the content part.
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallows selection of the content part.
  /// </summary>
  public bool? NoSelection { get; set; }

  /// <summary>
  ///   Disallows rotation of the content part.
  /// </summary>
  public bool? NoRotation { get; set; }

  /// <summary>
  ///   Disallows changing the aspect ratio of the content part.
  /// </summary>
  public bool? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallows moving the content part.
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallows resizing the content part.
  /// </summary>
  public bool? NoResize { get; set; }

  /// <summary>
  ///   Disallows editing the points of the content part.
  /// </summary>
  public bool? NoEditPoints { get; set; }

  /// <summary>
  ///   Disallows showing adjustment handles on the content part.
  /// </summary>
  public bool? NoAdjustHandles { get; set; }

  /// <summary>
  ///   Disallows changing arrowheads on the content part.
  /// </summary>
  public bool? NoChangeArrowheads { get; set; }

  /// <summary>
  ///   Disallows changing the shape type of the content part.
  /// </summary>
  public bool? NoChangeShapeType { get; set; }
}