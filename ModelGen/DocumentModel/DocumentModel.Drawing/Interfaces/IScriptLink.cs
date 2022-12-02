namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public interface IScriptLink // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
