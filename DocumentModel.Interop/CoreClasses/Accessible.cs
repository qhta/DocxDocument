
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible?view=office-pia"/>
public partial class Accessible: IAccessible
{
  /// <summary>
  /// Gets the parent accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accparent?view=office-pia"/>
  public object Parent { get; }
  /// <summary>
  /// Gets the number of accessible child objects.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchildcount?view=office-pia"/>
  public int ChildCount { get; }
  /// <summary>
  /// Gets an accessible child object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchild?view=office-pia"/>
  public object Child { get; }
  /// <summary>
  /// Gets or sets the accessible name of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accname?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the accessible value of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accvalue?view=office-pia"/>
  public string Value { get; set; }
  /// <summary>
  /// Gets the accessible description of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdescription?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the accessible role of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accrole?view=office-pia"/>
  public object Role { get; }
  /// <summary>
  /// Gets the accessible state of the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accstate?view=office-pia"/>
  public object State { get; }
  /// <summary>
  /// Gets the help string for the accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelp?view=office-pia"/>
  public string Help { get; }
  /// <summary>
  /// Gets the help topic identifier for the accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelptopic?view=office-pia"/>
  public int HelpTopic { get; }
  /// <summary>
  /// Gets the keyboard shortcut for the accessible object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acckeyboardshortcut?view=office-pia"/>
  public string KeyboardShortcut { get; }
  /// <summary>
  /// Gets the object that has keyboard focus.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accfocus?view=office-pia"/>
  public object Focus { get; }
  /// <summary>
  /// Gets the current selection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselection?view=office-pia"/>
  public object Selection { get; }
  /// <summary>
  /// Gets the default action description for the object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdefaultaction?view=office-pia"/>
  public string DefaultAction { get; }


  #region methods

/// <summary>
  /// Selects the specified accessible child object.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselect?view=office-pia"/>
  public void accSelect(int flagsSelect, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Retrieves the screen coordinates and size of the specified accessible child object.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acclocation?view=office-pia"/>
  public void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Navigates to another accessible object from the specified starting object.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accnavigate?view=office-pia"/>
  public object accNavigate(int navDir, object varStart) { throw new NotImplementedException(); }
  /// <summary>
  /// Retrieves the accessible object at the specified screen coordinates.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchittest?view=office-pia"/>
  public object accHitTest(int xLeft, int yTop) { throw new NotImplementedException(); }
  /// <summary>
  /// Performs the default action on the specified accessible child object.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdodefaultaction?view=office-pia"/>
  public void accDoDefaultAction(object varChild) { throw new NotImplementedException(); }

  /// <summary>
  /// Selects the specified accessible child object.
  /// </summary>
  /// <param name="flagsSelect">The selection flags.</param>
  /// <param name="varChild">The child object to select.</param>
  public void Select(int flagsSelect, object varChild) => accSelect(flagsSelect, varChild);

  /// <summary>
  /// Retrieves the screen coordinates and size of the specified accessible child object.
  /// </summary>
  /// <param name="pxLeft">The left coordinate.</param>
  /// <param name="pyTop">The top coordinate.</param>
  /// <param name="pcxWidth">The width.</param>
  /// <param name="pcyHeight">The height.</param>
  /// <param name="varChild">The child object.</param>
  public void Location(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild)
    => accLocation(out pxLeft, out pyTop, out pcxWidth, out pcyHeight, varChild);

  /// <summary>
  /// Navigates from the specified starting accessible object.
  /// </summary>
  /// <param name="navDir">The navigation direction.</param>
  /// <param name="varStart">The starting object.</param>
  /// <returns>The target object.</returns>
  public object Navigate(int navDir, object varStart) => accNavigate(navDir, varStart);

  /// <summary>
  /// Retrieves the accessible object at the specified screen coordinates.
  /// </summary>
  /// <param name="xLeft">The x-coordinate.</param>
  /// <param name="yTop">The y-coordinate.</param>
  /// <returns>The object at the specified location.</returns>
  public object HitTest(int xLeft, int yTop) => accHitTest(xLeft, yTop);

  /// <summary>
  /// Performs the default action on the specified accessible child object.
  /// </summary>
  /// <param name="varChild">The child object.</param>
  public void DoDefaultAction(object varChild) => accDoDefaultAction(varChild);

  #endregion methods
}

