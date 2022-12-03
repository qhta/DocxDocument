namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public interface NonVisualInkContentPartProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsComment { get ; set; }
  
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public ContentPartLocks? ContentPartLocks { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
