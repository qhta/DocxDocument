
namespace DocumentModel.Interop.Core;

public partial interface CustomTaskPaneEvents
{
  public void VisibleStateChange(CustomTaskPane CustomTaskPaneInst);
  public void DockPositionStateChange(CustomTaskPane CustomTaskPaneInst);
}
