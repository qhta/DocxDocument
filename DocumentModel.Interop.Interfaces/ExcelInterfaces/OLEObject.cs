using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000208A2-0000-0000-C000-000000000046")]
[CoClass(typeof(OLEObjectClass))]
public interface OLEObject: _OLEObject, OLEObjectEvents_Event
{
}