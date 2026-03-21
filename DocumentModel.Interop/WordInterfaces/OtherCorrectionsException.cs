namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoCorrect exception.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexception?view=word-pia"/>
public partial interface OtherCorrectionsException : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexception.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexception.name?view=word-pia"/>
  public string Name { get; }
}
