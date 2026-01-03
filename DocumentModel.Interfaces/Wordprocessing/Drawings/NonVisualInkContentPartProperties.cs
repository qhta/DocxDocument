using DocumentModel.Drawings;
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public interface NonVisualInkContentPartProperties: IModelElement
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
  public OfficeArtExtensionList2? OfficeArtExtensionList { get; set; }
}