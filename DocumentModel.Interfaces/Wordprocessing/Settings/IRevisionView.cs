namespace DocumentModel.Wordprocessing;

/// <summary>
///   Visibility of Annotation Types.
/// </summary>
public interface IRevisionView: IModelElement
{
  /// <summary>
  ///   Display Visual Indicator Of Markup Area
  /// </summary>
  public bool? Markup { get; set; }
  /// <summary>
  ///   Display Comments
  /// </summary>
  public bool? Comments { get; set; }
  /// <summary>
  ///   Display Content Revisions
  /// </summary>
  public bool? DisplayRevision { get; set; }
  /// <summary>
  ///   Display Formatting Revisions
  /// </summary>
  public bool? Formatting { get; set; }
  /// <summary>
  ///   Display Ink Annotations
  /// </summary>
  public bool? InkAnnotations { get; set; }
}