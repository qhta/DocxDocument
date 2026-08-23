namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol?view=word-pia"/>
public partial interface IContentControl : IModelObject
{
  /// <summary>
  /// Copies the content control from the active document to the Clipboard.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrol.copy?view=word-pia"/>
  public void Copy();
}
