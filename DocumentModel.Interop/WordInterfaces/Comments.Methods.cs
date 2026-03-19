namespace DocumentModel.Interop.Word;

public partial interface Comments
{
  /// <summary>
  /// Adds a comment to the specified range.
  /// </summary>
  /// <param name="Range">The range to which the comment is attached.</param>
  /// <param name="Text">The comment text.</param>
  /// <returns>The created <see cref="Comment"/> object.</returns>
  public Comment Add(Range Range, object Text);
}
