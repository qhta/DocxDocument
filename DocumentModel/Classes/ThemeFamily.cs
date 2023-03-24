namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ThemeFamily Class.
/// </summary>
public class ThemeFamily: ModelElement
{
  /// <summary>
  ///   name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   vid, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Vid { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}