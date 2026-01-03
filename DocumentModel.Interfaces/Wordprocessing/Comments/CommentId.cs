namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CommentId Class.
/// </summary>
public interface CommentId: IModelElement
{
  /// <summary>
  ///   paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public IHexInt? ParaId { get; set; }
  /// <summary>
  ///   durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public IHexInt? DurableId { get; set; }
}