namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns?view=word-pia"/>
public partial interface ITextColumns : IModelObject
{
  /// <summary>
  /// Adds a new text column to the collection.
  /// </summary>
  /// <param name="Width">The width of the new column.</param>
  /// <param name="Spacing">The spacing between columns.</param>
  /// <param name="EvenlySpaced">true to make columns evenly spaced; otherwise, false.</param>
  /// <returns>The created <see cref="ITextColumn"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.add?view=word-pia"/>
  public ITextColumn Add(object Width, object Spacing, object EvenlySpaced);
}
