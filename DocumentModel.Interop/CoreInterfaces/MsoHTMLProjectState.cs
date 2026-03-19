using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoHTMLProjectState
{
  msoHTMLProjectStateDocumentLocked = 1,
  msoHTMLProjectStateProjectLocked,
  msoHTMLProjectStateDocumentProjectUnlocked
}