
namespace DocumentModel.Drawings;

/// <summary>
/// Specifies a type of file.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofiletype?view=office-pia` for Office interop details.
/// </remarks>
public enum FileType
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
  /// Microsoft Excel workbook (*.wbk).
  /// </summary>
  ExcelWorkbooks,
  /// <summary>
  /// PowerPoint presentation file (.ppt), PowerPoint template file (.pot), or PowerPoint slide show file (*.pps).
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
  /// Calendar item file (*.ics or *.vsc).
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
  /// PhotoDraw item file (*.mix).
  /// </summary>
  PhotoDrawFiles,
  /// <summary>
  /// Data connection file (*.mdf).
  /// </summary>
  DataConnectionFiles,
  /// <summary>
  /// Microsoft Publisher file (*.pub)
  /// </summary>
  PublisherFiles,
  /// <summary>
  /// Project file (*.mpd).
  /// </summary>
  ProjectFiles,
  /// <summary>
  /// Microsoft Document Imaging file (*.mdi).
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
