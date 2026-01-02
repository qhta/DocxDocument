namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Number Format.
/// </summary>
public class NumberingFormat: ModelElement
{
  /// <summary>
  ///   Number Format Code
  /// </summary>
  public string? FormatCode { get; set; }
  /// <summary>
  ///   Linked to Source
  /// </summary>
  public bool? SourceLinked { get; set; }
}