namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoCorrect exception.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexception?view=word-pia"/>
public partial class OtherCorrectionsException : InteropObject
{
  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexception.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.othercorrectionsexception.name?view=word-pia"/>
  public string? Name { get; set; }
}
