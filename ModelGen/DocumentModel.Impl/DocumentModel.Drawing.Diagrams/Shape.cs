namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IAdjustList))]
public class Shape: IShape
{
  /// <summary>
  /// Rotation
  /// </summary>
  public double? Rotation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  public string? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  public string? Blip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  public int? ZOrderOffset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  public bool? HideGeometry
  {
    get;
    set;
  }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  public bool? LockedText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  public bool? BlipPlaceholder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public IAdjustList? AdjustList
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
