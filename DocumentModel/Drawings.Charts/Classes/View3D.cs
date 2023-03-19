namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D view settings.
/// </summary>
public class View3D: ModelElement
{
  /// <summary>
  ///   X Rotation.
  /// </summary>
  public SByte? RotateX { get; set; }

  /// <summary>
  ///   Height Percent.
  /// </summary>
  public UInt16? HeightPercent { get; set; }

  /// <summary>
  ///   Y Rotation.
  /// </summary>
  public UInt16? RotateY { get; set; }

  /// <summary>
  ///   Depth Percent.
  /// </summary>
  public UInt16? DepthPercent { get; set; }

  /// <summary>
  ///   Right Angle Axes.
  /// </summary>
  public Boolean? RightAngleAxes { get; set; }

  /// <summary>
  ///   Perspective.
  /// </summary>
  public Byte? Perspective { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}