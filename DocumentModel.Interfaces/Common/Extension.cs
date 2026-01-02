namespace DocumentModel;

/// <summary>
///   Defines the Extension Class.
/// </summary>
public class Extension: ModelElement
{
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Uri { get; set; }
}