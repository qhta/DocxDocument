
namespace DocumentModel.Interop.Core;

public partial interface CommandBarPopup
{
  public new void accSelect(int flagsSelect, object varChild);
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  public new object accNavigate(int navDir, object varStart);
  public new object accHitTest(int xLeft, int yTop);
  public new void accDoDefaultAction(object varChild);
  public new CommandBarControl Copy(object Bar, object Before);
  public new void Delete(object Temporary);
  public new void Execute();
  public new CommandBarControl Move(object Bar, object Before);
  public new void Reset();
  public new void SetFocus();
  public new void Reserved1();
  public new void Reserved2();
  public new void Reserved3();
  public new void Reserved4();
  public new void Reserved5();
  public new void Reserved6();
  public new void Reserved7();
}
