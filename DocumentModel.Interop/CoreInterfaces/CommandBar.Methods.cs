
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a command bar in the container application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar?view=office-pia
/// </remarks>
public partial interface CommandBar
{
  /// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.accselect?view=office-pia
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
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.acclocation?view=office-pia
  /// </remarks>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.accnavigate?view=office-pia
  /// </remarks>
  public new object accNavigate(int navDir, object varStart);
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.acchittest?view=office-pia
  /// </remarks>
  public new object accHitTest(int xLeft, int yTop);
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.accdodefaultaction?view=office-pia
  /// </remarks>
  public new void accDoDefaultAction(object varChild);
  /// <summary>
  /// Deletes the command bar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Finds a control on the command bar that matches the specified criteria.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Tag">The `Tag` parameter.</param>
  /// <param name="Visible">The `Visible` parameter.</param>
  /// <param name="Recursive">The `Recursive` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.findcontrol?view=office-pia
  /// </remarks>
  public CommandBarControl FindControl(object Type, object Id, object Tag, object Visible, object Recursive);
  /// <summary>
  /// Restores the command bar to its default state.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.reset?view=office-pia
  /// </remarks>
  public void Reset();
  /// <summary>
  /// Displays the command bar as a shortcut menu.
  /// </summary>
  /// <param name="x">The `x` parameter.</param>
  /// <param name="y">The `y` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.showpopup?view=office-pia
  /// </remarks>
  public void ShowPopup(object x, object y);
}
