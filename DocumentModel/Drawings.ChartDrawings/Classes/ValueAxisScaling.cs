namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ValueAxisScaling Class.
/// </summary>
public class ValueAxisScaling: ModelElement
{
  /// <summary>
  ///   max, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Max { get; set; }

  /// <summary>
  ///   min, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Min { get; set; }

  /// <summary>
  ///   majorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public string? MajorUnit { get; set; }

  /// <summary>
  ///   minorUnit, this property is only available in Office 2016 and later.
  /// </summary>
  public string? MinorUnit { get; set; }
}