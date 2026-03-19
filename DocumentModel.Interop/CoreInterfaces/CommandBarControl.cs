
namespace DocumentModel.Interop.Core;

public interface CommandBarControl: _IMsoOleAccDispObj
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
  bool BeginGroup { get; set; }
  bool BuiltIn { get; }
  string Caption { get; set; }
  object Control { get; }
  CommandBarControl Copy(object Bar, object Before);
  void Delete(object Temporary);
  string DescriptionText { get; set; }
  bool Enabled { get; set; }
  void Execute();
  int Height { get; set; }
  int HelpContextId { get; set; }
  string HelpFile { get; set; }
  int Id { get; }
  int Index { get; }
  int InstanceId { get; }
  CommandBarControl Move(object Bar, object Before);
  int Left { get; }
  MsoControlOLEUsage OLEUsage { get; set; }
  string OnAction { get; set; }
  CommandBar Parent { get; }
  string Parameter { get; set; }
  int Priority { get; set; }
  void Reset();
  void SetFocus();
  string Tag { get; set; }
  string TooltipText { get; set; }
  int Top { get; }
  MsoControlType Type { get; }
  bool Visible { get; set; }
  int Width { get; set; }
  bool IsPriorityDropped { get; }
  void Reserved1();
  void Reserved2();
  void Reserved3();
  void Reserved4();
  void Reserved5();
  void Reserved6();
  void Reserved7();
}