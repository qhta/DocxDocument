namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Visibility of Annotation Types.
/// </summary>
public class RevisionView: ModelElement
{
  /// <summary>
  ///   Display Visual Indicator Of Markup Area
  /// </summary>
  public Boolean? Markup { get; set; }

  /// <summary>
  ///   Display Comments
  /// </summary>
  public Boolean? Comments { get; set; }

  /// <summary>
  ///   Display Content Revisions
  /// </summary>
  public Boolean? DisplayRevision { get; set; }

  /// <summary>
  ///   Display Formatting Revisions
  /// </summary>
  public Boolean? Formatting { get; set; }

  /// <summary>
  ///   Display Ink Annotations
  /// </summary>
  public Boolean? InkAnnotations { get; set; }
}