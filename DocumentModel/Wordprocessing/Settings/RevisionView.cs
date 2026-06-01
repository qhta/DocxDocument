namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Visibility of Annotation Types.
/// </summary>
public class RevisionView: ModelElement
{
  /// <summary>
  ///   Display Visual Indicator Of Markup Area
  /// </summary>
  public bool? Markup { get; set; }

  /// <summary>
  ///   Display IComments
  /// </summary>
  public bool? IComments { get; set; }

  /// <summary>
  ///   Display Content IRevisions
  /// </summary>
  public bool? DisplayRevision { get; set; }

  /// <summary>
  ///   Display Formatting IRevisions
  /// </summary>
  public bool? Formatting { get; set; }

  /// <summary>
  ///   Display Ink Annotations
  /// </summary>
  public bool? InkAnnotations { get; set; }
}
