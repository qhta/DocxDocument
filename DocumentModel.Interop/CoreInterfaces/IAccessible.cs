
namespace DocumentModel.Interop.Core;

public interface IAccessible
{
  object accParent { get; }
  int accChildCount { get; }
  object accChild { get; }
  string accName { get; set; }
  string accValue { get; set; }
  string accDescription { get; }
  object accRole { get; }
  object accState { get; }
  string accHelp { get; }
  int accHelpTopic { get; }
  string accKeyboardShortcut { get; }
  object accFocus { get; }
  object accSelection { get; }
  string accDefaultAction { get; }
  void accSelect(int flagsSelect, object varChild);
  void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  object accNavigate(int navDir, object varStart);
  object accHitTest(int xLeft, int yTop);
  void accDoDefaultAction(object varChild);
}