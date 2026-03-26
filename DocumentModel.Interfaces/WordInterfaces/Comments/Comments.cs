namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Comment objects that represent the comments in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments?view=word-pia"/>
public partial interface Comments : InteropObject, InteropCollection<Comment>
{
  /// <summary>
  /// Gets or sets the reviewer name whose comments are displayed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments.showby?view=word-pia"/>
  public string ShowBy { get; set; }
}
