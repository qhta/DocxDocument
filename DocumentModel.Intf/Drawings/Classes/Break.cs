namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Line Break.
/// </summary>
public class Break: ModelElement
{
  /// <summary>
  ///   Text Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
}