namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a string in a document or range that contains recognized type information.
/// </summary>
public partial interface SmartTag : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The xml.
  /// </summary>
  public string XML { get; }

  /// <summary>
  /// The range.
  /// </summary>
  public Range Range { get; }

  /// <summary>
  /// The download url.
  /// </summary>
  public string DownloadURL { get; }

  /// <summary>
  /// The properties.
  /// </summary>
  public CustomProperties Properties { get; }

  /// <summary>
  /// The smart tag actions.
  /// </summary>
  public SmartTagActions SmartTagActions { get; }

  /// <summary>
  /// The xmlnode.
  /// </summary>
  public XMLNode XMLNode { get; }
}
