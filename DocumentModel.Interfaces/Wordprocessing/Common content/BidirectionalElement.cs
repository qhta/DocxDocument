namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines abstract BidirectionalElement Class.
/// </summary>
public interface BidirectionalElement: IElementCollection<BidirectionalContent>, 
  ParagraphContent, 
  SdtRunContent, 
  BidirectionalContent
{
  /// <summary>
  ///   Ltr/Rtl
  /// </summary>
  public DirectionKind? Type { get; set; }
}