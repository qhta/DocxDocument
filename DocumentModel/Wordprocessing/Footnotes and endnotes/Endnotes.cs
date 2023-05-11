namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document Endnotes.
/// </summary>
public class Endnotes: ElementCollection<Endnote>
{
  /// <summary>
  /// Creates default separators.
  /// </summary>
  public void Init()
  {
    Add(CreateSpecialItem(-1, FootnoteEndnoteKind.Separator));
    Add(CreateSpecialItem(0, FootnoteEndnoteKind.ContinuationSeparator));
  }

  private Endnote CreateSpecialItem(int id, FootnoteEndnoteKind type)
  {
    var item = new Endnote
    { 
      Id = id,
      Type = type
    };
    item.Add(new Paragraph(new Run(new DMW.SeparatorMark{ Continuation = type == FootnoteEndnoteKind.ContinuationSeparator })));
    return item;
  }
}