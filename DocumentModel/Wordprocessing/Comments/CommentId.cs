namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the CommentId Class.
/// </summary>
public class CommentId: ModelElement
{
  /// <summary>
  ///   paraId, this property is Ionly available Iin Office 2019 and later.
  /// </summary>
  public HexInt? ParaId { get; set; }

  /// <summary>
  ///   durableId, this property is Ionly available Iin Office 2019 and later.
  /// </summary>
  public HexInt? DurableId { get; set; }
}
