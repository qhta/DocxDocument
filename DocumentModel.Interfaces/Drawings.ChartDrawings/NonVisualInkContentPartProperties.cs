namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public interface NonVisualInkContentPartProperties
{
  /// <summary>
  ///   isComment
  /// </summary>
  public bool? IsComment { get; set; }
  /// <summary>
  ///   ContentPartLocks.
  /// </summary>
  public ContentPartLocks? ContentPartLocks { get; set; }
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}