namespace DocumentModel.Wordprocessing;

/// <summary>
///   IDocument IFootnotes.
/// </summary>
public class IFootnotes: ElementCollection<IFootnote>
{
  /// <summary>
  /// Creates default separators.
  /// </summary>
  public void Init()
  {
    Add(CreateSpecialItem(-1, FootnoteEndnoteKind.Separator));
    Add(CreateSpecialItem(0, FootnoteEndnoteKind.ContinuationSeparator));
  }

  private IFootnote CreateSpecialItem(int id, FootnoteEndnoteKind type)
  {
    var item = new IFootnote
    { 
      Id = id,
      Type = type
    };
    item.Add(new IParagraph(new Run(new DMW.SeparatorMark{ Continuation = type == FootnoteEndnoteKind.ContinuationSeparator })));
    return item;
  }
}
