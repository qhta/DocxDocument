
namespace DocumentModel.Interop.Core;

public interface CommandBarControl: _IMsoOleAccDispObj
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
  public bool BeginGroup { get; set; }
  public bool BuiltIn { get; }
  public string Caption { get; set; }
  public object Control { get; }
  public CommandBarControl Copy(object Bar, object Before);
  public void Delete(object Temporary);
  public string DescriptionText { get; set; }
  public bool Enabled { get; set; }
  public void Execute();
  public int Height { get; set; }
  public int HelpContextId { get; set; }
  public string HelpFile { get; set; }
  public int Id { get; }
  public int Index { get; }
  public int InstanceId { get; }
  public CommandBarControl Move(object Bar, object Before);
  public int Left { get; }
  public MsoControlOLEUsage OLEUsage { get; set; }
  public string OnAction { get; set; }
  public string Parameter { get; set; }
  public int Priority { get; set; }
  public void Reset();
  public void SetFocus();
  public string Tag { get; set; }
  public string TooltipText { get; set; }
  public int Top { get; }
  public MsoControlType Type { get; }
  public bool Visible { get; set; }
  public int Width { get; set; }
  public bool IsPriorityDropped { get; }
  public void Reserved1();
  public void Reserved2();
  public void Reserved3();
  public void Reserved4();
  public void Reserved5();
  public void Reserved6();
  public void Reserved7();
}
