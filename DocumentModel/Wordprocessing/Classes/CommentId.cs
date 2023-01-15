namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CommentId Class.
/// </summary>
public class CommentId
{
  /// <summary>
  ///   paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public Byte[]? ParaId { get; set; }

  /// <summary>
  ///   durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public Byte[]? DurableId { get; set; }
}