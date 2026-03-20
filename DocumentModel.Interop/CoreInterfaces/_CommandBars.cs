using System.Collections;

namespace DocumentModel.Interop.Core;

public interface _CommandBars: InteropDictionary<string, CommandBar>
{
  CommandBarControl ActionControl { get; }
  CommandBar ActiveMenuBar { get; }
  CommandBar Add(object Name, object Position, object MenuBar, object Temporary);
  bool DisplayTooltips { get; set; }
  bool DisplayKeysInTooltips { get; set; }
  CommandBarControl FindControl(object Type, object Id, object Tag, object Visible);
  bool LargeButtons { get; set; }
  MsoMenuAnimation MenuAnimationStyle { get; set; }
  void ReleaseFocus();
  int IdsString { get; }
  int TmcGetName { get; }
  bool AdaptiveMenus { get; set; }
  CommandBarControls FindControls(object Type, object Id, object Tag, object Visible);
  CommandBar AddEx(object TbidOrName, object Position, object MenuBar, object Temporary, object TbtrProtection);
  bool DisplayFonts { get; set; }
  bool DisableCustomize { get; set; }
  bool DisableAskAQuestionDropdown { get; set; }
  void ExecuteMso(string idMso);
  bool GetEnabledMso(string idMso);
  bool GetVisibleMso(string idMso);
  bool GetPressedMso(string idMso);
  string GetLabelMso(string idMso);
  string GetScreentipMso(string idMso);
  string GetSupertipMso(string idMso);
  object GetImageMso(string idMso, int Width, int Height);
  void CommitRenderingTransaction(int hwnd);
}