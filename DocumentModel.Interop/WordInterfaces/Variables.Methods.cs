namespace DocumentModel.Interop.Word;

public partial interface Variables
{
  /// <summary>
  /// Adds a new variable to the collection.
  /// </summary>
  /// <param name="Name">The name of the variable to add.</param>
  /// <param name="Value">The value to assign to the variable.</param>
  /// <returns>The created <see cref="Variable"/> object.</returns>
  public Variable Add(string Name, object Value);
}
