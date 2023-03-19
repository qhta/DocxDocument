using DocumentModel.Drawings;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public class NonVisualInkContentPartProperties: ModelElement
{
  /// <summary>
  ///   isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? IsComment { get; set; }

  /// <summary>
  ///   ContentPartLocks.
  /// </summary>
  public ContentPartLocks? ContentPartLocks { get; set; }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList2? OfficeArtExtensionList { get; set; }
}