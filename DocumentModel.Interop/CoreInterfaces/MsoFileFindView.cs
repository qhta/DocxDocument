using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoFileFindView
{
  msoViewFileInfo = 1,
  msoViewPreview,
  msoViewSummaryInfo
}