namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebExtensionBinding Class.
/// </summary>
public class WebExtensionBinding: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   type, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Type { get; set; }

  /// <summary>
  ///   appref, this property is only available in Office 2013 and later.
  /// </summary>
  public String? AppReference { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}