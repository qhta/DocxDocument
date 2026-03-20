
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible?view=office-pia
/// </remarks>
public partial interface IAccessible
{
  /// <summary>
  /// Selects the specified accessible child object.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselect?view=office-pia
  /// </remarks>
  public void accSelect(int flagsSelect, object varChild);
  /// <summary>
  /// Retrieves the screen coordinates and size of the specified accessible child object.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acclocation?view=office-pia
  /// </remarks>
  public void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Navigates to another accessible object from the specified starting object.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accnavigate?view=office-pia
  /// </remarks>
  public object accNavigate(int navDir, object varStart);
  /// <summary>
  /// Retrieves the accessible object at the specified screen coordinates.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchittest?view=office-pia
  /// </remarks>
  public object accHitTest(int xLeft, int yTop);
  /// <summary>
  /// Performs the default action on the specified accessible child object.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdodefaultaction?view=office-pia
  /// </remarks>
  public void accDoDefaultAction(object varChild);
}
