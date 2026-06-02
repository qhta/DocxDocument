
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a command bar control.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol?view=office-pia"/>
public partial interface ICommandBarControl: _IMsoOleAccDispObj
{
  /// <summary>
  /// Gets or sets the `accParent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accparent?view=office-pia"/>
  public object Parent { get; }
  /// <summary>
  /// Gets the `accChildCount` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accchildcount?view=office-pia"/>
  public int ChildCount { get; }
  /// <summary>
  /// Gets the `accChild` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accchild?view=office-pia"/>
  public object Child { get; }
  /// <summary>
  /// Gets or sets the `accName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accname?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accvalue?view=office-pia"/>
  public string Value { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accdescription?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accrole?view=office-pia"/>
  public object Role { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accstate?view=office-pia"/>
  public object State { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.acchelp?view=office-pia"/>
  public string Help { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.acchelptopic?view=office-pia"/>
  public int HelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.acckeyboardshortcut?view=office-pia"/>
  public string KeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accfocus?view=office-pia"/>
  public object Focus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accselection?view=office-pia"/>
  public object Selection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accdefaultaction?view=office-pia"/>
  public string DefaultAction { get; }
  /// <summary>
  /// Gets or sets the `BeginGroup` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.begingroup?view=office-pia"/>
  public bool BeginGroup { get; set; }
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.builtin?view=office-pia"/>
  public bool BuiltIn { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.caption?view=office-pia"/>
  public string Caption { get; set; }
  /// <summary>
  /// Gets the `Control` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.control?view=office-pia"/>
  public object Control { get; }
  /// <summary>
  /// Gets or sets the `DescriptionText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.descriptiontext?view=office-pia"/>
  public string DescriptionText { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.enabled?view=office-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.height?view=office-pia"/>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `HelpContextId` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.helpcontextid?view=office-pia"/>
  public int HelpContextId { get; set; }
  /// <summary>
  /// Gets or sets the `HelpFile` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.helpfile?view=office-pia"/>
  public string HelpFile { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.id?view=office-pia"/>
  public int Id { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.instanceid?view=office-pia"/>
  public int InstanceId { get; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.left?view=office-pia"/>
  public int Left { get; }
  /// <summary>
  /// Gets or sets the `OLEUsage` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.oleusage?view=office-pia"/>
  public ControlOLEUsage OLEUsage { get; set; }
  /// <summary>
  /// Gets or sets the `OnAction` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.onaction?view=office-pia"/>
  public string OnAction { get; set; }
  /// <summary>
  /// Gets or sets the `Parameter` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.parameter?view=office-pia"/>
  public string Parameter { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.priority?view=office-pia"/>
  public int Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.tag?view=office-pia"/>
  public string Tag { get; set; }
  /// <summary>
  /// Gets or sets the `TooltipText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.tooltiptext?view=office-pia"/>
  public string TooltipText { get; set; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.top?view=office-pia"/>
  public int Top { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.type?view=office-pia"/>
  public ControlType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.visible?view=office-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.width?view=office-pia"/>
  public int Width { get; set; }
  /// <summary>
  /// Gets the `IsPriorityDropped` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.isprioritydropped?view=office-pia"/>
  public bool IsPriorityDropped { get; }


  #region methods

/// <summary>
  /// Invokes `accSelect`.
  /// </summary>
  /// <param name="flagsSelect">The `flagsSelect` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accselect?view=office-pia"/>
  public new void accSelect(int flagsSelect, object varChild);
  /// <summary>
  /// Invokes `accLocation`.
  /// </summary>
  /// <param name="pxLeft">The `pxLeft` parameter.</param>
  /// <param name="pyTop">The `pyTop` parameter.</param>
  /// <param name="pcxWidth">The `pcxWidth` parameter.</param>
  /// <param name="pcyHeight">The `pcyHeight` parameter.</param>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.acclocation?view=office-pia"/>
  public new void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
  /// <summary>
  /// Invokes `accNavigate`.
  /// </summary>
  /// <param name="navDir">The `navDir` parameter.</param>
  /// <param name="varStart">The `varStart` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accnavigate?view=office-pia"/>
  public new object accNavigate(int navDir, object varStart);
  /// <summary>
  /// Invokes `accHitTest`.
  /// </summary>
  /// <param name="xLeft">The `xLeft` parameter.</param>
  /// <param name="yTop">The `yTop` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.acchittest?view=office-pia"/>
  public new object accHitTest(int xLeft, int yTop);
  /// <summary>
  /// Invokes `accDoDefaultAction`.
  /// </summary>
  /// <param name="varChild">The `varChild` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.accdodefaultaction?view=office-pia"/>
  public new void accDoDefaultAction(object varChild);
  /// <summary>
  /// Copies the command bar control.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.copy?view=office-pia"/>
  public CommandBarControl Copy(object Bar, object Before);
  /// <summary>
  /// Deletes the command bar control.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.delete?view=office-pia"/>
  public void Delete(object Temporary);
  /// <summary>
  /// Executes the command bar control action.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.execute?view=office-pia"/>
  public void Execute();
  /// <summary>
  /// Moves the command bar control to a new location.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.move?view=office-pia"/>
  public CommandBarControl Move(object Bar, object Before);
  /// <summary>
  /// Resets the command bar control to its default settings.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reset?view=office-pia"/>
  public void Reset();
  /// <summary>
  /// Sets focus to the command bar control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.setfocus?view=office-pia"/>
  public void SetFocus();
  /// <summary>
  /// Invokes `Reserved1`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reserved1?view=office-pia"/>
  public void Reserved1();
  /// <summary>
  /// Invokes `Reserved2`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reserved2?view=office-pia"/>
  public void Reserved2();
  /// <summary>
  /// Invokes `Reserved3`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reserved3?view=office-pia"/>
  public void Reserved3();
  /// <summary>
  /// Invokes `Reserved4`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reserved4?view=office-pia"/>
  public void Reserved4();
  /// <summary>
  /// Invokes `Reserved5`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reserved5?view=office-pia"/>
  public void Reserved5();
  /// <summary>
  /// Invokes `Reserved6`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reserved6?view=office-pia"/>
  public void Reserved6();
  /// <summary>
  /// Invokes `Reserved7`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reserved7?view=office-pia"/>
  public void Reserved7();

  #endregion methods
}

