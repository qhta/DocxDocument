
namespace DocumentModel.Interop.Core;

public partial interface CommandBar: _IMsoOleAccDispObj
{
  public new object accParent { get; }
  public new int accChildCount { get; }
  public new object accChild { get; }
  public new string accName { get; set; }
  public new string accValue { get; set; }
  public new string accDescription { get; }
  public new object accRole { get; }
  public new object accState { get; }
  public new string accHelp { get; }
  public new int accHelpTopic { get; }
  public new string accKeyboardShortcut { get; }
  public new object accFocus { get; }
  public new object accSelection { get; }
  public new string accDefaultAction { get; }
  public bool BuiltIn { get; }
  public string Context { get; set; }
  public CommandBarControls Controls { get; }
  public bool Enabled { get; set; }
  public int Height { get; set; }
  public int Index { get; }
  public int InstanceId { get; }
  public int Left { get; set; }
  public string Name { get; set; }
  public string NameLocal { get; set; }
  public MsoBarPosition Position { get; set; }
  public int RowIndex { get; set; }
  public MsoBarProtection Protection { get; set; }
  public int Top { get; set; }
  public MsoBarType Type { get; }
  public bool Visible { get; set; }
  public int Width { get; set; }
  public bool AdaptiveMenu { get; set; }
  public int Id { get; }
  public object InstanceIdPtr { get; }
}
