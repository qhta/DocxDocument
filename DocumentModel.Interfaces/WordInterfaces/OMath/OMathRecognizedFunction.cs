namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a recognized function. The OMathRecognizedFunction object is a member of the OMathRecognizedFunctions collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction?view=word-pia"/>
public partial interface OMathRecognizedFunction : InteropObject
{
  /// <summary>
  /// Returns the index number of the recognized function in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Returns the name of the recognized function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction.name?view=word-pia"/>
  public string Name { get; }
}
