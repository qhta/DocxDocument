namespace DocumentModel.Interop.Word;

public partial interface CustomLabels
{
  /// <summary>
  /// Adds a custom label to the collection.
  /// </summary>
  /// <param name="Name">The name of the custom label.</param>
  /// <param name="DotMatrix">Specifies whether the custom label is intended for dot-matrix printing.</param>
  /// <returns>The created <see cref="CustomLabel"/> object.</returns>
  public CustomLabel Add(string Name, object DotMatrix);
}
