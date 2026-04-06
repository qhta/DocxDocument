namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak?view=word-pia"/>
public partial interface IOMathBreak: IModelObject
{
  /// <summary>
  /// Deletes the specified line break.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak.delete?view=word-pia"/>
  public void Delete();
}
