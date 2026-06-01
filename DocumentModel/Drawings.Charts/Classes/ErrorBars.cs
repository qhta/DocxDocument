namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the IErrorBars Class.
/// </summary>
public class IErrorBars: ModelElement
{
  /// <summary>
  ///   Error Bar Direction.
  /// </summary>
  public ErrorBarDirectionKind? ErrorDirection { get; set; }

  /// <summary>
  ///   Error Bar Type.
  /// </summary>
  public ErrorBarKind? ErrorBarType { get; set; }

  /// <summary>
  ///   Error Bar Value Type.
  /// </summary>
  public ErrorKind? ErrorBarValueType { get; set; }

  /// <summary>
  ///   No End Cap.
  /// </summary>
  public bool? NoEndCap { get; set; }

  /// <summary>
  ///   Plus.
  /// </summary>
  public Plus? Plus { get; set; }

  /// <summary>
  ///   Minus.
  /// </summary>
  public Minus? Minus { get; set; }

  /// <summary>
  ///   Error Bar Value.
  /// </summary>
  public Double? ErrorBarValue { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   IChart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
