namespace DocumentModel.Drawings.Office.ScriptLink;

/// <summary>
///   Defines the ScriptLink Class.
/// </summary>
public interface ScriptLink:
{
  /// <summary>
  ///   val
  /// </summary>
  public string? Val { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}