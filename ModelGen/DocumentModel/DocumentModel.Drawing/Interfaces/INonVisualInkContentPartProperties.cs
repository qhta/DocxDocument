namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public interface INonVisualInkContentPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? IsComment { get ; set; }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public DocumentModel.Drawing.IContentPartLocks? ContentPartLocks { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
