namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns?view=word-pia"/>
public partial class TextColumns
{
  /// <summary>
  /// Adds a new text column to the collection.
  /// </summary>
  /// <param name="Width">The width of the new column.</param>
  /// <param name="Spacing">The spacing between columns.</param>
  /// <param name="EvenlySpaced">true to make columns evenly spaced; otherwise, false.</param>
  /// <returns>The created <see cref="TextColumn"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.add?view=word-pia"/>
  public TextColumn Add(object Width, object Spacing, object EvenlySpaced) { throw new NotImplementedException(); }
}
