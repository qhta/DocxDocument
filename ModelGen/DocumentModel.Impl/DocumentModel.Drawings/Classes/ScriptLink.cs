namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public class ScriptLinkImpl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>, ScriptLink
{
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList3? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
