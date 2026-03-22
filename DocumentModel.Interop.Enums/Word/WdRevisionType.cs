namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of a change that is marked with a revision mark.
/// </summary>
public enum WdRevisionType
{
  /// <summary>
  /// No revision.
  /// </summary>
  wdNoRevision = unchecked((int)0),
  /// <summary>
  /// Insertion.
  /// </summary>
  wdRevisionInsert = unchecked((int)1),
  /// <summary>
  /// Deletion.
  /// </summary>
  wdRevisionDelete = unchecked((int)2),
  /// <summary>
  /// Property changed.
  /// </summary>
  wdRevisionProperty = unchecked((int)3),
  /// <summary>
  /// Paragraph number changed.
  /// </summary>
  wdRevisionParagraphNumber = unchecked((int)4),
  /// <summary>
  /// Field display changed.
  /// </summary>
  wdRevisionDisplayField = unchecked((int)5),
  /// <summary>
  /// Revision marked as reconciled conflict.
  /// </summary>
  wdRevisionReconcile = unchecked((int)6),
  /// <summary>
  /// Revision marked as a conflict.
  /// </summary>
  wdRevisionConflict = unchecked((int)7),
  /// <summary>
  /// Style changed.
  /// </summary>
  wdRevisionStyle = unchecked((int)8),
  /// <summary>
  /// Replaced.
  /// </summary>
  wdRevisionReplace = unchecked((int)9),
  /// <summary>
  /// Paragraph property changed. [System.Runtime.InteropServices.Guid("22EE5D98-3D02-3761-AD43-435C8CF763B0")]
  /// public enum WdRevisionType ﾉ Expand table
  /// </summary>
  wdRevisionParagraphProperty = unchecked((int)10),
  /// <summary>
  /// Table property changed.
  /// </summary>
  wdRevisionTableProperty = unchecked((int)11),
  /// <summary>
  /// Section property changed.
  /// </summary>
  wdRevisionSectionProperty = unchecked((int)12),
  /// <summary>
  /// Style definition changed.
  /// </summary>
  wdRevisionStyleDefinition = unchecked((int)13),
  /// <summary>
  /// Content moved from.
  /// </summary>
  wdRevisionMovedFrom = unchecked((int)14),
  /// <summary>
  /// Content moved to.
  /// </summary>
  wdRevisionMovedTo = unchecked((int)15),
  /// <summary>
  /// Table cell inserted.
  /// </summary>
  wdRevisionCellInsertion = unchecked((int)16),
  /// <summary>
  /// Table cell deleted.
  /// </summary>
  wdRevisionCellDeletion = unchecked((int)17),
  /// <summary>
  /// Table cells merged.
  /// </summary>
  wdRevisionCellMerge = unchecked((int)18),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdRevisionCellSplit = unchecked((int)19),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdRevisionConflictInsert = unchecked((int)20),
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  wdRevisionConflictDelete = unchecked((int)21)
}
