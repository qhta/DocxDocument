
namespace DocumentModel.Interop.Core;

public partial interface _IMsoOleAccDispObj: IAccessible
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
}
