namespace DocumentModel.Interop;

public partial interface Paragraphs
{
  /// <summary>
  /// Adds a new paragraph to the document at the specified range.  
  /// </summary>
  /// <remarks>If the specified range is collapsed, the new paragraph is inserted at that position. If the range
  /// is not collapsed, the content of the range may be replaced by the new paragraph.</remarks>
  /// <param name="Range">The range within the document where the new paragraph will be inserted. This can be a Range object or a location
  /// that specifies the insertion point. Cannot be null.</param>
  /// <returns>A Paragraph object representing the newly added paragraph.</returns>
  public Paragraph Add(object Range);
}
