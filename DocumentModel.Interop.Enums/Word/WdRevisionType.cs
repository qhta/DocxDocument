namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of a change that is marked with a revision mark.
/// </summary>
public enum WdRevisionType
{
  /// <summary>
  /// No revision.
  /// </summary>
  NoRevision = 0,
  /// <summary>
  /// Insertion.
  /// </summary>
  RevisionInsert = 1,
  /// <summary>
  /// Deletion.
  /// </summary>
  RevisionDelete = 2,
  /// <summary>
  /// Property changed.
  /// </summary>
  RevisionProperty = 3,
  /// <summary>
  /// Paragraph number changed.
  /// </summary>
  RevisionParagraphNumber = 4,
  /// <summary>
  /// Field display changed.
  /// </summary>
  RevisionDisplayField = 5,
  /// <summary>
  /// Revision marked as reconciled conflict.
  /// </summary>
  RevisionReconcile = 6,
  /// <summary>
  /// Revision marked as a conflict.
  /// </summary>
  RevisionConflict = 7,
  /// <summary>
  /// Style changed.
  /// </summary>
  RevisionStyle = 8,
  /// <summary>
  /// Replaced.
  /// </summary>
  RevisionReplace = 9,
  /// <summary>
  /// Paragraph property changed. [System.Runtime.InteropServices.Guid("22EE5D98-3D02-3761-AD43-435C8CF763B0")]
  /// public enum WdRevisionType ﾉ Expand table
  /// </summary>
  RevisionParagraphProperty = 10,
  /// <summary>
  /// Table property changed.
  /// </summary>
  RevisionTableProperty = 11,
  /// <summary>
  /// Section property changed.
  /// </summary>
  RevisionSectionProperty = 12,
  /// <summary>
  /// Style definition changed.
  /// </summary>
  RevisionStyleDefinition = 13,
  /// <summary>
  /// Content moved from.
  /// </summary>
  RevisionMovedFrom = 14,
  /// <summary>
  /// Content moved to.
  /// </summary>
  RevisionMovedTo = 15,
  /// <summary>
  /// Table cell inserted.
  /// </summary>
  RevisionCellInsertion = 16,
  /// <summary>
  /// Table cell deleted.
  /// </summary>
  RevisionCellDeletion = 17,
  /// <summary>
  /// Table cells merged.
  /// </summary>
  RevisionCellMerge = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  RevisionCellSplit = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  RevisionConflictInsert = 20,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  RevisionConflictDelete = 21
}
