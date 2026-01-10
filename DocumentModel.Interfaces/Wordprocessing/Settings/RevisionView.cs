namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the visibility settings for annotation types in a Wordprocessing document.
/// This interface provides properties for controlling the display of markup areas, comments, content revisions, formatting revisions, and ink annotations, enabling advanced configuration of revision and annotation visibility.
/// </summary>
public interface RevisionView
{

  /// <summary>
  /// Display visual indicator of the markup area.
  /// </summary>
  public bool? Markup { get; set; }

  /// <summary>
  /// Display comments in the document.
  /// </summary>
  public bool? Comments { get; set; }

  /// <summary>
  /// Display content revisions in the document.
  /// </summary>
  public bool? DisplayRevision { get; set; }

  /// <summary>
  /// Display formatting revisions in the document.
  /// </summary>
  public bool? Formatting { get; set; }

  /// <summary>
  /// Display ink annotations in the document.
  /// </summary>
  public bool? InkAnnotations { get; set; }
}