namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents text content in a chart, supporting references, rich text, and literals.
/// </summary>
public interface ChartText3
{
  /// <summary>
  ///   Reference to a string data source.
  /// </summary>
  public StringReference? StringReference { get; set; }

  /// <summary>
  ///   Rich text content with formatting.
  /// </summary>
  public RichText? RichText { get; set; }

  /// <summary>
  ///   Literal string value provided directly.
  /// </summary>
  public StringLiteral? StringLiteral { get; set; }
}