using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CommandBars: InteropDictionary<string, CommandBar>
{
  public CommandBarControl ActionControl { get; }
  public CommandBar ActiveMenuBar { get; }
  public CommandBar Add(object Name, object Position, object MenuBar, object Temporary);
  public bool DisplayTooltips { get; set; }
  public bool DisplayKeysInTooltips { get; set; }
  public CommandBarControl FindControl(object Type, object Id, object Tag, object Visible);
  public bool LargeButtons { get; set; }
  public MsoMenuAnimation MenuAnimationStyle { get; set; }
  public void ReleaseFocus();
  public int IdsString { get; }
  public int TmcGetName { get; }
  public bool AdaptiveMenus { get; set; }
  public CommandBarControls FindControls(object Type, object Id, object Tag, object Visible);
  public CommandBar AddEx(object TbidOrName, object Position, object MenuBar, object Temporary, object TbtrProtection);
  public bool DisplayFonts { get; set; }
  public bool DisableCustomize { get; set; }
  public bool DisableAskAQuestionDropdown { get; set; }
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
