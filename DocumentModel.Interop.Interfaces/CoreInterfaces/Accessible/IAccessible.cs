
namespace DocumentModel.Interop.Core;
/// <summary>
/// Microsoft Word Accessible refers to documents and features in MS Word designed to be easily read, navigated,
/// and interacted with by people with disabilities (e.g., visual, motor, or cognitive impairments) using assistive technologies.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible?view=office-pia"/>
public interface IAccessible
{
  /// <summary>
  /// Gets the parent essible object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accparent?view=office-pia"/>
  public object Parent { get; }
  /// <summary>
  /// Gets the number of essible child objects.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchildcount?view=office-pia"/>
  public int ChildCount { get; }
  /// <summary>
  /// Gets an essible child object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accchild?view=office-pia"/>
  public object Child { get; }
  /// <summary>
  /// Gets or sets the essible name of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accname?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the essible value of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accvalue?view=office-pia"/>
  public string Value { get; set; }
  /// <summary>
  /// Gets the essible description of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdescription?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the essible role of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accrole?view=office-pia"/>
  public object Role { get; }
  /// <summary>
  /// Gets the essible state of the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accstate?view=office-pia"/>
  public object State { get; }
  /// <summary>
  /// Gets the help string for the essible object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelp?view=office-pia"/>
  public string Help { get; }
  /// <summary>
  /// Gets the help topic identifier for the essible object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchelptopic?view=office-pia"/>
  public int HelpTopic { get; }
  /// <summary>
  /// Gets the keyboard shortcut for the essible object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acckeyboardshortcut?view=office-pia"/>
  public string KeyboardShortcut { get; }
  /// <summary>
  /// Gets the object that has keyboard focus.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accfocus?view=office-pia"/>
  public object Focus { get; }
  /// <summary>
  /// Gets the current selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselection?view=office-pia"/>
  public object Selection { get; }
  /// <summary>
  /// Gets the default action description for the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdefaultaction?view=office-pia"/>
  public string DefaultAction { get; }	
  #region methods
  /// <summary>
  /// Selects the specified essible child object.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accselect?view=office-pia"/>
  public void Select(int flagsSelect, object varChild);
  /// <summary>
  /// Retrieves the screen coordinates and size of the specified essible child object.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acclocation?view=office-pia"/>
  public void Location(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Navigates to another essible object from the specified starting object.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accnavigate?view=office-pia"/>
  public object Navigate(int navDir, object varStart);
  /// <summary>
  /// Retrieves the essible object at the specified screen coordinates.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.acchittest?view=office-pia"/>
  public object HitTest(int xLeft, int yTop);
  /// <summary>
  /// Performs the default action on the specified essible child object.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iaccessible.accdodefaultaction?view=office-pia"/>
  public void DoDefaultAction(object varChild);
  #endregion
}	
