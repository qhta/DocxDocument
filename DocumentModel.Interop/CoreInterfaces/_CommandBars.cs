using System.Collections;

using stdole;

namespace DocumentModel.Interop.Core;

public interface _CommandBars: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  CommandBarControl ActionControl { get; }
  CommandBar ActiveMenuBar { get; }
  CommandBar Add(object Name, object Position, object MenuBar, object Temporary);
  int Count { get; }
  bool DisplayTooltips { get; set; }
  bool DisplayKeysInTooltips { get; set; }
  CommandBarControl FindControl(object Type, object Id, object Tag, object Visible);
  CommandBar this[object Index] { get; }
  bool LargeButtons { get; set; }
  MsoMenuAnimation MenuAnimationStyle { get; set; }
  new IEnumerator GetEnumerator();
  object Parent { get; }
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
  IPictureDisp GetImageMso(string idMso, int Width, int Height);
  void CommitRenderingTransaction(int hwnd);
}