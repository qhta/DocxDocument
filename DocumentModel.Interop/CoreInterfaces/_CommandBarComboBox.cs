
namespace DocumentModel.Interop.Core;

public partial interface _CommandBarComboBox: CommandBarControl
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
  public new bool BeginGroup { get; set; }
  public new bool BuiltIn { get; }
  public new string Caption { get; set; }
  public new object Control { get; }
  public new string DescriptionText { get; set; }
  public new bool Enabled { get; set; }
  public new int Height { get; set; }
  public new int HelpContextId { get; set; }
  public new string HelpFile { get; set; }
  public new int Id { get; }
  public new int Index { get; }
  public new int InstanceId { get; }
  public new int Left { get; }
  public new MsoControlOLEUsage OLEUsage { get; set; }
  public new string OnAction { get; set; }
  public new string Parameter { get; set; }
  public new int Priority { get; set; }
  public new string Tag { get; set; }
  public new string TooltipText { get; set; }
  public new int Top { get; }
  public new MsoControlType Type { get; }
  public new bool Visible { get; set; }
  public new int Width { get; set; }
  public new bool IsPriorityDropped { get; }
  public int DropDownLines { get; set; }
  public int DropDownWidth { get; set; }
  public string List { get; set; }
  public int ListCount { get; }
  public int ListHeaderCount { get; set; }
  public int ListIndex { get; set; }
  public MsoComboStyle Style { get; set; }
  public string Text { get; set; }
  public object InstanceIdPtr { get; }
}
