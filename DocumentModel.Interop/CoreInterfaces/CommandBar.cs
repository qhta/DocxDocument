
namespace DocumentModel.Interop.Core;

public interface CommandBar: _IMsoOleAccDispObj
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
  new object Application { get; }
  new int Creator { get; }
  bool BuiltIn { get; }
  string Context { get; set; }
  CommandBarControls Controls { get; }
  void Delete();
  bool Enabled { get; set; }
  CommandBarControl FindControl(object Type, object Id, object Tag, object Visible, object Recursive);
  int Height { get; set; }
  int Index { get; }
  int InstanceId { get; }
  int Left { get; set; }
  string Name { get; set; }
  string NameLocal { get; set; }
  object Parent { get; }
  MsoBarPosition Position { get; set; }
  int RowIndex { get; set; }
  MsoBarProtection Protection { get; set; }
  void Reset();
  void ShowPopup(object x, object y);
  int Top { get; set; }
  MsoBarType Type { get; }
  bool Visible { get; set; }
  int Width { get; set; }
  bool AdaptiveMenu { get; set; }
  int Id { get; }
  object InstanceIdPtr { get; }
}