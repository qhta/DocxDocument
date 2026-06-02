namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a recognized function. The OMathRecognizedFunction object is a member of the OMathRecognizedFunctions collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction?view=word-pia"/>
public partial class OMathRecognizedFunction : InteropObject
{
  /// <summary>
  /// Returns the index number of the recognized function in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Returns the name of the recognized function.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction.name?view=word-pia"/>
  public string? Name { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified recognized function from the list of the recognized functions.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrecognizedfunction.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}
