namespace DocumentModel.Wordprocessing;

/// <summary>
/// Special Endnote List.
/// </summary>
public interface IEndnoteSpecialReference // : DocumentFormat.OpenXml.Wordprocessing.FootnoteEndnoteSeparatorReferenceType
{
  /// <summary>
  /// Footnote/Endnote ID
  /// </summary>
  public int? Id { get ; set; }
  
}
