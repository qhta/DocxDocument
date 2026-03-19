using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoFileType
{
  msoFileTypeAllFiles = 1,
  msoFileTypeOfficeFiles,
  msoFileTypeWordDocuments,
  msoFileTypeExcelWorkbooks,
  msoFileTypePowerPointPresentations,
  msoFileTypeBinders,
  msoFileTypeDatabases,
  msoFileTypeTemplates,
  msoFileTypeOutlookItems,
  msoFileTypeMailItem,
  msoFileTypeCalendarItem,
  msoFileTypeContactItem,
  msoFileTypeNoteItem,
  msoFileTypeJournalItem,
  msoFileTypeTaskItem,
  msoFileTypePhotoDrawFiles,
  msoFileTypeDataConnectionFiles,
  msoFileTypePublisherFiles,
  msoFileTypeProjectFiles,
  msoFileTypeDocumentImagingFiles,
  msoFileTypeVisioFiles,
  msoFileTypeDesignerFiles,
  msoFileTypeWebPages
}