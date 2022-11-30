namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Shape.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rotation
  /// </summary>
  public System.Double? Rotation { get ; set; }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  public System.String? Blip { get ; set; }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  public System.Int32? ZOrderOffset { get ; set; }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  public System.Boolean? HideGeometry { get ; set; }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  public System.Boolean? LockedText { get ; set; }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  public System.Boolean? BlipPlaceholder { get ; set; }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IAdjustList? AdjustList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
