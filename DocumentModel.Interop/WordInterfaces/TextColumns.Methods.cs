namespace DocumentModel.Interop;

public partial interface TextColumns
{
  /// <summary>
  /// Adds a new text column to the collection.
  /// </summary>
  /// <param name="Width">The width of the new column.</param>
  /// <param name="Spacing">The spacing between columns.</param>
  /// <param name="EvenlySpaced">true to make columns evenly spaced; otherwise, false.</param>
  /// <returns>The created <see cref="TextColumn"/> object.</returns>
  public TextColumn Add(object Width, object Spacing, object EvenlySpaced);
}
