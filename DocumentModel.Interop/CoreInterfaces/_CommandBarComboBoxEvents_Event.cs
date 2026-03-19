
namespace DocumentModel.Interop.Core;

public delegate void _CommandBarComboBoxEvents_ChangeEventHandler(CommandBarComboBox Ctrl);

public interface _CommandBarComboBoxEvents_Event
{
  event _CommandBarComboBoxEvents_ChangeEventHandler Change;
}