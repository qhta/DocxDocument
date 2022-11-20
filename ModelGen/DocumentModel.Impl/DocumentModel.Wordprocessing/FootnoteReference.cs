namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Reference.
/// </summary>
public class FootnoteReference: IFootnoteReference
{
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public bool? CustomMarkFollows
  {
    get;
    set;
  }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  public int? Id
  {
    get;
    set;
  }
  
}
