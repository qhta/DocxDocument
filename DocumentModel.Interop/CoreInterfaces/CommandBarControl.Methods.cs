
namespace DocumentModel.Interop.Core;

public partial interface CommandBarControl
{
  public new void accSelect(int flagsSelect, object varChild);
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  public new object accNavigate(int navDir, object varStart);
  public new object accHitTest(int xLeft, int yTop);
  public new void accDoDefaultAction(object varChild);
  public CommandBarControl Copy(object Bar, object Before);
  public void Delete(object Temporary);
  public void Execute();
  public CommandBarControl Move(object Bar, object Before);
  public void Reset();
  public void SetFocus();
  public void Reserved1();
  public void Reserved2();
  public void Reserved3();
  public void Reserved4();
  public void Reserved5();
  public void Reserved6();
  public void Reserved7();
}
