namespace DocumentModel.Drawings.Office.ScriptLink;
/// <summary>
///   Defines the ScriptLink Class.
/// </summary>
public partial class ScriptLink : ModelElement<DXOY21SL.ScriptLink>
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