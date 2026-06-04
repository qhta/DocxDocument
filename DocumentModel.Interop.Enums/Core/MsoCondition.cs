
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines the condition for comparison between a file and a specified property in a file search.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocondition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoCondition))]
public enum Condition
{
  /// <summary>
  /// File can be any type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeAllFiles))]
  FileTypeAllFiles = 1,
  /// <summary>
  /// File can be any Office file type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeOfficeFiles))]
  FileTypeOfficeFiles,
  /// <summary>
  /// Word document.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeWordDocuments))]
  FileTypeWordDocuments,
  /// <summary>
  /// Excel workbook.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeExcelWorkbooks))]
  FileTypeExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypePowerPointPresentations))]
  FileTypePowerPointPresentations,
  /// <summary>
  /// Binder file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeBinders))]
  FileTypeBinders,
  /// <summary>
  /// Database.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeDatabases))]
  FileTypeDatabases,
  /// <summary>
  /// Template.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeTemplates))]
  FileTypeTemplates,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIncludes))]
  Includes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the phrase specified
  /// in the value specified in
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIncludesPhrase))]
  IncludesPhrase,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object begins with the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionBeginsWith))]
  BeginsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object ends with the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEndsWith))]
  EndsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object and the value specified in
  /// the Value property of the PropertyTest object are near each other.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIncludesNearEachOther))]
  IncludesNearEachOther,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is exactly the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIsExactly))]
  IsExactly,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is not the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIsNot))]
  IsNot,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is yesterday.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionYesterday))]
  Yesterday,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is today.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionToday))]
  Today,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is tomorrow.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionTomorrow))]
  Tomorrow,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last week.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionLastWeek))]
  LastWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this week.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionThisWeek))]
  ThisWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next week.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNextWeek))]
  NextWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last month.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionLastMonth))]
  LastMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this month.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionThisMonth))]
  ThisMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next month.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNextMonth))]
  NextMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object can be any time.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionAnytime))]
  Anytime,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is between the dates specified with the Value
  /// and SecondValue properties of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionAnytimeBetween))]
  AnytimeBetween,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is the same as the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionOn))]
  On,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or after the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionOnOrAfter))]
  OnOrAfter,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or before the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionOnOrBefore))]
  OnOrBefore,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the next time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionInTheNext))]
  InTheNext,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionInTheLast))]
  InTheLast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object equals the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEquals))]
  Equals,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object does not equal the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionDoesNotEqual))]
  DoesNotEqual,
  /// <summary>
  /// Any number between values specified with the Value and SecondValue properties of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionAnyNumberBetween))]
  AnyNumberBetween,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at most the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionAtMost))]
  AtMost,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at least the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionAtLeast))]
  AtLeast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is more than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionMoreThan))]
  MoreThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is less than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionLessThan))]
  LessThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "True".
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIsYes))]
  IsYes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "False".
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIsNo))]
  IsNo,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes forms of the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionIncludesFormsOf))]
  IncludesFormsOf,
  /// <summary>
  /// Value of the file property specified in the Name property of the PropertyTest object matches the value
  /// specified in the Value property of the PropertyTest object when a FreeText search is used.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFreeText))]
  FreeText,
  /// <summary>
  /// Outlook item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeOutlookItems))]
  FileTypeOutlookItems,
  /// <summary>
  /// Mail item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeMailItem))]
  FileTypeMailItem,
  /// <summary>
  /// Calendar item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeCalendarItem))]
  FileTypeCalendarItem,
  /// <summary>
  /// Contact item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeContactItem))]
  FileTypeContactItem,
  /// <summary>
  /// Note item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeNoteItem))]
  FileTypeNoteItem,
  /// <summary>
  /// Journal item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeJournalItem))]
  FileTypeJournalItem,
  /// <summary>
  /// Task item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeTaskItem))]
  FileTypeTaskItem,
  /// <summary>
  /// PhotoDraw file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypePhotoDrawFiles))]
  FileTypePhotoDrawFiles,
  /// <summary>
  /// Data connection file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeDataConnectionFiles))]
  FileTypeDataConnectionFiles,
  /// <summary>
  /// Publisher file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypePublisherFiles))]
  FileTypePublisherFiles,
  /// <summary>
  /// Project file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeProjectFiles))]
  FileTypeProjectFiles,
  /// <summary>
  /// Document imaging file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeDocumentImagingFiles))]
  FileTypeDocumentImagingFiles,
  /// <summary>
  /// Visio file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeVisioFiles))]
  FileTypeVisioFiles,
  /// <summary>
  /// Designer file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeDesignerFiles))]
  FileTypeDesignerFiles,
  /// <summary>
  /// Web page.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionFileTypeWebPages))]
  FileTypeWebPages,
  /// <summary>
  /// Priority equals "Low". Value of the Name property must be Priority.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsLow))]
  EqualsLow,
  /// <summary>
  /// Priority equals "Normal". Value of the Name property must be Priority.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsNormal))]
  EqualsNormal,
  /// <summary>
  /// Priority equals "High". Value of the Name property must be Priority.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsHigh))]
  EqualsHigh,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Low". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToLow))]
  NotEqualToLow,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Normal".
  /// Value of the Name property must be Priority or Importance.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToNormal))]
  NotEqualToNormal,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "High". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToHigh))]
  NotEqualToHigh,
  /// <summary>
  /// Status equals "Not Started". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsNotStarted))]
  EqualsNotStarted,
  /// <summary>
  /// Status equals "In Progress". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsInProgress))]
  EqualsInProgress,
  /// <summary>
  /// Status equals "Completed". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsCompleted))]
  EqualsCompleted,
  /// <summary>
  /// Status equals "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsWaitingForSomeoneElse))]
  EqualsWaitingForSomeoneElse,
  /// <summary>
  /// Status equals "Deferred". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionEqualsDeferred))]
  EqualsDeferred,
  /// <summary>
  /// Status does not equal "Not Started". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToNotStarted))]
  NotEqualToNotStarted,
  /// <summary>
  /// Status does not equal "In Progress". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToInProgress))]
  NotEqualToInProgress,
  /// <summary>
  /// Status does not equal "Completed". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToCompleted))]
  NotEqualToCompleted,
  /// <summary>
  /// Status does not equal "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToWaitingForSomeoneElse))]
  NotEqualToWaitingForSomeoneElse,
  /// <summary>
  /// Status does not equal "Deferred". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoCondition.msoConditionNotEqualToDeferred))]
  NotEqualToDeferred
}
