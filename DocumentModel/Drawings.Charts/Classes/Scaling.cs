namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Scaling.
/// </summary>
public class Scaling: ModelElement
{
  /// <summary>
  ///   Logarithmic Base.
  /// </summary>
  public Double? LogBase { get; set; }

  /// <summary>
  ///   Axis Orientation.
  /// </summary>
  public OrientationKind? Orientation { get; set; }

  /// <summary>
  ///   Maximum.
  /// </summary>
  public Double? MaxAxisValue { get; set; }

  /// <summary>
  ///   Minimum.
  /// </summary>
  public Double? MinAxisValue { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}