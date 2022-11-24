namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public interface INonVisualInkContentPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsComment { get ; set; }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public IContentPartLocks? ContentPartLocks { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
