namespace DocumentModel.Drawings;

/// <summary>
/// Shape.
/// </summary>
public class Shape4Impl: ModelElementImpl, Shape4
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Rotation
  /// </summary>
  public Double? Rotation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  public String? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  public String? Blip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  public Int32? ZOrderOffset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  public Boolean? HideGeometry
  {
    get;
    set;
  }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  public Boolean? LockedText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  public Boolean? BlipPlaceholder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public AdjustList? AdjustList
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
