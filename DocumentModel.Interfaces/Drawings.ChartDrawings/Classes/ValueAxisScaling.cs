namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ValueAxisScaling Class.
/// </summary>
public interface ValueAxisScaling: IModelElement
{
  /// <summary>
  ///   max
  /// </summary>
  public string? Max { get; set; }
  /// <summary>
  ///   min
  /// </summary>
  public string? Min { get; set; }
  /// <summary>
  ///   majorUnit
  /// </summary>
  public string? MajorUnit { get; set; }
  /// <summary>
  ///   minorUnit
  /// </summary>
  public string? MinorUnit { get; set; }
}