namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public partial class NonVisualInkContentPartProperties
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsComment { get; set; }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public DocumentModel.Drawings.ContentPartLocks? ContentPartLocks { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.OfficeArtExtensionList2? OfficeArtExtensionList { get; set; }
  
}
