namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of a change that is marked with a revision mark.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisiontype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRevisionType")]
public enum RevisionType
{
  /// <summary>
  /// No revision.
  /// </summary>
  [InteropEnumValue("wdNoRevision")]
  NoRevision = 0,
  /// <summary>
  /// Insertion.
  /// </summary>
  [InteropEnumValue("wdRevisionInsert")]
  RevisionInsert = 1,
  /// <summary>
  /// Deletion.
  /// </summary>
  [InteropEnumValue("wdRevisionDelete")]
  RevisionDelete = 2,
  /// <summary>
  /// Property changed.
  /// </summary>
  [InteropEnumValue("wdRevisionProperty")]
  RevisionProperty = 3,
  /// <summary>
  /// Paragraph number changed.
  /// </summary>
  [InteropEnumValue("wdRevisionParagraphNumber")]
  RevisionParagraphNumber = 4,
  /// <summary>
  /// Field display changed.
  /// </summary>
  [InteropEnumValue("wdRevisionDisplayField")]
  RevisionDisplayField = 5,
  /// <summary>
  /// Revision marked as reconciled conflict.
  /// </summary>
  [InteropEnumValue("wdRevisionReconcile")]
  RevisionReconcile = 6,
  /// <summary>
  /// Revision marked as a conflict.
  /// </summary>
  [InteropEnumValue("wdRevisionConflict")]
  RevisionConflict = 7,
  /// <summary>
  /// Style changed.
  /// </summary>
  [InteropEnumValue("wdRevisionStyle")]
  RevisionStyle = 8,
  /// <summary>
  /// Replaced.
  /// </summary>
  [InteropEnumValue("wdRevisionReplace")]
  RevisionReplace = 9,
  /// <summary>
  /// Paragraph property changed.
  /// </summary>
  [InteropEnumValue("wdRevisionParagraphProperty")]
  RevisionParagraphProperty = 10,
  /// <summary>
  /// Table property changed.
  /// </summary>
  [InteropEnumValue("wdRevisionTableProperty")]
  RevisionTableProperty = 11,
  /// <summary>
  /// Section property changed.
  /// </summary>
  [InteropEnumValue("wdRevisionSectionProperty")]
  RevisionSectionProperty = 12,
  /// <summary>
  /// Style definition changed.
  /// </summary>
  [InteropEnumValue("wdRevisionStyleDefinition")]
  RevisionStyleDefinition = 13,
  /// <summary>
  /// Content moved from.
  /// </summary>
  [InteropEnumValue("wdRevisionMovedFrom")]
  RevisionMovedFrom = 14,
  /// <summary>
  /// Content moved to.
  /// </summary>
  [InteropEnumValue("wdRevisionMovedTo")]
  RevisionMovedTo = 15,
  /// <summary>
  /// Table cell inserted.
  /// </summary>
  [InteropEnumValue("wdRevisionCellInsertion")]
  RevisionCellInsertion = 16,
  /// <summary>
  /// Table cell deleted.
  /// </summary>
  [InteropEnumValue("wdRevisionCellDeletion")]
  RevisionCellDeletion = 17,
  /// <summary>
  /// Table cells merged.
  /// </summary>
  [InteropEnumValue("wdRevisionCellMerge")]
  RevisionCellMerge = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdRevisionCellSplit")]
  RevisionCellSplit = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdRevisionConflictInsert")]
  RevisionConflictInsert = 20,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [InteropEnumValue("wdRevisionConflictDelete")]
  RevisionConflictDelete = 21
}
