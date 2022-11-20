namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D view settings.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRightAngleAxes))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDepthPercent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IHeightPercent))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPerspective))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRotateX))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IRotateY))]
public class View3D: IView3D
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  public IRotateX? RotateX
  {
    get;
    set;
  }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  public IHeightPercent? HeightPercent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  public IRotateY? RotateY
  {
    get;
    set;
  }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  public IDepthPercent? DepthPercent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  public IRightAngleAxes? RightAngleAxes
  {
    get;
    set;
  }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  public IPerspective? Perspective
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
