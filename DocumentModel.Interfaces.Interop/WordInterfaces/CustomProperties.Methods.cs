namespace DocumentModel.Interop;

public partial interface CustomProperties
{
  /// <summary>
  /// Adds a custom property to the collection.
  /// </summary>
  /// <param name="Name">The name of the custom property.</param>
  /// <param name="Value">The value of the custom property.</param>
  /// <returns>The created <see cref="CustomProperty"/> object.</returns>
  public CustomProperty Add(string Name, string Value);
}
