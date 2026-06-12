namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the browser tool used to move the insertion point to objects in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser?view=word-pia"/>
public partial interface IBrowser : IModelObject
{
  /// <summary>
  /// Gets or sets the type of item that the browser moves to.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser.target?view=word-pia"/>
  public BrowseTarget Target { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
