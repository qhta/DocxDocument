namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexceptions?view=word-pia"/>
public partial interface IOtherCorrectionsExceptions : IModelObject
{
  /// <summary>
  /// Adds a new correction entry with the specified name and returns the corresponding exception instance. 
  /// </summary>
  /// <param name="Name">The name of the correction to add. Cannot be null or empty.</param>
  /// <returns>An instance of OtherCorrectionsException representing the added correction.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexceptions.add?view=word-pia"/>
  public IOtherCorrectionsException Add(string Name);
}
