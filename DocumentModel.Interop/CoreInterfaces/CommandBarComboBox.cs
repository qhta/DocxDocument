using System.Runtime.InteropServices;

namespace DocumentModel.Interop.Core;

[ComImport]
[Guid("000C030C-0000-0000-C000-000000000046")]
[CoClass(typeof(CommandBarComboBoxClass))]
public interface CommandBarComboBox: _CommandBarComboBox, _CommandBarComboBoxEvents_Event
{
}