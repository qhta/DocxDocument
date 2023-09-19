namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of a custom geometric shape. This shape consists of a series of lines and curves described within a creation path. In addition to this there can also be adjust values, guides, adjust handles, connection sites and an inscribed rectangle specified for this custom geometric shape.
/// </summary>
public partial class CustomGeometry
{
  
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  public DocumentModel.Drawings.AdjustValueList? AdjustValueList { get; set; }
  
  
  /// <summary>
  ///   List of Shape Guides.
  /// </summary>
  public DocumentModel.Drawings.ShapeGuideList? ShapeGuideList { get; set; }
  
  
  /// <summary>
  ///   List of Shape Adjust Handles.
  /// </summary>
  public DocumentModel.Drawings.AdjustHandleList? AdjustHandleList { get; set; }
  
  
  /// <summary>
  ///   List of Shape Connection Sites.
  /// </summary>
  public DocumentModel.Drawings.ConnectionSiteList? ConnectionSiteList { get; set; }
  
  
  /// <summary>
  ///   Shape Text Rectangle.
  /// </summary>
  public DocumentModel.Drawings.Rectangle? Rectangle { get; set; }
  
  
  /// <summary>
  ///   List of Shape Paths.
  /// </summary>
  public DocumentModel.Drawings.PathList? PathList { get; set; }
  
}
