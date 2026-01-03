namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CommentId Class.
/// </summary>
public interface CommentId: IModelElement
{
  /// <summary>
  ///   paraId
  /// </summary>
  public IHexInt? ParaId { get; set; }
  /// <summary>
  ///   durableId
  /// </summary>
  public IHexInt? DurableId { get; set; }
}