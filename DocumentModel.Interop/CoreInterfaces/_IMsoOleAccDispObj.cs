
namespace DocumentModel.Interop.Core;

public interface _IMsoOleAccDispObj: IAccessible
{
  new object accParent { get; }
  new int accChildCount { get; }
  new object accChild { get; }
  new string accName { get; set; }
  new string accValue { get; set; }
  new string accDescription { get; }
  new object accRole { get; }
  new object accState { get; }
  new string accHelp { get; }
  new int accHelpTopic { get; }
  new string accKeyboardShortcut { get; }
  new object accFocus { get; }
  new object accSelection { get; }
  new string accDefaultAction { get; }
  new void accSelect(int flagsSelect, object varChild);
  new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  new object accNavigate(int navDir, object varStart);
  new object accHitTest(int xLeft, int yTop);
  new void accDoDefaultAction(object varChild);
  object Application { get; }
  int Creator { get; }
}