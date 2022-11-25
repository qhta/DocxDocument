namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GroupShapeLocks Class.
/// </summary>
public interface IGroupShapeLocks // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public System.Boolean? NoGrouping { get ; set; }
  
  /// <summary>
  /// Disallow Shape Ungrouping
  /// </summary>
  public System.Boolean? NoUngrouping { get ; set; }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public System.Boolean? NoSelection { get ; set; }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  public System.Boolean? NoRotation { get ; set; }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public System.Boolean? NoChangeAspect { get ; set; }
  
  /// <summary>
  /// Disallow Moving Shape
  /// </summary>
  public System.Boolean? NoMove { get ; set; }
  
  /// <summary>
  /// Disallow Shape Resizing
  /// </summary>
  public System.Boolean? NoResize { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
