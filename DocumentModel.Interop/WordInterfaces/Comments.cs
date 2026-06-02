namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Comment objects that represent the comments in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments?view=word-pia"/>
public partial interface IComments : IInteropObject, IInteropCollection<Comment>
{
  /// <summary>
  /// Gets or sets the reviewer name whose comments are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments.showby?view=word-pia"/>
  public string ShowBy { get; set; }


  #region methods

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

  #endregion methods
}
