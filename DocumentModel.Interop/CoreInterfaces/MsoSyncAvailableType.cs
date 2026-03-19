using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum MsoSyncAvailableType
{
  msoSyncAvailableNone,
  msoSyncAvailableOffline,
  msoSyncAvailableAnywhere
}