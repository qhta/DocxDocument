namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Variable objects that represent the variables added to a document or template. Document
/// variables are used to preserve macro settings in between macro sessions.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variables?view=word-pia"/>
public interface IVariables : IInteropObject, IInteropCollection<IVariable>
{


  #region methods

/// <summary>
  /// Adds a new variable to the collection.
  /// </summary>
  /// <param name="name">The name of the variable to add.</param>
  /// <param name="value">The value to assign to the variable.</param>
  /// <returns>The created <see cref="IVariable"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.variables.add?view=word-pia"/>
  public IVariable Add(string name, object value);

  #endregion methods
}
