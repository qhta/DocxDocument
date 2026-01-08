namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a set of literal string values for a chart.
///   This interface allows defining string data directly within the chart definition, rather than referencing an external source.
/// </summary>
public interface StringLiteral
{
  /// <summary>
  ///   Number of string points in the literal value set.
  /// </summary>
  public UInt32? PointCount { get; set; }

  /// <summary>
  ///   Collection of string points containing the literal values.
  /// </summary>
  public StringPoints StringPoints { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional customization.
  /// </summary>
  public StrDataExtensionList? StrDataExtensionList { get; set; }
}