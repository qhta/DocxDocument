
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj?view=office-pia"/>
public partial class _MsoOleAccDispObj: Accessible
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accparent?view=office-pia"/>
  public new object Parent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accchildcount?view=office-pia"/>
  public new int ChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accchild?view=office-pia"/>
  public new object Child { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accname?view=office-pia"/>
  public new string Name { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accvalue?view=office-pia"/>
  public new string Value { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accdescription?view=office-pia"/>
  public new string Description { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accrole?view=office-pia"/>
  public new object Role { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accstate?view=office-pia"/>
  public new object State { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acchelp?view=office-pia"/>
  public new string Help { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acchelptopic?view=office-pia"/>
  public new int HelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acckeyboardshortcut?view=office-pia"/>
  public new string KeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accfocus?view=office-pia"/>
  public new object Focus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accselection?view=office-pia"/>
  public new object Selection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accdefaultaction?view=office-pia"/>
  public new string DefaultAction { get; }


  #region methods

/// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accselect?view=office-pia"/>
  public new void accSelect(int flagsSelect, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acclocation?view=office-pia"/>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accnavigate?view=office-pia"/>
  public new object accNavigate(int navDir, object varStart) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.acchittest?view=office-pia"/>
  public new object accHitTest(int xLeft, int yTop) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._imsooleaccdispobj.accdodefaultaction?view=office-pia"/>
  public new void accDoDefaultAction(object varChild) { throw new NotImplementedException(); }

  #endregion methods
}

