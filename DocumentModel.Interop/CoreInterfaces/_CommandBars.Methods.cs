using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface _CommandBars
{
  public CommandBar Add(object Name, object Position, object MenuBar, object Temporary);
  public CommandBarControl FindControl(object Type, object Id, object Tag, object Visible);
  public void ReleaseFocus();
  public CommandBarControls FindControls(object Type, object Id, object Tag, object Visible);
  public CommandBar AddEx(object TbidOrName, object Position, object MenuBar, object Temporary, object TbtrProtection);
  public void ExecuteMso(string idMso);
  public bool GetEnabledMso(string idMso);
  public bool GetVisibleMso(string idMso);
  public bool GetPressedMso(string idMso);
  public string GetLabelMso(string idMso);
  public string GetScreentipMso(string idMso);
  public string GetSupertipMso(string idMso);
  public object GetImageMso(string idMso, int Width, int Height);
  public void CommitRenderingTransaction(int hwnd);
}
