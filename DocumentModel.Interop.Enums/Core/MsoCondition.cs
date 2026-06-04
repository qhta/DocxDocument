
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines the condition for comparison between a file and a specified property in a file search.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocondition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoCondition")]
public enum Condition
{
  /// <summary>
  /// File can be any type.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeAllFiles")]
  FileTypeAllFiles = 1,
  /// <summary>
  /// File can be any Office file type.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeOfficeFiles")]
  FileTypeOfficeFiles,
  /// <summary>
  /// Word document.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeWordDocuments")]
  FileTypeWordDocuments,
  /// <summary>
  /// Excel workbook.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeExcelWorkbooks")]
  FileTypeExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypePowerPointPresentations")]
  FileTypePowerPointPresentations,
  /// <summary>
  /// Binder file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeBinders")]
  FileTypeBinders,
  /// <summary>
  /// Database.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeDatabases")]
  FileTypeDatabases,
  /// <summary>
  /// Template.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeTemplates")]
  FileTypeTemplates,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIncludes")]
  Includes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the phrase specified
  /// in the value specified in
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIncludesPhrase")]
  IncludesPhrase,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object begins with the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionBeginsWith")]
  BeginsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object ends with the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEndsWith")]
  EndsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object and the value specified in
  /// the Value property of the PropertyTest object are near each other.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIncludesNearEachOther")]
  IncludesNearEachOther,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is exactly the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIsExactly")]
  IsExactly,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is not the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIsNot")]
  IsNot,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is yesterday.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionYesterday")]
  Yesterday,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is today.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionToday")]
  Today,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is tomorrow.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionTomorrow")]
  Tomorrow,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last week.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionLastWeek")]
  LastWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this week.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionThisWeek")]
  ThisWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next week.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNextWeek")]
  NextWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last month.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionLastMonth")]
  LastMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this month.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionThisMonth")]
  ThisMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next month.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNextMonth")]
  NextMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object can be any time.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionAnytime")]
  Anytime,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is between the dates specified with the Value
  /// and SecondValue properties of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionAnytimeBetween")]
  AnytimeBetween,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is the same as the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionOn")]
  On,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or after the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionOnOrAfter")]
  OnOrAfter,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or before the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionOnOrBefore")]
  OnOrBefore,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the next time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionInTheNext")]
  InTheNext,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionInTheLast")]
  InTheLast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object equals the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEquals")]
  Equals,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object does not equal the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionDoesNotEqual")]
  DoesNotEqual,
  /// <summary>
  /// Any number between values specified with the Value and SecondValue properties of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionAnyNumberBetween")]
  AnyNumberBetween,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at most the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionAtMost")]
  AtMost,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at least the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionAtLeast")]
  AtLeast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is more than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionMoreThan")]
  MoreThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is less than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionLessThan")]
  LessThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "True".
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIsYes")]
  IsYes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "False".
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIsNo")]
  IsNo,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes forms of the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionIncludesFormsOf")]
  IncludesFormsOf,
  /// <summary>
  /// Value of the file property specified in the Name property of the PropertyTest object matches the value
  /// specified in the Value property of the PropertyTest object when a FreeText search is used.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFreeText")]
  FreeText,
  /// <summary>
  /// Outlook item.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeOutlookItems")]
  FileTypeOutlookItems,
  /// <summary>
  /// Mail item.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeMailItem")]
  FileTypeMailItem,
  /// <summary>
  /// Calendar item.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeCalendarItem")]
  FileTypeCalendarItem,
  /// <summary>
  /// Contact item.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeContactItem")]
  FileTypeContactItem,
  /// <summary>
  /// Note item.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeNoteItem")]
  FileTypeNoteItem,
  /// <summary>
  /// Journal item.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeJournalItem")]
  FileTypeJournalItem,
  /// <summary>
  /// Task item.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeTaskItem")]
  FileTypeTaskItem,
  /// <summary>
  /// PhotoDraw file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypePhotoDrawFiles")]
  FileTypePhotoDrawFiles,
  /// <summary>
  /// Data connection file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeDataConnectionFiles")]
  FileTypeDataConnectionFiles,
  /// <summary>
  /// Publisher file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypePublisherFiles")]
  FileTypePublisherFiles,
  /// <summary>
  /// Project file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeProjectFiles")]
  FileTypeProjectFiles,
  /// <summary>
  /// Document imaging file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeDocumentImagingFiles")]
  FileTypeDocumentImagingFiles,
  /// <summary>
  /// Visio file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeVisioFiles")]
  FileTypeVisioFiles,
  /// <summary>
  /// Designer file.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeDesignerFiles")]
  FileTypeDesignerFiles,
  /// <summary>
  /// Web page.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionFileTypeWebPages")]
  FileTypeWebPages,
  /// <summary>
  /// Priority equals "Low". Value of the Name property must be Priority.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsLow")]
  EqualsLow,
  /// <summary>
  /// Priority equals "Normal". Value of the Name property must be Priority.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsNormal")]
  EqualsNormal,
  /// <summary>
  /// Priority equals "High". Value of the Name property must be Priority.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsHigh")]
  EqualsHigh,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Low". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToLow")]
  NotEqualToLow,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Normal".
  /// Value of the Name property must be Priority or Importance.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToNormal")]
  NotEqualToNormal,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "High". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToHigh")]
  NotEqualToHigh,
  /// <summary>
  /// Status equals "Not Started". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsNotStarted")]
  EqualsNotStarted,
  /// <summary>
  /// Status equals "In Progress". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsInProgress")]
  EqualsInProgress,
  /// <summary>
  /// Status equals "Completed". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsCompleted")]
  EqualsCompleted,
  /// <summary>
  /// Status equals "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsWaitingForSomeoneElse")]
  EqualsWaitingForSomeoneElse,
  /// <summary>
  /// Status equals "Deferred". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionEqualsDeferred")]
  EqualsDeferred,
  /// <summary>
  /// Status does not equal "Not Started". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToNotStarted")]
  NotEqualToNotStarted,
  /// <summary>
  /// Status does not equal "In Progress". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToInProgress")]
  NotEqualToInProgress,
  /// <summary>
  /// Status does not equal "Completed". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToCompleted")]
  NotEqualToCompleted,
  /// <summary>
  /// Status does not equal "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToWaitingForSomeoneElse")]
  NotEqualToWaitingForSomeoneElse,
  /// <summary>
  /// Status does not equal "Deferred". Value of the Name property must be Status.
  /// </summary>
  [OfficeInteropEnumValue("msoConditionNotEqualToDeferred")]
  NotEqualToDeferred
}
