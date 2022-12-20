namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ContentPartLocks Class.
/// </summary>
public partial interface ContentPartLocks
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public Boolean? NoGrouping { get; set; }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public Boolean? NoSelection { get; set; }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  public Boolean? NoRotation { get; set; }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect { get; set; }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  public Boolean? NoMove { get; set; }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  public Boolean? NoResize { get; set; }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  public Boolean? NoEditPoints { get; set; }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  public Boolean? NoAdjustHandles { get; set; }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  public Boolean? NoChangeArrowheads { get; set; }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  public Boolean? NoChangeShapeType { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.OfficeArtExtensionList2? OfficeArtExtensionList { get; set; }
  
}
