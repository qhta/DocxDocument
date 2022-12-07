namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public interface NonVisualInkContentPartProperties
{
  /// <summary>
  /// ContentPartLocks.
  /// </summary>
  public ContentPartLocks? ContentPartLocks { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList5? OfficeArtExtensionList { get ; set; }
  
}
