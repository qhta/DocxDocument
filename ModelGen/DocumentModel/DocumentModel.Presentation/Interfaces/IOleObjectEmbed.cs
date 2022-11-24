namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OleObjectEmbed Class.
/// </summary>
public interface IOleObjectEmbed // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Scheme Properties for OLE Object
  /// </summary>
  public OleObjectFollowColorSchemeValues? FollowColorScheme { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
