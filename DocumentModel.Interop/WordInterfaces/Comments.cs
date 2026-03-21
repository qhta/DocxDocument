namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Comment objects that represent the comments in a selection, range, or document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments?view=word-pia"/>
public partial interface Comments : InteropObject, InteropCollection<Comment>
{
  /// <summary>
  /// The show by.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.comments.showby?view=word-pia"/>
  public string ShowBy { get; set; }
}
