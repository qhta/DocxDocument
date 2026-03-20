
namespace DocumentModel.Interop.Core;

public partial interface IAccessible
{
  public object accParent { get; }
  public int accChildCount { get; }
  public object accChild { get; }
  public string accName { get; set; }
  public string accValue { get; set; }
  public string accDescription { get; }
  public object accRole { get; }
  public object accState { get; }
  public string accHelp { get; }
  public int accHelpTopic { get; }
  public string accKeyboardShortcut { get; }
  public object accFocus { get; }
  public object accSelection { get; }
  public string accDefaultAction { get; }
}
