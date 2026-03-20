
namespace DocumentModel.Interop.Core;

public interface IRibbonUI
{
  public void Invalidate();
  public void InvalidateControl(string ControlID);
  public void InvalidateControlMso(string ControlID);
  public void ActivateTab(string ControlID);
  public void ActivateTabMso(string ControlID);
  public void ActivateTabQ(string ControlID, string Namespace);
}
