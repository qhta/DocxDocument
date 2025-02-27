namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public class NonVisualInkContentPartProperties: ModelElement
{
  /// <summary>
  ///   isComment, this property is only available in Office 2010 and later.
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