
namespace DocumentModel.Interop.Core;

public interface Balloon: InteropObject
{
  object Checkboxes { get; }
  object Labels { get; }
  MsoBalloonType BalloonType { get; set; }
  MsoIconType Icon { get; set; }
  string Heading { get; set; }
  string Text { get; set; }
  MsoModeType Mode { get; set; }
  MsoAnimationType Animation { get; set; }
  MsoButtonSetType Button { get; set; }
  string Callback { get; set; }
  int Private { get; set; }
  void SetAvoidRectangle(int Left, int Top, int Right, int Bottom);
  string Name { get; }
  MsoBalloonButtonType Show();
  void Close();
}