using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoSortBy
{
  msoSortByFileName = 1,
  msoSortBySize,
  msoSortByFileType,
  msoSortByLastModified,
  msoSortByNone
}