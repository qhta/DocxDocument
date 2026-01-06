namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionProperty Class.
/// </summary>
public interface WebExtensionProperty
{
  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   value
  /// </summary>
  public string? Value { get; set; }
}