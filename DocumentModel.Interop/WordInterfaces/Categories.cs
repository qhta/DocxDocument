namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of building block categories.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories?view=word-pia"/>
public partial interface Categories : InteropObject
{
  /// <summary>
  /// The count.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.categories.count?view=word-pia"/>
  public int Count { get; }
}
