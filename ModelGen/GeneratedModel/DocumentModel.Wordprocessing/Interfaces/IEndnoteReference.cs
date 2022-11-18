namespace DocumentModel.Wordprocessing;

/// <summary>
/// Endnote Reference.
/// </summary>
public interface IEndnoteReference // : DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteReferenceType
{
  /// <summary>
  /// Suppress Footnote/Endnote Reference Mark
  /// </summary>
  public bool? CustomMarkFollows { get ; set; }
  
  /// <summary>
  /// Footnote/Endnote ID Reference
  /// </summary>
  public int? Id { get ; set; }
  
}
