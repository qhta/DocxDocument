using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("000208D5-0000-0000-C000-000000000046")]
[CoClass(typeof(ApplicationClass))]
public interface Application: _Application, AppEvents_Event
{
}