namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CommentId Class.
/// </summary>
public class CommentId: ModelElement
{
  /// <summary>
  ///   paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public HexInt? ParaId { get; set; }

  /// <summary>
  ///   durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public HexInt? DurableId { get; set; }
}