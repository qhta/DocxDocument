
namespace DocumentModel.Interop.Core;

public interface CustomTaskPaneEvents
{
  void VisibleStateChange(CustomTaskPane CustomTaskPaneInst);
  void DockPositionStateChange(CustomTaskPane CustomTaskPaneInst);
}