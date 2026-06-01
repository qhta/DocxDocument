namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the WebExtensionProperty Class.
/// </summary>
public class WebExtensionProperty: ModelElement
{
  /// <summary>
  ///   name, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   value, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? Value { get; set; }
}
