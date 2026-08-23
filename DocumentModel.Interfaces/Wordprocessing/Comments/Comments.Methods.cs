namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments?view=word-pia"/>
public partial interface IComments : IModelObject
{
  /// <summary>
  /// Adds a comment to the specified range.
  /// </summary>
  /// <param name="Range">The range to which the comment is attached.</param>
  /// <param name="Text">The comment text.</param>
  /// <returns>The created <see cref="IComment"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments.add?view=word-pia"/>
  public IComment Add(IRange Range, object Text);
}
