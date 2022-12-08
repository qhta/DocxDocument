namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeLocks Class.
/// </summary>
public interface GroupShapeLocks
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public Boolean? NoGrouping { get ; set; }
  
  /// <summary>
  /// Disallow Shape Ungrouping
  /// </summary>
  public Boolean? NoUngrouping { get ; set; }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public Boolean? NoSelection { get ; set; }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  public Boolean? NoRotation { get ; set; }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect { get ; set; }
  
  /// <summary>
  /// Disallow Moving Shape
  /// </summary>
  public Boolean? NoMove { get ; set; }
  
  /// <summary>
  /// Disallow Shape Resizing
  /// </summary>
  public Boolean? NoResize { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList { get ; set; }
  
}
