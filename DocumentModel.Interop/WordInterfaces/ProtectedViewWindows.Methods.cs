namespace DocumentModel.Interop;

public partial interface ProtectedViewWindows
{
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
  /// <returns>A <see cref="ProtectedViewWindow"/> object representing the newly opened protected view window.</returns>
  public ProtectedViewWindow Open(string FileName, bool AddToRecentFiles, string PasswordDocument, bool Visible, bool OpenAndRepair);
}
