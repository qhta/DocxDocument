
namespace DocumentModel.Interop.Core;

public partial interface IMsoWalls
{
  public object Select();
  public object ClearFormats();
  public void Paste();
}
