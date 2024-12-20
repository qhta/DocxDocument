namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Run.
/// </summary>
public class Run: ModelElement
{
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }

  /// <summary>
  ///   Text String.
  /// </summary>
  public string? Text { get; set; }
}