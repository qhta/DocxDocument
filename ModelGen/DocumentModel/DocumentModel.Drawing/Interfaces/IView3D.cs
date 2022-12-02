namespace DocumentModel.Drawing;

/// <summary>
/// 3D view settings.
/// </summary>
public interface IView3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  public SByte? RotateX { get ; set; }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  public UInt16? HeightPercent { get ; set; }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  public UInt16? RotateY { get ; set; }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  public UInt16? DepthPercent { get ; set; }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  public Boolean? RightAngleAxes { get ; set; }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  public Byte? Perspective { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
