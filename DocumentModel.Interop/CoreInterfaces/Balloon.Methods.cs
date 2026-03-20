
namespace DocumentModel.Interop.Core;

public partial interface Balloon
{
  public void SetAvoidRectangle(int Left, int Top, int Right, int Bottom);
  public MsoBalloonButtonType Show();
  public void Close();
}
