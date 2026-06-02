namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of AutoCaption objects that represent the captions that can be automatically added when items such as tables, pictures, or OLE objects are inserted into a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaptions?view=word-pia"/>
public partial class AutoCaptions : InteropCollection<AutoCaption>
{


  #region methods

/// <summary>
  /// Prevents Microsoft Word from automatically adding captions to any type of item.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autocaptions.cancelautoinsert?view=word-pia"/>
  public void CancelAutoInsert() { throw new NotImplementedException(); }

  #endregion methods
}
