namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of a change that is marked with a revision mark.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisiontype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRevisionType")]
public enum RevisionType
{
  /// <summary>
  /// No revision.
  /// </summary>
  [WordInteropEnumValue("wdNoRevision")]
  NoRevision = 0,
  /// <summary>
  /// Insertion.
  /// </summary>
  [WordInteropEnumValue("wdRevisionInsert")]
  RevisionInsert = 1,
  /// <summary>
  /// Deletion.
  /// </summary>
  [WordInteropEnumValue("wdRevisionDelete")]
  RevisionDelete = 2,
  /// <summary>
  /// Property changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionProperty")]
  RevisionProperty = 3,
  /// <summary>
  /// Paragraph number changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionParagraphNumber")]
  RevisionParagraphNumber = 4,
  /// <summary>
  /// Field display changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionDisplayField")]
  RevisionDisplayField = 5,
  /// <summary>
  /// Revision marked as reconciled conflict.
  /// </summary>
  [WordInteropEnumValue("wdRevisionReconcile")]
  RevisionReconcile = 6,
  /// <summary>
  /// Revision marked as a conflict.
  /// </summary>
  [WordInteropEnumValue("wdRevisionConflict")]
  RevisionConflict = 7,
  /// <summary>
  /// Style changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionStyle")]
  RevisionStyle = 8,
  /// <summary>
  /// Replaced.
  /// </summary>
  [WordInteropEnumValue("wdRevisionReplace")]
  RevisionReplace = 9,
  /// <summary>
  /// Paragraph property changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionParagraphProperty")]
  RevisionParagraphProperty = 10,
  /// <summary>
  /// Table property changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionTableProperty")]
  RevisionTableProperty = 11,
  /// <summary>
  /// Section property changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionSectionProperty")]
  RevisionSectionProperty = 12,
  /// <summary>
  /// Style definition changed.
  /// </summary>
  [WordInteropEnumValue("wdRevisionStyleDefinition")]
  RevisionStyleDefinition = 13,
  /// <summary>
  /// Content moved from.
  /// </summary>
  [WordInteropEnumValue("wdRevisionMovedFrom")]
  RevisionMovedFrom = 14,
  /// <summary>
  /// Content moved to.
  /// </summary>
  [WordInteropEnumValue("wdRevisionMovedTo")]
  RevisionMovedTo = 15,
  /// <summary>
  /// Table cell inserted.
  /// </summary>
  [WordInteropEnumValue("wdRevisionCellInsertion")]
  RevisionCellInsertion = 16,
  /// <summary>
  /// Table cell deleted.
  /// </summary>
  [WordInteropEnumValue("wdRevisionCellDeletion")]
  RevisionCellDeletion = 17,
  /// <summary>
  /// Table cells merged.
  /// </summary>
  [WordInteropEnumValue("wdRevisionCellMerge")]
  RevisionCellMerge = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdRevisionCellSplit")]
  RevisionCellSplit = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdRevisionConflictInsert")]
  RevisionConflictInsert = 20,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue("wdRevisionConflictDelete")]
  RevisionConflictDelete = 21
}
