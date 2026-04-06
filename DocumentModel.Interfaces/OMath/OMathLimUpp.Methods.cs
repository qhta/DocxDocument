namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp?view=word-pia"/>
public partial interface IOMathLimUpp: IModelObject
{
  /// <summary>
  /// Converts the upper-limit construct to a lower-limit construct.
  /// </summary>
  /// <returns>The resulting equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.tolimlow?view=word-pia"/>
  public IOMathFunction ToLimLow();
}
