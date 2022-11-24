namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D view settings.
/// </summary>
public interface IView3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  public IRotateX? RotateX { get ; set; }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  public IHeightPercent? HeightPercent { get ; set; }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  public IRotateY? RotateY { get ; set; }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  public IDepthPercent? DepthPercent { get ; set; }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  public IRightAngleAxes? RightAngleAxes { get ; set; }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  public IPerspective? Perspective { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
