
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a pop-up control on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup?view=office-pia"/>
public partial interface ICommandBarPopup: ICommandBarControl
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accparent?view=office-pia"/>
  public new object accParent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accchildcount?view=office-pia"/>
  public new int accChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accchild?view=office-pia"/>
  public new object accChild { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accname?view=office-pia"/>
  public new string accName { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accvalue?view=office-pia"/>
  public new string accValue { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accdescription?view=office-pia"/>
  public new string accDescription { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accrole?view=office-pia"/>
  public new object accRole { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accstate?view=office-pia"/>
  public new object accState { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acchelp?view=office-pia"/>
  public new string accHelp { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acchelptopic?view=office-pia"/>
  public new int accHelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acckeyboardshortcut?view=office-pia"/>
  public new string accKeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accfocus?view=office-pia"/>
  public new object accFocus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accselection?view=office-pia"/>
  public new object accSelection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accdefaultaction?view=office-pia"/>
  public new string accDefaultAction { get; }
  /// <summary>
  /// Gets or sets the `BeginGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.begingroup?view=office-pia"/>
  public new bool BeginGroup { get; set; }
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.builtin?view=office-pia"/>
  public new bool BuiltIn { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.caption?view=office-pia"/>
  public new string Caption { get; set; }
  /// <summary>
  /// Gets the `Control` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.control?view=office-pia"/>
  public new object Control { get; }
  /// <summary>
  /// Gets or sets the `DescriptionText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.descriptiontext?view=office-pia"/>
  public new string DescriptionText { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.enabled?view=office-pia"/>
  public new bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.height?view=office-pia"/>
  public new int Height { get; set; }
  /// <summary>
  /// Gets or sets the `HelpContextId` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.helpcontextid?view=office-pia"/>
  public new int HelpContextId { get; set; }
  /// <summary>
  /// Gets or sets the `HelpFile` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.helpfile?view=office-pia"/>
  public new string HelpFile { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.id?view=office-pia"/>
  public new int Id { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.index?view=office-pia"/>
  public new int Index { get; }
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.instanceid?view=office-pia"/>
  public new int InstanceId { get; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.left?view=office-pia"/>
  public new int Left { get; }
  /// <summary>
  /// Gets or sets the `OLEUsage` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.oleusage?view=office-pia"/>
  public new ControlOLEUsage OLEUsage { get; set; }
  /// <summary>
  /// Gets or sets the `OnAction` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.onaction?view=office-pia"/>
  public new string OnAction { get; set; }
  /// <summary>
  /// Gets or sets the `Parameter` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.parameter?view=office-pia"/>
  public new string Parameter { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.priority?view=office-pia"/>
  public new int Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.tag?view=office-pia"/>
  public new string Tag { get; set; }
  /// <summary>
  /// Gets or sets the `TooltipText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.tooltiptext?view=office-pia"/>
  public new string TooltipText { get; set; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.top?view=office-pia"/>
  public new int Top { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.type?view=office-pia"/>
  public new ControlType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.visible?view=office-pia"/>
  public new bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.width?view=office-pia"/>
  public new int Width { get; set; }
  /// <summary>
  /// Gets the `IsPriorityDropped` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.isprioritydropped?view=office-pia"/>
  public new bool IsPriorityDropped { get; }
  /// <summary>
  /// Gets the `CommandBar` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.commandbar?view=office-pia"/>
  public CommandBar CommandBar { get; }
  /// <summary>
  /// Gets the `Controls` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.controls?view=office-pia"/>
  public CommandBarControls Controls { get; }
  /// <summary>
  /// Gets or sets the `OLEMenuGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.olemenugroup?view=office-pia"/>
  public OLEMenuGroup OLEMenuGroup { get; set; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.instanceidptr?view=office-pia"/>
  public object InstanceIdPtr { get; }


  #region methods

/// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accselect?view=office-pia"/>
  public new void accSelect(int flagsSelect, object varChild);
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acclocation?view=office-pia"/>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accnavigate?view=office-pia"/>
  public new object accNavigate(int navDir, object varStart);
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acchittest?view=office-pia"/>
  public new object accHitTest(int xLeft, int yTop);
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accdodefaultaction?view=office-pia"/>
  public new void accDoDefaultAction(object varChild);
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.copy?view=office-pia"/>
  public new CommandBarControl Copy(object Bar, object Before);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.delete?view=office-pia"/>
  public new void Delete(object Temporary);
  /// <summary>
  /// Invokes `Execute`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.execute?view=office-pia"/>
  public new void Execute();
  /// <summary>
  /// Invokes `Move`.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.move?view=office-pia"/>
  public new CommandBarControl Move(object Bar, object Before);
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reset?view=office-pia"/>
  public new void Reset();
  /// <summary>
  /// Invokes `SetFocus`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.setfocus?view=office-pia"/>
  public new void SetFocus();
  /// <summary>
  /// Invokes `Reserved1`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved1?view=office-pia"/>
  public new void Reserved1();
  /// <summary>
  /// Invokes `Reserved2`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved2?view=office-pia"/>
  public new void Reserved2();
  /// <summary>
  /// Invokes `Reserved3`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved3?view=office-pia"/>
  public new void Reserved3();
  /// <summary>
  /// Invokes `Reserved4`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved4?view=office-pia"/>
  public new void Reserved4();
  /// <summary>
  /// Invokes `Reserved5`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved5?view=office-pia"/>
  public new void Reserved5();
  /// <summary>
  /// Invokes `Reserved6`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved6?view=office-pia"/>
  public new void Reserved6();
  /// <summary>
  /// Invokes `Reserved7`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.reserved7?view=office-pia"/>
  public new void Reserved7();

  #endregion methods
}

