namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of a change that is marked with a revision mark.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisiontype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRevisionType))]
public enum RevisionType
{
  /// <summary>
  /// No revision.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdNoRevision))]
  NoRevision = 0,
  /// <summary>
  /// Insertion.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionInsert))]
  RevisionInsert = 1,
  /// <summary>
  /// Deletion.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionDelete))]
  RevisionDelete = 2,
  /// <summary>
  /// Property changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionProperty))]
  RevisionProperty = 3,
  /// <summary>
  /// Paragraph number changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionParagraphNumber))]
  RevisionParagraphNumber = 4,
  /// <summary>
  /// Field display changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionDisplayField))]
  RevisionDisplayField = 5,
  /// <summary>
  /// Revision marked as reconciled conflict.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionReconcile))]
  RevisionReconcile = 6,
  /// <summary>
  /// Revision marked as a conflict.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionConflict))]
  RevisionConflict = 7,
  /// <summary>
  /// Style changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionStyle))]
  RevisionStyle = 8,
  /// <summary>
  /// Replaced.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionReplace))]
  RevisionReplace = 9,
  /// <summary>
  /// Paragraph property changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionParagraphProperty))]
  RevisionParagraphProperty = 10,
  /// <summary>
  /// Table property changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionTableProperty))]
  RevisionTableProperty = 11,
  /// <summary>
  /// Section property changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionSectionProperty))]
  RevisionSectionProperty = 12,
  /// <summary>
  /// Style definition changed.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionStyleDefinition))]
  RevisionStyleDefinition = 13,
  /// <summary>
  /// Content moved from.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionMovedFrom))]
  RevisionMovedFrom = 14,
  /// <summary>
  /// Content moved to.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionMovedTo))]
  RevisionMovedTo = 15,
  /// <summary>
  /// Table cell inserted.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionCellInsertion))]
  RevisionCellInsertion = 16,
  /// <summary>
  /// Table cell deleted.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionCellDeletion))]
  RevisionCellDeletion = 17,
  /// <summary>
  /// Table cells merged.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionCellMerge))]
  RevisionCellMerge = 18,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionCellSplit))]
  RevisionCellSplit = 19,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionConflictInsert))]
  RevisionConflictInsert = 20,
  /// <summary>
  /// Reserved for internal use.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisionType.wdRevisionConflictDelete))]
  RevisionConflictDelete = 21
}
