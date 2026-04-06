namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry?view=word-pia"/>
public partial interface IOMathAutoCorrectEntry: IModelObject
{
  /// <summary>
  /// Deletes the specified OMathAutoCorrectEntry.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathautocorrectentry.delete?view=word-pia"/>
  public void Delete();
}
