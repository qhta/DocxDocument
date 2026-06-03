using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Excel;

[ComImport]
[CoClass(typeof(ChartClass))]
[Guid("000208D6-0000-0000-C000-000000000046")]
public interface Chart: _Chart, ChartEvents_Event
{
}