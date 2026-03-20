
namespace DocumentModel.Interop.Core;

public interface _IMsoOleAccDispObj: IAccessible
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
  public new void accSelect(int flagsSelect, object varChild);
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  public new object accNavigate(int navDir, object varStart);
  public new object accHitTest(int xLeft, int yTop);
  public new void accDoDefaultAction(object varChild);
}
