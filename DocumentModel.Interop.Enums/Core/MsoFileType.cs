
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of file.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiletype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFileType")]
public enum FileType
{
  /// <summary>
  /// All files.
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeAllFiles")]
  AllFiles = 1,
  /// <summary>
  /// Files with any of the following extensions: *.doc, *.xls, *.ppt, *.pps, *.obd, *.mdb, *.mpd, *.dot, *.xlt,
  /// *.pot, *.obt, *.htm, or *.html.
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeOfficeFiles")]
  OfficeFiles,
  /// <summary>
  /// Microsoft Word document file (*.doc).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeWordDocuments")]
  WordDocuments,
  /// <summary>
  /// Microsoft Excel workbook (*.wbk).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeExcelWorkbooks")]
  ExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation file (.ppt), PowerPoint template file (.pot), or PowerPoint slide show file (*.pps).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypePowerPointPresentations")]
  PowerPointPresentations,
  /// <summary>
  /// Microsoft Binder file (*.obd).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeBinders")]
  Binders,
  /// <summary>
  /// Database file (*.mdb).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeDatabases")]
  Databases,
  /// <summary>
  /// Microsoft PowerPoint template (.pot), Word template (.dot), Excel template (*.xlt).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeTemplates")]
  Templates,
  /// <summary>
  /// Any Microsoft Outlook item file.
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeOutlookItems")]
  OutlookItems,
  /// <summary>
  /// Mail item file (*.msg).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeMailItem")]
  MailItem,
  /// <summary>
  /// Calendar item file (*.ics or *.vsc).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeCalendarItem")]
  CalendarItem,
  /// <summary>
  /// Contact item file (*.vcf).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeContactItem")]
  ContactItem,
  /// <summary>
  /// Microsoft Outlook Note item.
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeNoteItem")]
  NoteItem,
  /// <summary>
  /// Microsoft Outlook Journal item
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeJournalItem")]
  JournalItem,
  /// <summary>
  /// Microsoft Outlook task item.
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeTaskItem")]
  TaskItem,
  /// <summary>
  /// PhotoDraw item file (*.mix).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypePhotoDrawFiles")]
  PhotoDrawFiles,
  /// <summary>
  /// Data connection file (*.mdf).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeDataConnectionFiles")]
  DataConnectionFiles,
  /// <summary>
  /// Microsoft Publisher file (*.pub)
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypePublisherFiles")]
  PublisherFiles,
  /// <summary>
  /// Project file (*.mpd).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeProjectFiles")]
  ProjectFiles,
  /// <summary>
  /// Microsoft Document Imaging file (*.mdi).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeDocumentImagingFiles")]
  DocumentImagingFiles,
  /// <summary>
  /// Microsoft Visio file (*.vsd).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeVisioFiles")]
  VisioFiles,
  /// <summary>
  /// Visual Basic Active Designer file (*.dsr).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeDesignerFiles")]
  DesignerFiles,
  /// <summary>
  /// HTML file (*.htm or *.html).
  /// </summary>
  [OfficeInteropEnumValue("msoFileTypeWebPages")]
  WebPages
}
