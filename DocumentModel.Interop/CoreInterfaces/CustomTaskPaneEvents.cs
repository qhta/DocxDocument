
namespace DocumentModel.Interop.Core;

public interface CustomTaskPaneEvents
{
  public void VisibleStateChange(CustomTaskPane CustomTaskPaneInst);
  public void DockPositionStateChange(CustomTaskPane CustomTaskPaneInst);
}
