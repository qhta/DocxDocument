namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MarkupType Class.
/// </summary>
public class MarkupType: ModelElement, ICommonContent
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public string? Id { get; set; }
}