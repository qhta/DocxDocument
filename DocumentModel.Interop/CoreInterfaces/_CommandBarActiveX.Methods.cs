namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarActiveX` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex?view=office-pia` for Office interop details.
/// </remarks>
public partial interface _CommandBarActiveX
{
  /// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accselect?view=office-pia
  /// </remarks>
  public new void accSelect(int flagsSelect, object varChild);
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.acclocation?view=office-pia
  /// </remarks>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accnavigate?view=office-pia
  /// </remarks>
  public new object accNavigate(int navDir, object varStart);
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.acchittest?view=office-pia
  /// </remarks>
  public new object accHitTest(int xLeft, int yTop);
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accdodefaultaction?view=office-pia
  /// </remarks>
  public new void accDoDefaultAction(object varChild);
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.copy?view=office-pia
  /// </remarks>
  public new CommandBarControl Copy(object Bar, object Before);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.delete?view=office-pia
  /// </remarks>
  public new void Delete(object Temporary);
  /// <summary>
  /// Invokes `Execute`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.execute?view=office-pia
  /// </remarks>
  public new void Execute();
  /// <summary>
  /// Invokes `Move`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.move?view=office-pia
  /// </remarks>
  public new CommandBarControl Move(object Bar, object Before);
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reset?view=office-pia
  /// </remarks>
  public new void Reset();
  /// <summary>
  /// Invokes `SetFocus`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.setfocus?view=office-pia
  /// </remarks>
  public new void SetFocus();
  /// <summary>
  /// Invokes `Reserved1`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved1?view=office-pia
  /// </remarks>
  public new void Reserved1();
  /// <summary>
  /// Invokes `Reserved2`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved2?view=office-pia
  /// </remarks>
  public new void Reserved2();
  /// <summary>
  /// Invokes `Reserved3`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved3?view=office-pia
  /// </remarks>
  public new void Reserved3();
  /// <summary>
  /// Invokes `Reserved4`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved4?view=office-pia
  /// </remarks>
  public new void Reserved4();
  /// <summary>
  /// Invokes `Reserved5`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved5?view=office-pia
  /// </remarks>
  public new void Reserved5();
  /// <summary>
  /// Invokes `Reserved6`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved6?view=office-pia
  /// </remarks>
  public new void Reserved6();
  /// <summary>
  /// Invokes `Reserved7`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved7?view=office-pia
  /// </remarks>
  public new void Reserved7();
  /// <summary>
  /// Invokes `SetInnerObjectFactory`.
  /// </summary>
  /// <param name="pUnk">The `pUnk` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.setinnerobjectfactory?view=office-pia
  /// </remarks>
  public void SetInnerObjectFactory(object pUnk);
  /// <summary>
  /// Invokes `EnsureControl`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.ensurecontrol?view=office-pia
  /// </remarks>
  public void EnsureControl();
}
