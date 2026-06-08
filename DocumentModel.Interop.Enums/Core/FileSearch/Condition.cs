
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines the condition for comparison between a file and a specified property in a file search.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocondition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoCondition")]
public enum Condition
{
  /// <summary>
  /// File can be any type.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeAllFiles")]
  FileTypeAllFiles = 1,
  /// <summary>
  /// File can be any Office file type.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeOfficeFiles")]
  FileTypeOfficeFiles,
  /// <summary>
  /// Word document.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeWordDocuments")]
  FileTypeWordDocuments,
  /// <summary>
  /// Excel workbook.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeExcelWorkbooks")]
  FileTypeExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypePowerPointPresentations")]
  FileTypePowerPointPresentations,
  /// <summary>
  /// Binder file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeBinders")]
  FileTypeBinders,
  /// <summary>
  /// Database.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeDatabases")]
  FileTypeDatabases,
  /// <summary>
  /// Template.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeTemplates")]
  FileTypeTemplates,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionIncludes")]
  Includes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the phrase specified
  /// in the value specified in
  /// </summary>
  [InteropEnumValue("msoConditionIncludesPhrase")]
  IncludesPhrase,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object begins with the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionBeginsWith")]
  BeginsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object ends with the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionEndsWith")]
  EndsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object and the value specified in
  /// the Value property of the PropertyTest object are near each other.
  /// </summary>
  [InteropEnumValue("msoConditionIncludesNearEachOther")]
  IncludesNearEachOther,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is exactly the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionIsExactly")]
  IsExactly,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is not the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionIsNot")]
  IsNot,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is yesterday.
  /// </summary>
  [InteropEnumValue("msoConditionYesterday")]
  Yesterday,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is today.
  /// </summary>
  [InteropEnumValue("msoConditionToday")]
  Today,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is tomorrow.
  /// </summary>
  [InteropEnumValue("msoConditionTomorrow")]
  Tomorrow,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last week.
  /// </summary>
  [InteropEnumValue("msoConditionLastWeek")]
  LastWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this week.
  /// </summary>
  [InteropEnumValue("msoConditionThisWeek")]
  ThisWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next week.
  /// </summary>
  [InteropEnumValue("msoConditionNextWeek")]
  NextWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last month.
  /// </summary>
  [InteropEnumValue("msoConditionLastMonth")]
  LastMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this month.
  /// </summary>
  [InteropEnumValue("msoConditionThisMonth")]
  ThisMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next month.
  /// </summary>
  [InteropEnumValue("msoConditionNextMonth")]
  NextMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object can be any time.
  /// </summary>
  [InteropEnumValue("msoConditionAnytime")]
  Anytime,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is between the dates specified with the Value
  /// and SecondValue properties of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionAnytimeBetween")]
  AnytimeBetween,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is the same as the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionOn")]
  On,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or after the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionOnOrAfter")]
  OnOrAfter,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or before the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionOnOrBefore")]
  OnOrBefore,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the next time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionInTheNext")]
  InTheNext,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionInTheLast")]
  InTheLast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object equals the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionEquals")]
  Equals,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object does not equal the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionDoesNotEqual")]
  DoesNotEqual,
  /// <summary>
  /// Any number between values specified with the Value and SecondValue properties of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionAnyNumberBetween")]
  AnyNumberBetween,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at most the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionAtMost")]
  AtMost,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at least the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionAtLeast")]
  AtLeast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is more than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionMoreThan")]
  MoreThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is less than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionLessThan")]
  LessThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "True".
  /// </summary>
  [InteropEnumValue("msoConditionIsYes")]
  IsYes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "False".
  /// </summary>
  [InteropEnumValue("msoConditionIsNo")]
  IsNo,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes forms of the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [InteropEnumValue("msoConditionIncludesFormsOf")]
  IncludesFormsOf,
  /// <summary>
  /// Value of the file property specified in the Name property of the PropertyTest object matches the value
  /// specified in the Value property of the PropertyTest object when a FreeText search is used.
  /// </summary>
  [InteropEnumValue("msoConditionFreeText")]
  FreeText,
  /// <summary>
  /// Outlook item.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeOutlookItems")]
  FileTypeOutlookItems,
  /// <summary>
  /// Mail item.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeMailItem")]
  FileTypeMailItem,
  /// <summary>
  /// Calendar item.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeCalendarItem")]
  FileTypeCalendarItem,
  /// <summary>
  /// Contact item.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeContactItem")]
  FileTypeContactItem,
  /// <summary>
  /// Note item.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeNoteItem")]
  FileTypeNoteItem,
  /// <summary>
  /// Journal item.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeJournalItem")]
  FileTypeJournalItem,
  /// <summary>
  /// Task item.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeTaskItem")]
  FileTypeTaskItem,
  /// <summary>
  /// PhotoDraw file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypePhotoDrawFiles")]
  FileTypePhotoDrawFiles,
  /// <summary>
  /// Data connection file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeDataConnectionFiles")]
  FileTypeDataConnectionFiles,
  /// <summary>
  /// Publisher file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypePublisherFiles")]
  FileTypePublisherFiles,
  /// <summary>
  /// Project file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeProjectFiles")]
  FileTypeProjectFiles,
  /// <summary>
  /// Document imaging file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeDocumentImagingFiles")]
  FileTypeDocumentImagingFiles,
  /// <summary>
  /// Visio file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeVisioFiles")]
  FileTypeVisioFiles,
  /// <summary>
  /// Designer file.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeDesignerFiles")]
  FileTypeDesignerFiles,
  /// <summary>
  /// Web page.
  /// </summary>
  [InteropEnumValue("msoConditionFileTypeWebPages")]
  FileTypeWebPages,
  /// <summary>
  /// Priority equals "Low". Value of the Name property must be Priority.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsLow")]
  EqualsLow,
  /// <summary>
  /// Priority equals "Normal". Value of the Name property must be Priority.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsNormal")]
  EqualsNormal,
  /// <summary>
  /// Priority equals "High". Value of the Name property must be Priority.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsHigh")]
  EqualsHigh,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Low". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToLow")]
  NotEqualToLow,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Normal".
  /// Value of the Name property must be Priority or Importance.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToNormal")]
  NotEqualToNormal,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "High". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToHigh")]
  NotEqualToHigh,
  /// <summary>
  /// Status equals "Not Started". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsNotStarted")]
  EqualsNotStarted,
  /// <summary>
  /// Status equals "In Progress". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsInProgress")]
  EqualsInProgress,
  /// <summary>
  /// Status equals "Completed". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsCompleted")]
  EqualsCompleted,
  /// <summary>
  /// Status equals "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsWaitingForSomeoneElse")]
  EqualsWaitingForSomeoneElse,
  /// <summary>
  /// Status equals "Deferred". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionEqualsDeferred")]
  EqualsDeferred,
  /// <summary>
  /// Status does not equal "Not Started". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToNotStarted")]
  NotEqualToNotStarted,
  /// <summary>
  /// Status does not equal "In Progress". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToInProgress")]
  NotEqualToInProgress,
  /// <summary>
  /// Status does not equal "Completed". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToCompleted")]
  NotEqualToCompleted,
  /// <summary>
  /// Status does not equal "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToWaitingForSomeoneElse")]
  NotEqualToWaitingForSomeoneElse,
  /// <summary>
  /// Status does not equal "Deferred". Value of the Name property must be Status.
  /// </summary>
  [InteropEnumValue("msoConditionNotEqualToDeferred")]
  NotEqualToDeferred
}
