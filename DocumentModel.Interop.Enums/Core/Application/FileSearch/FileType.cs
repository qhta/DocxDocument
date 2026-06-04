
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of file.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiletype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoFileType")]
public enum FileType
{
  /// <summary>
  /// All files.
  /// </summary>
  [InteropEnumValue("msoFileTypeAllFiles")]
  AllFiles = 1,
  /// <summary>
  /// Files with any of the following extensions: *.doc, *.xls, *.ppt, *.pps, *.obd, *.mdb, *.mpd, *.dot, *.xlt,
  /// *.pot, *.obt, *.htm, or *.html.
  /// </summary>
  [InteropEnumValue("msoFileTypeOfficeFiles")]
  OfficeFiles,
  /// <summary>
  /// Microsoft Word document file (*.doc).
  /// </summary>
  [InteropEnumValue("msoFileTypeWordDocuments")]
  WordDocuments,
  /// <summary>
  /// Microsoft Excel workbook (*.wbk).
  /// </summary>
  [InteropEnumValue("msoFileTypeExcelWorkbooks")]
  ExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation file (.ppt), PowerPoint template file (.pot), or PowerPoint slide show file (*.pps).
  /// </summary>
  [InteropEnumValue("msoFileTypePowerPointPresentations")]
  PowerPointPresentations,
  /// <summary>
  /// Microsoft Binder file (*.obd).
  /// </summary>
  [InteropEnumValue("msoFileTypeBinders")]
  Binders,
  /// <summary>
  /// Database file (*.mdb).
  /// </summary>
  [InteropEnumValue("msoFileTypeDatabases")]
  Databases,
  /// <summary>
  /// Microsoft PowerPoint template (.pot), Word template (.dot), Excel template (*.xlt).
  /// </summary>
  [InteropEnumValue("msoFileTypeTemplates")]
  Templates,
  /// <summary>
  /// Any Microsoft Outlook item file.
  /// </summary>
  [InteropEnumValue("msoFileTypeOutlookItems")]
  OutlookItems,
  /// <summary>
  /// Mail item file (*.msg).
  /// </summary>
  [InteropEnumValue("msoFileTypeMailItem")]
  MailItem,
  /// <summary>
  /// Calendar item file (*.ics or *.vsc).
  /// </summary>
  [InteropEnumValue("msoFileTypeCalendarItem")]
  CalendarItem,
  /// <summary>
  /// Contact item file (*.vcf).
  /// </summary>
  [InteropEnumValue("msoFileTypeContactItem")]
  ContactItem,
  /// <summary>
  /// Microsoft Outlook Note item.
  /// </summary>
  [InteropEnumValue("msoFileTypeNoteItem")]
  NoteItem,
  /// <summary>
  /// Microsoft Outlook Journal item
  /// </summary>
  [InteropEnumValue("msoFileTypeJournalItem")]
  JournalItem,
  /// <summary>
  /// Microsoft Outlook task item.
  /// </summary>
  [InteropEnumValue("msoFileTypeTaskItem")]
  TaskItem,
  /// <summary>
  /// PhotoDraw item file (*.mix).
  /// </summary>
  [InteropEnumValue("msoFileTypePhotoDrawFiles")]
  PhotoDrawFiles,
  /// <summary>
  /// Data connection file (*.mdf).
  /// </summary>
  [InteropEnumValue("msoFileTypeDataConnectionFiles")]
  DataConnectionFiles,
  /// <summary>
  /// Microsoft Publisher file (*.pub)
  /// </summary>
  [InteropEnumValue("msoFileTypePublisherFiles")]
  PublisherFiles,
  /// <summary>
  /// Project file (*.mpd).
  /// </summary>
  [InteropEnumValue("msoFileTypeProjectFiles")]
  ProjectFiles,
  /// <summary>
  /// Microsoft Document Imaging file (*.mdi).
  /// </summary>
  [InteropEnumValue("msoFileTypeDocumentImagingFiles")]
  DocumentImagingFiles,
  /// <summary>
  /// Microsoft Visio file (*.vsd).
  /// </summary>
  [InteropEnumValue("msoFileTypeVisioFiles")]
  VisioFiles,
  /// <summary>
  /// Visual Basic Active Designer file (*.dsr).
  /// </summary>
  [InteropEnumValue("msoFileTypeDesignerFiles")]
  DesignerFiles,
  /// <summary>
  /// HTML file (*.htm or *.html).
  /// </summary>
  [InteropEnumValue("msoFileTypeWebPages")]
  WebPages
}
