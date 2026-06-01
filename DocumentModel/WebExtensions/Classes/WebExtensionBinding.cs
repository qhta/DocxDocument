namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the WebExtensionBinding Class.
/// </summary>
public class WebExtensionBinding: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   type, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? Type { get; set; }

  /// <summary>
  ///   appref, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? AppReference { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}
