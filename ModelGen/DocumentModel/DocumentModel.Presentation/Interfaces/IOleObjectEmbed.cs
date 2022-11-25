namespace DocumentModel.Presentation;

/// <summary>
/// Defines the OleObjectEmbed Class.
/// </summary>
public interface IOleObjectEmbed // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Color Scheme Properties for OLE Object
  /// </summary>
  public DocumentModel.Presentation.OleObjectFollowColorSchemeKind? FollowColorScheme { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
