namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Frame Locks.
/// </summary>
public interface IGraphicFrameLocks // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public System.Boolean? NoGrouping { get ; set; }
  
  /// <summary>
  /// Disallow Selection of Child Shapes
  /// </summary>
  public System.Boolean? NoDrilldown { get ; set; }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public System.Boolean? NoSelection { get ; set; }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public System.Boolean? NoChangeAspect { get ; set; }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  public System.Boolean? NoMove { get ; set; }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  public System.Boolean? NoResize { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
