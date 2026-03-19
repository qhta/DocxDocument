namespace DocumentModel.Interop.Word;

public partial interface WebOptions
{
  /// <summary>
  /// Sets the folder suffix for the specified document to the default suffix for the language support you have selected or installed.
  /// </summary>
  public void UseDefaultFolderSuffix();
}
