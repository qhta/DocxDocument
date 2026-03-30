namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexceptions?view=word-pia"/>
public partial interface TwoInitialCapsExceptions: IModelObject
{
  /// <summary>
  /// Adds a new two-initial-caps exception to the collection.
  /// </summary>
  /// <param name="Name">The name of the exception to add.</param>
  /// <returns>The created <see cref="TwoInitialCapsException"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexceptions.add?view=word-pia"/>
  public TwoInitialCapsException Add(string Name);
}
