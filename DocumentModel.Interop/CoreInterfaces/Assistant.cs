using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Assistant: InteropObject
{
  public int Top { get; set; }
  public int Left { get; set; }
  public Balloon NewBalloon { get; }
  public MsoBalloonErrorType BalloonError { get; }
  public bool Visible { get; set; }
  public MsoAnimationType Animation { get; set; }
  public bool Reduced { get; set; }
  public bool AssistWithHelp { get; set; }
  public bool AssistWithWizards { get; set; }
  public bool AssistWithAlerts { get; set; }
  public bool MoveWhenInTheWay { get; set; }
  public bool Sounds { get; set; }
  public bool FeatureTips { get; set; }
  public bool MouseTips { get; set; }
  public bool KeyboardShortcutTips { get; set; }
  public bool HighPriorityTips { get; set; }
  public bool TipOfDay { get; set; }
  public bool GuessHelp { get; set; }
  public bool SearchWhenProgramming { get; set; }
  public string Item { get; }
  public string FileName { get; set; }
  public string Name { get; }
  public bool On { get; set; }
}
