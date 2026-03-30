namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak?view=word-pia"/>
public partial interface OMathBreak: IModelObject
{
  /// <summary>
  /// Deletes the specified line break.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathbreak.delete?view=word-pia"/>
  public void Delete();
}
