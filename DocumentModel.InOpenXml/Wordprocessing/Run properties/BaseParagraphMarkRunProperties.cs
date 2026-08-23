namespace DocumentModel.Wordprocessing;
/// <summary>
/// Base interface for ParagraphMarkRunProperties classes, containing properties specific to paragraph mark runs
/// that are not applied to <see cref = "ExtBaseRunProperties"/>.
/// Provides support for revision tracking, conflict handling, and Office Math indication on paragraph marks.
/// </summary>
[DataContract]
[XmlRoot("BaseParagraphMarkRunProperties", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class BaseParagraphMarkRunProperties<T> : ExtBaseRunProperties<T> where T : DX.OpenXmlCompositeElement
{
  /// <summary>
  /// Indicates that the paragraph has been inserted, with revision tracking information.
  /// </summary>
  public Inserted? Inserted { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that the paragraph has been deleted, with revision tracking information.
  /// </summary>
  public Deleted? Deleted { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that the paragraph is the source of a move operation, with revision tracking information.
  /// </summary>
  public MoveFrom? MoveFrom { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that the paragraph is the destination of a move operation, with revision tracking information.
  /// </summary>
  public MoveTo? MoveTo { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that the paragraph has been inserted in conflict with edits made by other users.
  /// </summary>
  public ConflictInsertion? ConflictInsertion { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that the paragraph has been deleted in conflict with edits made by other users.
  /// </summary>
  public ConflictDeletion? ConflictDeletion { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Indicates that this run contains WordprocessingML to be handled as Office Open XML Math, allowing equations on empty paragraphs and marking the paragraph as part of an Office Math equation.
  /// </summary>
  public bool? OfficeMath { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}