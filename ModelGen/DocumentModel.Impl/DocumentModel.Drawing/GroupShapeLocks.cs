namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GroupShapeLocks Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class GroupShapeLocks: IGroupShapeLocks
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public bool? NoGrouping
  {
    get;
    set;
  }
  
  /// <summary>
  /// Disallow Shape Ungrouping
  /// </summary>
  public bool? NoUngrouping
  {
    get;
    set;
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public bool? NoSelection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  public bool? NoRotation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public bool? NoChangeAspect
  {
    get;
    set;
  }
  
  /// <summary>
  /// Disallow Moving Shape
  /// </summary>
  public bool? NoMove
  {
    get;
    set;
  }
  
  /// <summary>
  /// Disallow Shape Resizing
  /// </summary>
  public bool? NoResize
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
