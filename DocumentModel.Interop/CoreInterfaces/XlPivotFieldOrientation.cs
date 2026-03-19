using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[TypeLibType(16)]
public enum XlPivotFieldOrientation
{
  xlColumnField = 2,
  xlDataField = 4,
  xlHidden = 0,
  xlPageField = 3,
  xlRowField = 1
}