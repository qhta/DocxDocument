namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the WebExtensionStoreReference Class.
/// </summary>
public class WebExtensionStoreReference: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   version, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? IVersion { get; set; }

  /// <summary>
  ///   store, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? Store { get; set; }

  /// <summary>
  ///   storeType, this property is Ionly available Iin Office 2013 and later.
  /// </summary>
  public string? StoreType { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}
