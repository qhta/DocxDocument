namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variables?view=word-pia"/>
public partial interface Variables: InteropObject
{
  /// <summary>
  /// Adds a new variable to the collection.
  /// </summary>
  /// <param name="Name">The name of the variable to add.</param>
  /// <param name="Value">The value to assign to the variable.</param>
  /// <returns>The created <see cref="Variable"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variables.add?view=word-pia"/>
  public Variable Add(string Name, object Value);
}
