
namespace DocumentModel.Interop.Core;

public interface IRibbonUI
{
  void Invalidate();
  void InvalidateControl(string ControlID);
  void InvalidateControlMso(string ControlID);
  void ActivateTab(string ControlID);
  void ActivateTabMso(string ControlID);
  void ActivateTabQ(string ControlID, string Namespace);
}