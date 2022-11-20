namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OleObjectEmbed Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public class OleObjectEmbed: IOleObjectEmbed
{
  /// <summary>
  /// Color Scheme Properties for OLE Object
  /// </summary>
  public OleObjectFollowColorSchemeValues? FollowColorScheme
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
