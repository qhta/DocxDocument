namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a recognized function. The OMathRecognizedFunction object is a member of the OMathRecognizedFunctions collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction?view=word-pia"/>
public partial interface OMathRecognizedFunction : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction.name?view=word-pia"/>
  public string Name { get; }
}
