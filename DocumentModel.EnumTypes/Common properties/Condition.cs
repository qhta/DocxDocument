
namespace DocumentModel.Properties;

/// <summary>
/// Defines the condition for comparison between a file and a specified property in a file search.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocondition?view=office-pia` for Office interop details.
/// </remarks>
public enum Condition
{
  /// <summary>
  /// File can be any type.
  /// </summary>
  FileTypeAllFiles = 1,
  /// <summary>
  /// File can be any Office file type.
  /// </summary>
  FileTypeOfficeFiles,
  /// <summary>
  /// Word document.
  /// </summary>
  FileTypeWordDocuments,
  /// <summary>
  /// Excel workbook.
  /// </summary>
  FileTypeExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation.
  /// </summary>
  FileTypePowerPointPresentations,
  /// <summary>
  /// Binder file.
  /// </summary>
  FileTypeBinders,
  /// <summary>
  /// Database.
  /// </summary>
  FileTypeDatabases,
  /// <summary>
  /// Template.
  /// </summary>
  FileTypeTemplates,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  Includes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes the phrase specified
  /// in the value specified in
  /// </summary>
  IncludesPhrase,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object begins with the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  BeginsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object ends with the value specified
  /// in the Value property of the PropertyTest object.
  /// </summary>
  EndsWith,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object and the value specified in
  /// the Value property of the PropertyTest object are near each other.
  /// </summary>
  IncludesNearEachOther,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is exactly the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  IsExactly,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is not the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  IsNot,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is yesterday.
  /// </summary>
  Yesterday,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is today.
  /// </summary>
  Today,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is tomorrow.
  /// </summary>
  Tomorrow,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last week.
  /// </summary>
  LastWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this week.
  /// </summary>
  ThisWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next week.
  /// </summary>
  NextWeek,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last month.
  /// </summary>
  LastMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is this month.
  /// </summary>
  ThisMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is next month.
  /// </summary>
  NextMonth,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object can be any time.
  /// </summary>
  Anytime,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is between the dates specified with the Value
  /// and SecondValue properties of the PropertyTest object.
  /// </summary>
  AnytimeBetween,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is the same as the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  On,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or after the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  OnOrAfter,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is on or before the date specified in the Value
  /// property of the PropertyTest object.
  /// </summary>
  OnOrBefore,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the next time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  InTheNext,
  /// <summary>
  /// Date specified in the Name property of the PropertyTest object is within the last time interval specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  InTheLast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object equals the value specified in
  /// the Value property of the PropertyTest object.
  /// </summary>
  Equals,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object does not equal the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  DoesNotEqual,
  /// <summary>
  /// Any number between values specified with the Value and SecondValue properties of the PropertyTest object.
  /// </summary>
  AnyNumberBetween,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at most the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  AtMost,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is at least the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  AtLeast,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is more than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  MoreThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is less than the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  LessThan,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "True".
  /// </summary>
  IsYes,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object is "False".
  /// </summary>
  IsNo,
  /// <summary>
  /// Value of the file property specified in Name property of the PropertyTest object includes forms of the value
  /// specified in the Value property of the PropertyTest object.
  /// </summary>
  IncludesFormsOf,
  /// <summary>
  /// Value of the file property specified in the Name property of the PropertyTest object matches the value
  /// specified in the Value property of the PropertyTest object when a FreeText search is used.
  /// </summary>
  FreeText,
  /// <summary>
  /// Outlook item.
  /// </summary>
  FileTypeOutlookItems,
  /// <summary>
  /// Mail item.
  /// </summary>
  FileTypeMailItem,
  /// <summary>
  /// Calendar item.
  /// </summary>
  FileTypeCalendarItem,
  /// <summary>
  /// Contact item.
  /// </summary>
  FileTypeContactItem,
  /// <summary>
  /// Note item.
  /// </summary>
  FileTypeNoteItem,
  /// <summary>
  /// Journal item.
  /// </summary>
  FileTypeJournalItem,
  /// <summary>
  /// Task item.
  /// </summary>
  FileTypeTaskItem,
  /// <summary>
  /// PhotoDraw file.
  /// </summary>
  FileTypePhotoDrawFiles,
  /// <summary>
  /// Data connection file.
  /// </summary>
  FileTypeDataConnectionFiles,
  /// <summary>
  /// Publisher file.
  /// </summary>
  FileTypePublisherFiles,
  /// <summary>
  /// Project file.
  /// </summary>
  FileTypeProjectFiles,
  /// <summary>
  /// Document imaging file.
  /// </summary>
  FileTypeDocumentImagingFiles,
  /// <summary>
  /// Visio file.
  /// </summary>
  FileTypeVisioFiles,
  /// <summary>
  /// Designer file.
  /// </summary>
  FileTypeDesignerFiles,
  /// <summary>
  /// Web page.
  /// </summary>
  FileTypeWebPages,
  /// <summary>
  /// Priority equals "Low". Value of the Name property must be Priority.
  /// </summary>
  EqualsLow,
  /// <summary>
  /// Priority equals "Normal". Value of the Name property must be Priority.
  /// </summary>
  EqualsNormal,
  /// <summary>
  /// Priority equals "High". Value of the Name property must be Priority.
  /// </summary>
  EqualsHigh,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Low". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  NotEqualToLow,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "Normal".
  /// Value of the Name property must be Priority or Importance.
  /// </summary>
  NotEqualToNormal,
  /// <summary>
  /// Value of file property specified in the Name property of the PropertyTest object does not equal "High". Value
  /// of the Name property must be Priority or Importance.
  /// </summary>
  NotEqualToHigh,
  /// <summary>
  /// Status equals "Not Started". Value of the Name property must be Status.
  /// </summary>
  EqualsNotStarted,
  /// <summary>
  /// Status equals "In Progress". Value of the Name property must be Status.
  /// </summary>
  EqualsInProgress,
  /// <summary>
  /// Status equals "Completed". Value of the Name property must be Status.
  /// </summary>
  EqualsCompleted,
  /// <summary>
  /// Status equals "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  EqualsWaitingForSomeoneElse,
  /// <summary>
  /// Status equals "Deferred". Value of the Name property must be Status.
  /// </summary>
  EqualsDeferred,
  /// <summary>
  /// Status does not equal "Not Started". Value of the Name property must be Status.
  /// </summary>
  NotEqualToNotStarted,
  /// <summary>
  /// Status does not equal "In Progress". Value of the Name property must be Status.
  /// </summary>
  NotEqualToInProgress,
  /// <summary>
  /// Status does not equal "Completed". Value of the Name property must be Status.
  /// </summary>
  NotEqualToCompleted,
  /// <summary>
  /// Status does not equal "Waiting for Someone Else". Value of the Name property must be Status.
  /// </summary>
  NotEqualToWaitingForSomeoneElse,
  /// <summary>
  /// Status does not equal "Deferred". Value of the Name property must be Status.
  /// </summary>
  NotEqualToDeferred
}
