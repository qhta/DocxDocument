namespace DocumentModel.Interop.Core;

public interface _CommandBarActiveX: CommandBarControl
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
  public new bool BeginGroup { get; set; }
  public new bool BuiltIn { get; }
  public new string Caption { get; set; }
  public new object Control { get; }
  public new CommandBarControl Copy(object Bar, object Before);
  public new void Delete(object Temporary);
  public new string DescriptionText { get; set; }
  public new bool Enabled { get; set; }
  public new void Execute();
  public new int Height { get; set; }
  public new int HelpContextId { get; set; }
  public new string HelpFile { get; set; }
  public new int Id { get; }
  public new int Index { get; }
  public new int InstanceId { get; }
  public new CommandBarControl Move(object Bar, object Before);
  public new int Left { get; }
  public new MsoControlOLEUsage OLEUsage { get; set; }
  public new string OnAction { get; set; }
  public new string Parameter { get; set; }
  public new int Priority { get; set; }
  public new void Reset();
  public new void SetFocus();
  public new string Tag { get; set; }
  public new string TooltipText { get; set; }
  public new int Top { get; }
  public new MsoControlType Type { get; }
  public new bool Visible { get; set; }
  public new int Width { get; set; }
  public new bool IsPriorityDropped { get; }
  public new void Reserved1();
  public new void Reserved2();
  public new void Reserved3();
  public new void Reserved4();
  public new void Reserved5();
  public new void Reserved6();
  public new void Reserved7();
  public string ControlCLSID { get; set; }
  public object QueryControlInterface { get; }
  public void SetInnerObjectFactory(object pUnk);
  public void EnsureControl();
  public object InitWith { set; }
  public object InstanceIdPtr { get; }
}
