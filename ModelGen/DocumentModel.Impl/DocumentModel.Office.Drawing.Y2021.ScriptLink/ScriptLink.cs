namespace DocumentModel.Office.Drawing.Y2021.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.Y2021.ScriptLink.IOfficeArtExtensionList))]
public class ScriptLink: IScriptLink
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office.Drawing.Y2021.ScriptLink.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
