namespace DocumentModel.Wordprocessing;

/// <summary>
/// Special Footnote List.
/// </summary>
public interface IFootnoteSpecialReference // : DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public int? Id { get ; set; }
  
}
