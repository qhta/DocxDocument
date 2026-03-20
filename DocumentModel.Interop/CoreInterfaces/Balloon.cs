
namespace DocumentModel.Interop.Core;

public partial interface Balloon: InteropObject
{
  public object Checkboxes { get; }
  public object Labels { get; }
  public MsoBalloonType BalloonType { get; set; }
  public MsoIconType Icon { get; set; }
  public string Heading { get; set; }
  public string Text { get; set; }
  public MsoModeType Mode { get; set; }
  public MsoAnimationType Animation { get; set; }
  public MsoButtonSetType Button { get; set; }
  public string Callback { get; set; }
  public int Private { get; set; }
  public string Name { get; }
}
