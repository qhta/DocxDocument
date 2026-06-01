namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   Linked Ito ISource
  /// </summary>
  public bool? SourceLinked { get; set; }
}
