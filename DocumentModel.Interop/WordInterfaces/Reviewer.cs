namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single reviewer of a document in which changes have been tracked.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reviewer?view=word-pia"/>
public interface Reviewer : InteropObject
{
  /// <summary>
  /// The visible.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reviewer.visible?view=word-pia"/>
  public bool Visible { get; set; }

}
