namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OleObjectEmbed Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionList))]
public interface IOleObjectEmbed // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Scheme Properties for OLE Object
  /// </summary>
  public OleObjectFollowColorScheme? FollowColorScheme { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }
  
}
