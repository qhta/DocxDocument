namespace DocumentModel.Wordprocessing;

/// <summary>
///   IDocument IEndnotes.
/// </summary>
public class IEndnotes: ElementCollection<IEndnote>
{
  /// <summary>
  /// Creates default separators.
  /// </summary>
  public void Init()
  {
    Add(CreateSpecialItem(-1, FootnoteEndnoteKind.Separator));
    Add(CreateSpecialItem(0, FootnoteEndnoteKind.ContinuationSeparator));
  }

  private IEndnote CreateSpecialItem(int id, FootnoteEndnoteKind type)
  {
    var item = new IEndnote
    { 
      Id = id,
      Type = type
    };
    item.Add(new IParagraph(new Run(new DMW.SeparatorMark{ Continuation = type == FootnoteEndnoteKind.ContinuationSeparator })));
    return item;
  }
}
