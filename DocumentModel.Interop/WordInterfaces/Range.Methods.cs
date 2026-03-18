namespace DocumentModel.Interop;

public partial interface Range
{
  /// <summary>
  /// Returns information about the range.
  /// </summary>
  /// <param name="Type">The type of information to retrieve.</param>
  /// <returns>The requested information as an object.</returns>
  public object Information(WdInformation Type);

  /// <summary>
  /// Returns the XML representation of the range.
  /// </summary>
  /// <param name="DataOnly">true to return only the data; otherwise, false.</param>
  /// <returns>The XML string for the range.</returns>
  public string XML(bool DataOnly);

  /// <summary>
  /// Selects the range in the document.
  /// </summary>
  public void Select();
}
