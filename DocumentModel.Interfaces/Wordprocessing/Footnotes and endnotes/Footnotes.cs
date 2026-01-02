namespace DocumentModel.Wordprocessing;
/// <summary>
///   Document Footnotes.
/// </summary>
public class Footnotes: ElementCollection<Footnote>
{
  /// <summary>
  /// Creates default separators.
  /// </summary>
  public void Init()
  {
    Add(CreateSpecialItem(-1, FootnoteEndnoteKind.Separator));
    Add(CreateSpecialItem(0, FootnoteEndnoteKind.ContinuationSeparator));
  }
  private Footnote CreateSpecialItem(int id, FootnoteEndnoteKind type)
  {
    var item = new Footnote
    { 
      Id = id,
      Type = type
    };
    item.Add(new Paragraph(new Run(new DMW.SeparatorMark{ Continuation = type == FootnoteEndnoteKind.ContinuationSeparator })));
    return item;
  }
}