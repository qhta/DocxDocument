using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[Guid("00024428-0000-0000-C000-000000000046")]
[CoClass(typeof(QueryTableClass))]
public interface QueryTable: _QueryTable, RefreshEvents_Event
{
}