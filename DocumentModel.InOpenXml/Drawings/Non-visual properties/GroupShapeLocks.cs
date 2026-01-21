namespace DocumentModel.Drawings;
/// <summary>
///   Represents locking options for a group shape, restricting user actions such as grouping, ungrouping, selection, rotation, movement, and resizing.
/// </summary>
public partial class GroupShapeLocks : ModelElement<DXD.GroupShapeLocks>, IExtendableElement
{
  /// <summary>
  ///   Disallows grouping of shapes within the group.
  /// </summary>
  public bool? NoGrouping { get; set; }
  /// <summary>
  ///   Disallows ungrouping of the group shape.
  /// </summary>
  public bool? NoUngrouping { get; set; }
  /// <summary>
  ///   Disallows selection of the group shape.
  /// </summary>
  public bool? NoSelection { get; set; }
  /// <summary>
  ///   Disallows rotation of the group shape.
  /// </summary>
  public bool? NoRotation { get; set; }
  /// <summary>
  ///   Disallows changing the aspect ratio of the group shape.
  /// </summary>
  public bool? NoChangeAspect { get; set; }
  /// <summary>
  ///   Disallows moving the group shape.
  /// </summary>
  public bool? NoMove { get; set; }
  /// <summary>
  ///   Disallows resizing the group shape.
  /// </summary>
  public bool? NoResize { get; set; }
  public IExtensionList? ExtensionList { get; set; }
}