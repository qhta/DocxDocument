namespace DocumentModel.WebExtensions;

/// <summary>
///   Defines the WebExtensionBinding Class.
/// </summary>
public class WebExtensionBinding: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   type, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Type { get; set; }
  /// <summary>
  ///   appref, this property is only available in Office 2013 and later.
  /// </summary>
  public string? AppReference { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}