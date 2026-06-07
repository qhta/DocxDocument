
namespace DocumentModel.Interop.Core;
/// <summary>
/// OleAccDispObj (OLE Accessibility Dispatch Object) is an internal Microsoft component related to Windows Active
/// Accessibility (oleacc.dll). It allows applications to expose their User Interface (UI) elements—such as ribbons
/// and buttons—to assistive technologies like screen readers, which helps make programs like MS Word more accessible.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj?view=office-pia"/>
public interface IOleAccDispObj: IAccessible
{
  /// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accselect?view=office-pia"/>
  public new void Select(int flagsSelect, object varChild);
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acclocation?view=office-pia"/>
  public new void Location(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accnavigate?view=office-pia"/>
  public new object Navigate(int navDir, object varStart);
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acchittest?view=office-pia"/>
  public new object HitTest(int xLeft, int yTop);
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accdodefaultaction?view=office-pia"/>
  public new void DoDefaultAction(object varChild);	
}	

