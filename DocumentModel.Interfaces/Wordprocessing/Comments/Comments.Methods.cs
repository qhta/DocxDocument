namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments?view=word-pia"/>
public partial interface Comments: IModelObject
{
  /// <summary>
  /// Adds a comment to the specified range.
  /// </summary>
  /// <param name="Range">The range to which the comment is attached.</param>
  /// <param name="Text">The comment text.</param>
  /// <returns>The created <see cref="Comment"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments.add?view=word-pia"/>
  public Comment Add(Range Range, object Text);
}
