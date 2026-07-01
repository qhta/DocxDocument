namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the visibility settings for annotation types in a Wordprocessing document.
/// This class provides properties for controlling the display of markup areas, comments, content revisions, formatting revisions, and ink annotations, enabling advanced configuration of revision and annotation visibility.
/// </summary>
[DataContract]
[XmlRoot("RevisionView", Namespace = "DocumentModel.Wordprocessing")]
public partial class RevisionView
{
 /// <summary>
 /// Display visual indicator of the markup area.
 /// </summary>
 public bool? Markup { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Display comments in the document.
 /// </summary>
 public bool? Comments { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Display content revisions in the document.
 /// </summary>
 public bool? DisplayRevision { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Display formatting revisions in the document.
 /// </summary>
 public bool? Formatting { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
 /// <summary>
 /// Display ink annotations in the document.
 /// </summary>
 public bool? InkAnnotations { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}