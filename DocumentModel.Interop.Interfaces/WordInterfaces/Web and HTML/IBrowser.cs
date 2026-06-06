namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents the browser tool used to move the insertion point to objects in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser?view=word-pia"/>
public interface IBrowser : IInteropObject
{
  /// <summary>
  /// Gets or sets the type of item that the browser moves to.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser.target?view=word-pia"/>
  public BrowseTarget Target { get; set; }	

  #region methods	
/// <summary>
  /// Moves the selection to the next item indicated by the browser target.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.browser.next?view=word-pia"/>
  public void Next();	
  #endregion methods
}
