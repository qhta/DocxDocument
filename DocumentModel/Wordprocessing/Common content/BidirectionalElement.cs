namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines abstract BidirectionalElement Class.
/// </summary>
public abstract class BidirectionalElement: ElementCollection<IBidirectionalContent>, IParagraphContent, ISdtRunContent, IBidirectionalContent
{
  /// <summary>
  ///   Ltr/Rtl
  /// </summary>
  public DirectionKind? Type { get; set; }

}