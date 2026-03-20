using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface _CommandBars: InteropDictionary<string, CommandBar>
{
  public CommandBarControl ActionControl { get; }
  public CommandBar ActiveMenuBar { get; }
  public bool DisplayTooltips { get; set; }
  public bool DisplayKeysInTooltips { get; set; }
  public bool LargeButtons { get; set; }
  public MsoMenuAnimation MenuAnimationStyle { get; set; }
  public int IdsString { get; }
  public int TmcGetName { get; }
  public bool AdaptiveMenus { get; set; }
  public bool DisplayFonts { get; set; }
  public bool DisableCustomize { get; set; }
  public bool DisableAskAQuestionDropdown { get; set; }
}
