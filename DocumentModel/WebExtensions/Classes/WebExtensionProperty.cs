namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebExtensionProperty Class.
/// </summary>
public class WebExtensionProperty: ModelElement
{
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   value, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Value { get; set; }
}