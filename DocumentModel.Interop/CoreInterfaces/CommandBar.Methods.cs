
namespace DocumentModel.Interop.Core;

public partial interface CommandBar
{
  public new void accSelect(int flagsSelect, object varChild);
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  public new object accNavigate(int navDir, object varStart);
  public new object accHitTest(int xLeft, int yTop);
  public new void accDoDefaultAction(object varChild);
  public void Delete();
  public CommandBarControl FindControl(object Type, object Id, object Tag, object Visible, object Recursive);
  public void Reset();
  public void ShowPopup(object x, object y);
}
