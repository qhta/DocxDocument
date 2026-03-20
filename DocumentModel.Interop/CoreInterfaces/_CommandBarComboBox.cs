
namespace DocumentModel.Interop.Core;

public interface _CommandBarComboBox: CommandBarControl
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
  new bool BeginGroup { get; set; }
  new bool BuiltIn { get; }
  new string Caption { get; set; }
  new object Control { get; }
  new CommandBarControl Copy(object Bar, object Before);
  new void Delete(object Temporary);
  new string DescriptionText { get; set; }
  new bool Enabled { get; set; }
  new void Execute();
  new int Height { get; set; }
  new int HelpContextId { get; set; }
  new string HelpFile { get; set; }
  new int Id { get; }
  new int Index { get; }
  new int InstanceId { get; }
  new CommandBarControl Move(object Bar, object Before);
  new int Left { get; }
  new MsoControlOLEUsage OLEUsage { get; set; }
  new string OnAction { get; set; }
  new string Parameter { get; set; }
  new int Priority { get; set; }
  new void Reset();
  new void SetFocus();
  new string Tag { get; set; }
  new string TooltipText { get; set; }
  new int Top { get; }
  new MsoControlType Type { get; }
  new bool Visible { get; set; }
  new int Width { get; set; }
  new bool IsPriorityDropped { get; }
  new void Reserved1();
  new void Reserved2();
  new void Reserved3();
  new void Reserved4();
  new void Reserved5();
  new void Reserved6();
  new void Reserved7();
  void AddItem(string Text, object Index);
  void Clear();
  int DropDownLines { get; set; }
  int DropDownWidth { get; set; }
  string List { get; set; }
  int ListCount { get; }
  int ListHeaderCount { get; set; }
  int ListIndex { get; set; }
  void RemoveItem(int Index);
  MsoComboStyle Style { get; set; }
  string Text { get; set; }
  object InstanceIdPtr { get; }
}