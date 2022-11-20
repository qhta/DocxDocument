namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Frame Locks.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IGraphicFrameLocks // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public bool? NoGrouping { get ; set; }
  
  /// <summary>
  /// Disallow Selection of Child Shapes
  /// </summary>
  public bool? NoDrilldown { get ; set; }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public bool? NoSelection { get ; set; }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public bool? NoChangeAspect { get ; set; }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  public bool? NoMove { get ; set; }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  public bool? NoResize { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
