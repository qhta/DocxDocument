
namespace DocumentModel.Interop.Core;

public partial interface IAccessible
{
  public void accSelect(int flagsSelect, object varChild);
  public void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  public object accNavigate(int navDir, object varStart);
  public object accHitTest(int xLeft, int yTop);
  public void accDoDefaultAction(object varChild);
}
