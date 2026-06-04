
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of file.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiletype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoFileType))]
public enum FileType
{
  /// <summary>
  /// All files.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeAllFiles))]
  AllFiles = 1,
  /// <summary>
  /// Files with any of the following extensions: *.doc, *.xls, *.ppt, *.pps, *.obd, *.mdb, *.mpd, *.dot, *.xlt,
  /// *.pot, *.obt, *.htm, or *.html.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeOfficeFiles))]
  OfficeFiles,
  /// <summary>
  /// Microsoft Word document file (*.doc).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeWordDocuments))]
  WordDocuments,
  /// <summary>
  /// Microsoft Excel workbook (*.wbk).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeExcelWorkbooks))]
  ExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation file (.ppt), PowerPoint template file (.pot), or PowerPoint slide show file (*.pps).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypePowerPointPresentations))]
  PowerPointPresentations,
  /// <summary>
  /// Microsoft Binder file (*.obd).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeBinders))]
  Binders,
  /// <summary>
  /// Database file (*.mdb).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeDatabases))]
  Databases,
  /// <summary>
  /// Microsoft PowerPoint template (.pot), Word template (.dot), Excel template (*.xlt).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeTemplates))]
  Templates,
  /// <summary>
  /// Any Microsoft Outlook item file.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeOutlookItems))]
  OutlookItems,
  /// <summary>
  /// Mail item file (*.msg).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeMailItem))]
  MailItem,
  /// <summary>
  /// Calendar item file (*.ics or *.vsc).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeCalendarItem))]
  CalendarItem,
  /// <summary>
  /// Contact item file (*.vcf).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeContactItem))]
  ContactItem,
  /// <summary>
  /// Microsoft Outlook Note item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeNoteItem))]
  NoteItem,
  /// <summary>
  /// Microsoft Outlook Journal item
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeJournalItem))]
  JournalItem,
  /// <summary>
  /// Microsoft Outlook task item.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeTaskItem))]
  TaskItem,
  /// <summary>
  /// PhotoDraw item file (*.mix).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypePhotoDrawFiles))]
  PhotoDrawFiles,
  /// <summary>
  /// Data connection file (*.mdf).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeDataConnectionFiles))]
  DataConnectionFiles,
  /// <summary>
  /// Microsoft Publisher file (*.pub)
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypePublisherFiles))]
  PublisherFiles,
  /// <summary>
  /// Project file (*.mpd).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeProjectFiles))]
  ProjectFiles,
  /// <summary>
  /// Microsoft Document Imaging file (*.mdi).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeDocumentImagingFiles))]
  DocumentImagingFiles,
  /// <summary>
  /// Microsoft Visio file (*.vsd).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeVisioFiles))]
  VisioFiles,
  /// <summary>
  /// Visual Basic Active Designer file (*.dsr).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeDesignerFiles))]
  DesignerFiles,
  /// <summary>
  /// HTML file (*.htm or *.html).
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoFileType.msoFileTypeWebPages))]
  WebPages
}
