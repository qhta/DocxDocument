namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarActiveX` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex?view=office-pia` for Office interop details.
/// </remarks>
public partial class _CommandBarActiveX: CommandBarControl
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accparent?view=office-pia"/>
  public new object accParent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accchildcount?view=office-pia"/>
  public new int accChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accchild?view=office-pia"/>
  public new object accChild { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accname?view=office-pia"/>
  public new string accName { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accvalue?view=office-pia"/>
  public new string accValue { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accdescription?view=office-pia"/>
  public new string accDescription { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accrole?view=office-pia"/>
  public new object accRole { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accstate?view=office-pia"/>
  public new object accState { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.acchelp?view=office-pia"/>
  public new string accHelp { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.acchelptopic?view=office-pia"/>
  public new int accHelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.acckeyboardshortcut?view=office-pia"/>
  public new string accKeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accfocus?view=office-pia"/>
  public new object accFocus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accselection?view=office-pia"/>
  public new object accSelection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accdefaultaction?view=office-pia"/>
  public new string accDefaultAction { get; }
  /// <summary>
  /// Gets or sets the `BeginGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.begingroup?view=office-pia"/>
  public new bool BeginGroup { get; set; }
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.builtin?view=office-pia"/>
  public new bool BuiltIn { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.caption?view=office-pia"/>
  public new string Caption { get; set; }
  /// <summary>
  /// Gets the `Control` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.control?view=office-pia"/>
  public new object Control { get; }
  /// <summary>
  /// Gets or sets the `DescriptionText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.descriptiontext?view=office-pia"/>
  public new string DescriptionText { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.enabled?view=office-pia"/>
  public new bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.height?view=office-pia"/>
  public new int Height { get; set; }
  /// <summary>
  /// Gets or sets the `HelpContextId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.helpcontextid?view=office-pia"/>
  public new int HelpContextId { get; set; }
  /// <summary>
  /// Gets or sets the `HelpFile` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.helpfile?view=office-pia"/>
  public new string HelpFile { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.id?view=office-pia"/>
  public new int Id { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.index?view=office-pia"/>
  public new int Index { get; }
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.instanceid?view=office-pia"/>
  public new int InstanceId { get; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.left?view=office-pia"/>
  public new int Left { get; }
  /// <summary>
  /// Gets or sets the `OLEUsage` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.oleusage?view=office-pia"/>
  public new ControlOLEUsage OLEUsage { get; set; }
  /// <summary>
  /// Gets or sets the `OnAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.onaction?view=office-pia"/>
  public new string OnAction { get; set; }
  /// <summary>
  /// Gets or sets the `Parameter` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.parameter?view=office-pia"/>
  public new string Parameter { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.priority?view=office-pia"/>
  public new int Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.tag?view=office-pia"/>
  public new string Tag { get; set; }
  /// <summary>
  /// Gets or sets the `TooltipText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.tooltiptext?view=office-pia"/>
  public new string TooltipText { get; set; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.top?view=office-pia"/>
  public new int Top { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.type?view=office-pia"/>
  public new ControlType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.visible?view=office-pia"/>
  public new bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.width?view=office-pia"/>
  public new int Width { get; set; }
  /// <summary>
  /// Gets the `IsPriorityDropped` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.isprioritydropped?view=office-pia"/>
  public new bool IsPriorityDropped { get; set;}
  /// <summary>
  /// Gets or sets the `ControlCLSID` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.controlclsid?view=office-pia"/>
  public string? ControlCLSID { get; set; }
  /// <summary>
  /// Gets the `QueryControlInterface` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.querycontrolinterface?view=office-pia"/>
  public object? QueryControlInterface { get; set;}
  /// <summary>
  /// Gets or sets the `InitWith` property.
  /// </summary>
  public object? InitWith { get; set; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.instanceidptr?view=office-pia"/>
  public object? InstanceIdPtr { get; set;}


  #region methods

/// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accselect?view=office-pia"/>
  public new void accSelect(int flagsSelect, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.acclocation?view=office-pia"/>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accnavigate?view=office-pia"/>
  public new object accNavigate(int navDir, object varStart) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.acchittest?view=office-pia"/>
  public new object accHitTest(int xLeft, int yTop) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.accdodefaultaction?view=office-pia"/>
  public new void accDoDefaultAction(object varChild) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.copy?view=office-pia"/>
  public new CommandBarControl Copy(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.delete?view=office-pia"/>
  public new void Delete(object Temporary) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Execute`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.execute?view=office-pia"/>
  public new void Execute() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Move`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.move?view=office-pia"/>
  public new CommandBarControl Move(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reset?view=office-pia"/>
  public new void Reset() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetFocus`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.setfocus?view=office-pia"/>
  public new void SetFocus() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved1`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved1?view=office-pia"/>
  public new void Reserved1() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved2`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved2?view=office-pia"/>
  public new void Reserved2() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved3`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved3?view=office-pia"/>
  public new void Reserved3() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved4`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved4?view=office-pia"/>
  public new void Reserved4() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved5`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved5?view=office-pia"/>
  public new void Reserved5() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved6`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved6?view=office-pia"/>
  public new void Reserved6() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Reserved7`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.reserved7?view=office-pia"/>
  public new void Reserved7() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SetInnerObjectFactory`.
  /// </summary>
  /// <param name="pUnk">The `pUnk` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.setinnerobjectfactory?view=office-pia"/>
  public void SetInnerObjectFactory(object pUnk) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `EnsureControl`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.ensurecontrol?view=office-pia"/>
  public void EnsureControl() { throw new NotImplementedException(); }

  #endregion methods
}

