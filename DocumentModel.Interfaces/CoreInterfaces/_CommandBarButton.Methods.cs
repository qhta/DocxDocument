
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarButton` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton?view=office-pia` for Office interop details.
/// </remarks>
public partial interface _CommandBarButton
{
  /// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accselect?view=office-pia"/>
  public new void accSelect(int flagsSelect, object varChild);
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acclocation?view=office-pia"/>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accnavigate?view=office-pia"/>
  public new object accNavigate(int navDir, object varStart);
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.acchittest?view=office-pia"/>
  public new object accHitTest(int xLeft, int yTop);
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.accdodefaultaction?view=office-pia"/>
  public new void accDoDefaultAction(object varChild);
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.copy?view=office-pia"/>
  public new CommandBarControl Copy(object Bar, object Before);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.delete?view=office-pia"/>
  public new void Delete(object Temporary);
  /// <summary>
  /// Invokes `Execute`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.execute?view=office-pia"/>
  public new void Execute();
  /// <summary>
  /// Invokes `Move`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.move?view=office-pia"/>
  public new CommandBarControl Move(object Bar, object Before);
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reset?view=office-pia"/>
  public new void Reset();
  /// <summary>
  /// Invokes `SetFocus`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.setfocus?view=office-pia"/>
  public new void SetFocus();
  /// <summary>
  /// Invokes `Reserved1`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved1?view=office-pia"/>
  public new void Reserved1();
  /// <summary>
  /// Invokes `Reserved2`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved2?view=office-pia"/>
  public new void Reserved2();
  /// <summary>
  /// Invokes `Reserved3`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved3?view=office-pia"/>
  public new void Reserved3();
  /// <summary>
  /// Invokes `Reserved4`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved4?view=office-pia"/>
  public new void Reserved4();
  /// <summary>
  /// Invokes `Reserved5`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved5?view=office-pia"/>
  public new void Reserved5();
  /// <summary>
  /// Invokes `Reserved6`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved6?view=office-pia"/>
  public new void Reserved6();
  /// <summary>
  /// Invokes `Reserved7`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.reserved7?view=office-pia"/>
  public new void Reserved7();
  /// <summary>
  /// Invokes `CopyFace`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.copyface?view=office-pia"/>
  public void CopyFace();
  /// <summary>
  /// Invokes `PasteFace`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.pasteface?view=office-pia"/>
  public void PasteFace();
}

