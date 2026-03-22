
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of file.
/// </summary>
public enum MsoFileType
{
  /// <summary>
  /// All files.
  /// </summary>
  AllFiles = 1,
  /// <summary>
  /// Files with any of the following extensions: *.doc, *.xls, *.ppt, *.pps, *.obd, *.mdb, *.mpd, *.dot, *.xlt,
  /// *.pot, *.obt, *.htm, or *.html.
  /// </summary>
  OfficeFiles,
  /// <summary>
  /// Microsoft Word document file (*.doc).
  /// </summary>
  WordDocuments,
  /// <summary>
  /// Microsoft Excel workbook (*.wbk). msoFileTypePowerPointPresentations5 PowerPoint presentation file (.ppt),
  /// PowerPoint template file (.pot), or PowerPoint slide show file (*.pps).
  /// </summary>
  ExcelWorkbooks,
  /// <summary>
  /// Specifies a type of file.
  /// </summary>
  PowerPointPresentations,
  /// <summary>
  /// Microsoft Binder file (*.obd).
  /// </summary>
  Binders,
  /// <summary>
  /// Database file (*.mdb).
  /// </summary>
  Databases,
  /// <summary>
  /// Microsoft PowerPoint template (.pot), Word template (.dot), Excel template (*.xlt).
  /// </summary>
  Templates,
  /// <summary>
  /// Any Microsoft Outlook item file.
  /// </summary>
  OutlookItems,
  /// <summary>
  /// Mail item file (*.msg).
  /// </summary>
  MailItem,
  /// <summary>
  /// Calendar item file (*.ics or *.vsc). public enum class MsoFileType ﾉ Expand table
  /// </summary>
  CalendarItem,
  /// <summary>
  /// Contact item file (*.vcf).
  /// </summary>
  ContactItem,
  /// <summary>
  /// Microsoft Outlook Note item.
  /// </summary>
  NoteItem,
  /// <summary>
  /// Microsoft Outlook Journal item
  /// </summary>
  JournalItem,
  /// <summary>
  /// Microsoft Outlook task item.
  /// </summary>
  TaskItem,
  /// <summary>
  /// PhotoDraw item file (*.mix). msoFileTypeDataConnectionFiles17 Data connection file (*.mdf).
  /// </summary>
  PhotoDrawFiles,
  /// <summary>
  /// Specifies a type of file.
  /// </summary>
  DataConnectionFiles,
  /// <summary>
  /// Microsoft Publisher file (*.pub)
  /// </summary>
  PublisherFiles,
  /// <summary>
  /// Project file (*.mpd). msoFileTypeDocumentImagingFiles20 Microsoft Document Imaging file (*.mdi).
  /// </summary>
  ProjectFiles,
  /// <summary>
  /// Specifies a type of file.
  /// </summary>
  DocumentImagingFiles,
  /// <summary>
  /// Microsoft Visio file (*.vsd).
  /// </summary>
  VisioFiles,
  /// <summary>
  /// Visual Basic Active Designer file (*.dsr).
  /// </summary>
  DesignerFiles,
  /// <summary>
  /// HTML file (*.htm or *.html).
  /// </summary>
  WebPages
}
