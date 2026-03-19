using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoFileFindSortBy
{
  msoFileFindSortbyAuthor = 1,
  msoFileFindSortbyDateCreated,
  msoFileFindSortbyLastSavedBy,
  msoFileFindSortbyDateSaved,
  msoFileFindSortbyFileName,
  msoFileFindSortbySize,
  msoFileFindSortbyTitle
}