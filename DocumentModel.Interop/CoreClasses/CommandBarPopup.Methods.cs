
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a pop-up control on a command bar.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup?view=office-pia"/>
public partial class CommandBarPopup
{
  /// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accselect?view=office-pia"/>
  public new void accSelect(int flagsSelect, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acclocation?view=office-pia"/>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accnavigate?view=office-pia"/>
  public new object accNavigate(int navDir, object varStart) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acchittest?view=office-pia"/>
  public new object accHitTest(int xLeft, int yTop) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accdodefaultaction?view=office-pia"/>
  public new void accDoDefaultAction(object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.copy?view=office-pia"/>
  public new CommandBarControl Copy(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.delete?view=office-pia"/>
  public new void Delete(object Temporary) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Execute`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.execute?view=office-pia"/>
  public new void Execute() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Move`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.move?view=office-pia"/>
  public new CommandBarControl Move(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reset?view=office-pia"/>
  public new void Reset() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetFocus`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.setfocus?view=office-pia"/>
  public new void SetFocus() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved1`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved1?view=office-pia"/>
  public new void Reserved1() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved2`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved2?view=office-pia"/>
  public new void Reserved2() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved3`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved3?view=office-pia"/>
  public new void Reserved3() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved4`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved4?view=office-pia"/>
  public new void Reserved4() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved5`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved5?view=office-pia"/>
  public new void Reserved5() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved6`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved6?view=office-pia"/>
  public new void Reserved6() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved7`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved7?view=office-pia"/>
  public new void Reserved7() { throw new NotImplementedException(); }
}

