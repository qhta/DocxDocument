using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C030E-0000-0000-C000-000000000046")]
[CoClass(typeof(CommandBarButtonClass))]
public interface CommandBarButton: _CommandBarButton, _CommandBarButtonEvents_Event
{
}