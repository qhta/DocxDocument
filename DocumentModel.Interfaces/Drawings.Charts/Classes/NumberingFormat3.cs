namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the NumberingFormat Class.
/// </summary>
public interface NumberingFormat3
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