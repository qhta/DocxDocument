namespace DocumentModel.Drawing;

/// <summary>
/// 3D view settings.
/// </summary>
public interface IView3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// X Rotation.
  /// </summary>
  public System.SByte? RotateX { get ; set; }
  
  /// <summary>
  /// Height Percent.
  /// </summary>
  public System.UInt16? HeightPercent { get ; set; }
  
  /// <summary>
  /// Y Rotation.
  /// </summary>
  public System.UInt16? RotateY { get ; set; }
  
  /// <summary>
  /// Depth Percent.
  /// </summary>
  public System.UInt16? DepthPercent { get ; set; }
  
  /// <summary>
  /// Right Angle Axes.
  /// </summary>
  public System.Boolean? RightAngleAxes { get ; set; }
  
  /// <summary>
  /// Perspective.
  /// </summary>
  public System.Byte? Perspective { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
