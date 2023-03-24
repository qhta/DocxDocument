namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CommentAnchor Class.
/// </summary>
public class CommentAnchor: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Id { get; set; }
}