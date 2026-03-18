namespace DocumentModel.Interop;

public partial interface TwoInitialCapsExceptions
{
  /// <summary>
  /// Adds a new two-initial-caps exception to the collection.
  /// </summary>
  /// <param name="Name">The name of the exception to add.</param>
  /// <returns>The created <see cref="TwoInitialCapsException"/> object.</returns>
  public TwoInitialCapsException Add(string Name);
}
