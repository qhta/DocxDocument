namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Shape.
/// </summary>
public partial interface Shape
{
  /// <summary>
  /// Rotation
  /// </summary>
  public Double? Rotation { get; set; }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  public String? Type { get; set; }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  public String? Blip { get; set; }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  public Int32? ZOrderOffset { get; set; }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  public Boolean? HideGeometry { get; set; }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  public Boolean? LockedText { get; set; }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  public Boolean? BlipPlaceholder { get; set; }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.AdjustList? AdjustList { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
}
