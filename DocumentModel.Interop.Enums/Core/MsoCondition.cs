
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines the condition for comparison between a file and a specified property in a file search.
/// </summary>
public enum MsoCondition
{
  /// <summary>
  /// File can be any type.
  /// </summary>
  msoConditionFileTypeAllFiles = 1,
  /// <summary>
  /// File can be any Office file type.
  /// </summary>
  msoConditionFileTypeOfficeFiles,
  /// <summary>
  /// Word document.
  /// </summary>
  msoConditionFileTypeWordDocuments,
  /// <summary>
  /// Excel workbook. msoConditionFileTypePowerPointPresentations5 PowerPoint presentation.
  /// </summary>
  msoConditionFileTypeExcelWorkbooks,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionFileTypePowerPointPresentations,
  /// <summary>
  /// Binder file.
  /// </summary>
  msoConditionFileTypeBinders,
  /// <summary>
  /// Database.
  /// </summary>
  msoConditionFileTypeDatabases,
  /// <summary>
  /// Template.
  /// </summary>
  msoConditionFileTypeTemplates,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionIncludes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the phrase specified
  /// in the value specified in public enum class MsoCondition ﾉ Expand table the Value property of the PropertyTest
  /// object.
  /// </summary>
  msoConditionIncludesPhrase,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object begins with the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionBeginsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object ends with the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionEndsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object and the value specified in
  /// the Value property of the PropertyTest object are near each other.
  /// </summary>
  msoConditionIncludesNearEachOther,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is exactly the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionIsExactly,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is not the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  msoConditionIsNot,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is yesterday.
  /// </summary>
  msoConditionYesterday,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is today.
  /// </summary>
  msoConditionToday,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is tomorrow.
  /// </summary>
  msoConditionTomorrow,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last week.
  /// </summary>
  msoConditionLastWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this week.
  /// </summary>
  msoConditionThisWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next week.
  /// </summary>
  msoConditionNextWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last month.
  /// </summary>
  msoConditionLastMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this month.
  /// </summary>
  msoConditionThisMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next month.
  /// </summary>
  msoConditionNextMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object can be any time.
  /// </summary>
  msoConditionAnytime,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is between the dates specified with the Value
  /// and SecondValue properties of the PropertyTest object.
  /// </summary>
  msoConditionAnytimeBetween,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is the same as the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  msoConditionOn,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or after the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  msoConditionOnOrAfter,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or before the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  msoConditionOnOrBefore,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the next time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  msoConditionInTheNext,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  msoConditionInTheLast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object equals the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  msoConditionEquals,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object does not equal the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionDoesNotEqual,
  /// <summary>
  /// Any number between values specified with the Value and SecondValue properties of the PropertyTest object.
  /// </summary>
  msoConditionAnyNumberBetween,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at most the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionAtMost,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at least the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionAtLeast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is more than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionMoreThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is less than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionLessThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "True".
  /// </summary>
  msoConditionIsYes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "False".
  /// </summary>
  msoConditionIsNo,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes forms of the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  msoConditionIncludesFormsOf,
  /// <summary>
  /// Value of the file property specified in the Name property of the PropertyTest object matches the value
  /// specified in the Value property of the PropertyTest object when a FreeText search is used.
  /// </summary>
  msoConditionFreeText,
  /// <summary>
  /// Outlook item.
  /// </summary>
  msoConditionFileTypeOutlookItems,
  /// <summary>
  /// Mail item.
  /// </summary>
  msoConditionFileTypeMailItem,
  /// <summary>
  /// Calendar item.
  /// </summary>
  msoConditionFileTypeCalendarItem,
  /// <summary>
  /// Contact item.
  /// </summary>
  msoConditionFileTypeContactItem,
  /// <summary>
  /// Note item.
  /// </summary>
  msoConditionFileTypeNoteItem,
  /// <summary>
  /// Journal item.
  /// </summary>
  msoConditionFileTypeJournalItem,
  /// <summary>
  /// Task item.
  /// </summary>
  msoConditionFileTypeTaskItem,
  /// <summary>
  /// PhotoDraw file.
  /// </summary>
  msoConditionFileTypePhotoDrawFiles,
  /// <summary>
  /// Data connection file.
  /// </summary>
  msoConditionFileTypeDataConnectionFiles,
  /// <summary>
  /// Publisher file.
  /// </summary>
  msoConditionFileTypePublisherFiles,
  /// <summary>
  /// Project file. msoConditionFileTypeDocumentImagingFiles54 Document imaging file.
  /// </summary>
  msoConditionFileTypeProjectFiles,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionFileTypeDocumentImagingFiles,
  /// <summary>
  /// Visio file.
  /// </summary>
  msoConditionFileTypeVisioFiles,
  /// <summary>
  /// Designer file.
  /// </summary>
  msoConditionFileTypeDesignerFiles,
  /// <summary>
  /// Web page.
  /// </summary>
  msoConditionFileTypeWebPages,
  /// <summary>
  /// Priority equals "Low". Value of the Name property must be Priority.
  /// </summary>
  msoConditionEqualsLow,
  /// <summary>
  /// Priority equals "Normal". Value of the Name property must be Priority.
  /// </summary>
  msoConditionEqualsNormal,
  /// <summary>
  /// Priority equals "High". Value of the Name property must be Priority.
  /// </summary>
  msoConditionEqualsHigh,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Low". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  msoConditionNotEqualToLow,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Normal".
  /// Value of the Name property must be Priority or Importance.
  /// </summary>
  msoConditionNotEqualToNormal,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "High". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  msoConditionNotEqualToHigh,
  /// <summary>
  /// Status equals "Not Started". Value of the Name property must be Status.
  /// </summary>
  msoConditionEqualsNotStarted,
  /// <summary>
  /// Status equals "In Progress". Value of the Name property must be Status.
  /// </summary>
  msoConditionEqualsInProgress,
  /// <summary>
  /// Status equals "Completed". Value of the Name property must be Status.
  /// msoConditionEqualsWaitingForSomeoneElse67 Status equals "Waiting for Someone Else". Value of the Name property
  /// must be Status.
  /// </summary>
  msoConditionEqualsCompleted,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionEqualsWaitingForSomeoneElse,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionEqualsDeferred,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionNotEqualToNotStarted,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionNotEqualToInProgress,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionNotEqualToCompleted,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionNotEqualToWaitingForSomeoneElse,
  /// <summary>
  /// Defines the condition for comparison between a file and a specified property in a file search.
  /// </summary>
  msoConditionNotEqualToDeferred
}
