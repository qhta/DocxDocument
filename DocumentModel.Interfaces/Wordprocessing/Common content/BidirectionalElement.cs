namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines abstract BidirectionalElement Class.
/// </summary>
public interface BidirectionalElement: IElementCollection<IBidirectionalContent>, 
  IParagraphContent, 
  ISdtRunContent, 
  IBidirectionalContent
{
  /// <summary>
  ///   Ltr/Rtl
  /// </summary>
  public DirectionKind? Type { get; set; }
}