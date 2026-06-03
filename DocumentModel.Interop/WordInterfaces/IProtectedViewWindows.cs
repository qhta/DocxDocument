namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the ProtectedViewWindow objects that are currently open in Word 2010.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindows?view=word-pia"/>
public interface IProtectedViewWindows : IInteropObject, IInteropCollection<IProtectedViewWindow>
{


  #region methods

/// <summary>
  /// Opens the specified document in a new protected view window.
  /// </summary>
  /// <param name="FileName">The path or name of the file to open. Can be a full path or a file name relative to the current directory.</param>
  /// <param name="AddToRecentFiles">Indicates whether to add the document to the list of recently used files. Set to <see langword="true"/> to add the
  /// file; otherwise, <see langword="false"/>.</param>
  /// <param name="PasswordDocument">The password required to open the document, if it is password-protected. Specify <see langword="null"/> or an
  /// empty value if no password is needed.</param>
  /// <param name="Visible">Indicates whether the protected view window is visible after opening. Set to <see langword="true"/> to display the
  /// window; otherwise, <see langword="false"/>.</param>
  /// <param name="OpenAndRepair">Indicates whether to attempt to repair the document while opening. Set to <see langword="true"/> to open and
  /// repair; otherwise, <see langword="false"/>.</param>
  /// <returns>A <see cref="IProtectedViewWindow"/> object representing the newly opened protected view window.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.protectedviewwindows.open?view=word-pia"/>
  public IProtectedViewWindow Open(string FileName, bool AddToRecentFiles, string PasswordDocument, bool Visible, bool OpenAndRepair);

  #endregion methods
}
