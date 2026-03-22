
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a type of file.
/// </summary>
public enum MsoFileType
{
  /// <summary>
  /// All files.
  /// </summary>
  msoFileTypeAllFiles = 1,
  /// <summary>
  /// Files with any of the following extensions: *.doc, *.xls, *.ppt, *.pps, *.obd, *.mdb, *.mpd, *.dot, *.xlt,
  /// *.pot, *.obt, *.htm, or *.html.
  /// </summary>
  msoFileTypeOfficeFiles,
  /// <summary>
  /// Microsoft Word document file (*.doc).
  /// </summary>
  msoFileTypeWordDocuments,
  /// <summary>
  /// Microsoft Excel workbook (*.wbk). msoFileTypePowerPointPresentations5 PowerPoint presentation file (.ppt),
  /// PowerPoint template file (.pot), or PowerPoint slide show file (*.pps).
  /// </summary>
  msoFileTypeExcelWorkbooks,
  /// <summary>
  /// Specifies a type of file.
  /// </summary>
  msoFileTypePowerPointPresentations,
  /// <summary>
  /// Microsoft Binder file (*.obd).
  /// </summary>
  msoFileTypeBinders,
  /// <summary>
  /// Database file (*.mdb).
  /// </summary>
  msoFileTypeDatabases,
  /// <summary>
  /// Microsoft PowerPoint template (.pot), Word template (.dot), Excel template (*.xlt).
  /// </summary>
  msoFileTypeTemplates,
  /// <summary>
  /// Any Microsoft Outlook item file.
  /// </summary>
  msoFileTypeOutlookItems,
  /// <summary>
  /// Mail item file (*.msg).
  /// </summary>
  msoFileTypeMailItem,
  /// <summary>
  /// Calendar item file (*.ics or *.vsc). public enum class MsoFileType ﾉ Expand table
  /// </summary>
  msoFileTypeCalendarItem,
  /// <summary>
  /// Contact item file (*.vcf).
  /// </summary>
  msoFileTypeContactItem,
  /// <summary>
  /// Microsoft Outlook Note item.
  /// </summary>
  msoFileTypeNoteItem,
  /// <summary>
  /// Microsoft Outlook Journal item
  /// </summary>
  msoFileTypeJournalItem,
  /// <summary>
  /// Microsoft Outlook task item.
  /// </summary>
  msoFileTypeTaskItem,
  /// <summary>
  /// PhotoDraw item file (*.mix). msoFileTypeDataConnectionFiles17 Data connection file (*.mdf).
  /// </summary>
  msoFileTypePhotoDrawFiles,
  /// <summary>
  /// Specifies a type of file.
  /// </summary>
  msoFileTypeDataConnectionFiles,
  /// <summary>
  /// Microsoft Publisher file (*.pub)
  /// </summary>
  msoFileTypePublisherFiles,
  /// <summary>
  /// Project file (*.mpd). msoFileTypeDocumentImagingFiles20 Microsoft Document Imaging file (*.mdi).
  /// </summary>
  msoFileTypeProjectFiles,
  /// <summary>
  /// Specifies a type of file.
  /// </summary>
  msoFileTypeDocumentImagingFiles,
  /// <summary>
  /// Microsoft Visio file (*.vsd).
  /// </summary>
  msoFileTypeVisioFiles,
  /// <summary>
  /// Visual Basic Active Designer file (*.dsr).
  /// </summary>
  msoFileTypeDesignerFiles,
  /// <summary>
  /// HTML file (*.htm or *.html).
  /// </summary>
  msoFileTypeWebPages
}
