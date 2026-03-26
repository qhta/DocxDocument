namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection?view=word-pia"/>
public partial interface Selection
{

  /// <summary>
  /// Returns information about the selection.
  /// </summary>
  /// <param name="Type">The type of information to retrieve.</param>
  /// <returns>The requested information as an object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.information?view=word-pia"/>
  public object Information(Information Type);

  /// <summary>
  /// Returns the XML representation of the selection.
  /// </summary>
  /// <param name="DataOnly">true to return only the data; otherwise, false.</param>
  /// <returns>The XML string for the selection.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.xml?view=word-pia"/>
  public string XML(bool DataOnly);

  /// <summary>
  /// Selects the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.selection.select?view=word-pia"/>
  public void Select();
}
