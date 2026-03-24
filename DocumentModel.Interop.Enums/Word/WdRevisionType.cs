namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of a change that is marked with a revision mark.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisiontype?view=office-pia` for Office interop details.
/// </remarks>
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
  /// Paragraph property changed.
  /// </summary>
  RevisionParagraphProperty = 10,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionTableProperty = 11,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionSectionProperty = 12,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionStyleDefinition = 13,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionMovedFrom = 14,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionMovedTo = 15,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionCellInsertion = 16,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionCellDeletion = 17,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionCellMerge = 18,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionCellSplit = 19,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionConflictInsert = 20,
  /// <summary>
  /// Specifies the type of a change that is marked with a revision mark.
  /// </summary>
  RevisionConflictDelete = 21
}
