namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single initial-capital AutoCorrect exception.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexception?view=word-pia"/>
public partial interface TwoInitialCapsException : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexception.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.twoinitialcapsexception.name?view=word-pia"/>
  public string Name { get; }
}
