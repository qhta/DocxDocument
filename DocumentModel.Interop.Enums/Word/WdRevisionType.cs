namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of a change that is marked with a revision mark.
/// </summary>
public enum WdRevisionType
{
  /// <summary>
  /// No revision.
  /// </summary>
  NoRevision = unchecked((int)0),
  /// <summary>
  /// Insertion.
  /// </summary>
  RevisionInsert = unchecked((int)1),
  /// <summary>
  /// Deletion.
  /// </summary>
  RevisionDelete = unchecked((int)2),
  /// <summary>
  /// Property changed.
  /// </summary>
  RevisionProperty = unchecked((int)3),
  /// <summary>
  /// Paragraph number changed.
  /// </summary>
  RevisionParagraphNumber = unchecked((int)4),
  /// <summary>
  /// Field display changed.
  /// </summary>
  RevisionDisplayField = unchecked((int)5),
  /// <summary>
  /// Revision marked as reconciled conflict.
  /// </summary>
  RevisionReconcile = unchecked((int)6),
  /// <summary>
  /// Revision marked as a conflict.
  /// </summary>
  RevisionConflict = unchecked((int)7),
  /// <summary>
  /// Style changed.
  /// </summary>
  RevisionStyle = unchecked((int)8),
  /// <summary>
  /// Replaced.
  /// </summary>
  RevisionReplace = unchecked((int)9),
  /// <summary>
  /// Paragraph property changed. [System.Runtime.InteropServices.Guid("22EE5D98-3D02-3761-AD43-435C8CF763B0")]
  /// public enum WdRevisionType ﾉ Expand table
  /// </summary>
  RevisionParagraphProperty = unchecked((int)10),
  /// <summary>
  /// Table property changed.
  /// </summary>
  RevisionTableProperty = unchecked((int)11),
  /// <summary>
  /// Section property changed.
  /// </summary>
  RevisionSectionProperty = unchecked((int)12),
  /// <summary>
  /// Style definition changed.
  /// </summary>
  RevisionStyleDefinition = unchecked((int)13),
  /// <summary>
  /// Content moved from.
  /// </summary>
  RevisionMovedFrom = unchecked((int)14),
  /// <summary>
  /// Content moved to.
  /// </summary>
  RevisionMovedTo = unchecked((int)15),
  /// <summary>
  /// Table cell inserted.
  /// </summary>
  RevisionCellInsertion = unchecked((int)16),
  /// <summary>
  /// Table cell deleted.
  /// </summary>
  RevisionCellDeletion = unchecked((int)17),
  /// <summary>
  /// Table cells merged.
  /// </summary>
  RevisionCellMerge = unchecked((int)18),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  RevisionCellSplit = unchecked((int)19),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  RevisionConflictInsert = unchecked((int)20),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  RevisionConflictDelete = unchecked((int)21)
}
