namespace DocumentModel.Interop;

public partial interface Selection
{

  /// <summary>
  /// Returns information about the selection.
  /// </summary>
  /// <param name="Type">The type of information to retrieve.</param>
  /// <returns>The requested information as an object.</returns>
  public object Information(WdInformation Type);

  /// <summary>
  /// Returns the XML representation of the selection.
  /// </summary>
  /// <param name="DataOnly">true to return only the data; otherwise, false.</param>
  /// <returns>The XML string for the selection.</returns>
  public string XML(bool DataOnly);

  /// <summary>
  /// Selects the specified object.
  /// </summary>
  public void Select();
}
