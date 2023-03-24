namespace DocumentModel.Drawings.Office.ScriptLink;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ScriptLink Class.
/// </summary>
public class ScriptLink: ModelElement
{
  /// <summary>
  ///   val, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Val { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}