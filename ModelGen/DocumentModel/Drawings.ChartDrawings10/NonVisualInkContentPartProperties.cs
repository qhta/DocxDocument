namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public partial class NonVisualInkContentPartProperties
{
  
  /// <summary>
  ///   isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsComment { get; set; }
  
  
  /// <summary>
  ///   ContentPartLocks.
  /// </summary>
  public DMD10.ContentPartLocks? ContentPartLocks { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DMD10.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
