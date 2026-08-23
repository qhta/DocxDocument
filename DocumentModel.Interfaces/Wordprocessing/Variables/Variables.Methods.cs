namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variables?view=word-pia"/>
public partial interface IVariables : IModelObject
{
  /// <summary>
  /// Adds a new variable to the collection.
  /// </summary>
  /// <param name="Name">The name of the variable to add.</param>
  /// <param name="Value">The value to assign to the variable.</param>
  /// <returns>The created <see cref="IVariable"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variables.add?view=word-pia"/>
  public IVariable Add(string Name, object Value);
}
