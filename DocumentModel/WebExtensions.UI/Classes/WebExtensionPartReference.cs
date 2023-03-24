namespace DocumentModel.WebExtensions.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebExtensionPartReference Class.
/// </summary>
public class WebExtensionPartReference: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }
}