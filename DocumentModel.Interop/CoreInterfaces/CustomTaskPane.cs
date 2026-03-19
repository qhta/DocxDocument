using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C033B-0000-0000-C000-000000000046")]
[CoClass(typeof(CustomTaskPaneClass))]
public interface CustomTaskPane: _CustomTaskPane, _CustomTaskPaneEvents_Event
{
}