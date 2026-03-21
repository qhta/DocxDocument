namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the browser tool used to move the insertion point to objects in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser?view=word-pia"/>
public partial interface Browser : InteropObject
{
  /// <summary>
  /// The target.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser.target?view=word-pia"/>
  public WdBrowseTarget Target { get; set; }
}
