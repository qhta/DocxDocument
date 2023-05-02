namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Title.
/// </summary>
public class Title: ModelElement
{
  /// <summary>
  ///   Language
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   Value
  /// </summary>
  public string? Val { get; set; }
}