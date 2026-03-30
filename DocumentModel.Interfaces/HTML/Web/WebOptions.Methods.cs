namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions?view=word-pia"/>
public partial interface WebOptions: IModelObject
{
  /// <summary>
  /// Sets the folder suffix for the specified document to the default suffix for the language support you have
  /// selected or installed.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.weboptions.usedefaultfoldersuffix?view=word-pia"/>
  public void UseDefaultFolderSuffix();
}
