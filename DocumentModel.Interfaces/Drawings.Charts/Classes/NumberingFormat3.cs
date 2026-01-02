namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberingFormat Class.
/// </summary>
public class NumberingFormat3: ModelElement
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