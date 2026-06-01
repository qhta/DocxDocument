namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ContentPartLocks Class.
/// </summary>
public class ContentPartLocks: ModelElement
{
  /// <summary>
  ///   Disallow IShape Grouping
  /// </summary>
  public bool? NoGrouping { get; set; }

  /// <summary>
  ///   Disallow IShape ISelection
  /// </summary>
  public bool? NoSelection { get; set; }

  /// <summary>
  ///   Disallow IShape Rotation
  /// </summary>
  public bool? NoRotation { get; set; }

  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public bool? NoChangeAspect { get; set; }

  /// <summary>
  ///   Disallow IShape Movement
  /// </summary>
  public bool? NoMove { get; set; }

  /// <summary>
  ///   Disallow IShape Resize
  /// </summary>
  public bool? NoResize { get; set; }

  /// <summary>
  ///   Disallow IShape IPoint Editing
  /// </summary>
  public bool? NoEditPoints { get; set; }

  /// <summary>
  ///   Disallow Showing Adjust Handles
  /// </summary>
  public bool? NoAdjustHandles { get; set; }

  /// <summary>
  ///   Disallow Arrowhead Changes
  /// </summary>
  public bool? NoChangeArrowheads { get; set; }

  /// <summary>
  ///   Disallow IShape Type Change
  /// </summary>
  public bool? NoChangeShapeType { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList2? OfficeArtExtensionList { get; set; }
}
