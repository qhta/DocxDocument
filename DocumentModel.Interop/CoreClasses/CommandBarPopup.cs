
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a pop-up control on a command bar.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup?view=office-pia"/>
public partial class CommandBarPopup: CommandBarControl
{
  /// <summary>
  /// Gets or sets the `accValue` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accvalue?view=office-pia"/>
  public string Value { get; set; }
  /// <summary>
  /// Gets the `accDescription` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accdescription?view=office-pia"/>
  public string Description { get; }
  /// <summary>
  /// Gets the `accRole` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accrole?view=office-pia"/>
  public object Role { get; }
  /// <summary>
  /// Gets the `accState` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accstate?view=office-pia"/>
  public object State { get; }
  /// <summary>
  /// Gets the `accHelp` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acchelp?view=office-pia"/>
  public string Help { get; }
  /// <summary>
  /// Gets the `accHelpTopic` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acchelptopic?view=office-pia"/>
  public int HelpTopic { get; }
  /// <summary>
  /// Gets the `accKeyboardShortcut` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.acckeyboardshortcut?view=office-pia"/>
  public string KeyboardShortcut { get; }
  /// <summary>
  /// Gets the `accFocus` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accfocus?view=office-pia"/>
  public object Focus { get; }
  /// <summary>
  /// Gets the `accSelection` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accselection?view=office-pia"/>
  public object Selection { get; }
  /// <summary>
  /// Gets the `accDefaultAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.accdefaultaction?view=office-pia"/>
  public string DefaultAction { get; }
  /// <summary>
  /// Gets or sets the `BeginGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.begingroup?view=office-pia"/>
  public bool BeginGroup { get; set; }
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.builtin?view=office-pia"/>
  public bool BuiltIn { get; }
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.caption?view=office-pia"/>
  public string Caption { get; set; }
  /// <summary>
  /// Gets the `Control` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.control?view=office-pia"/>
  public object Control { get; }
  /// <summary>
  /// Gets or sets the `DescriptionText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.descriptiontext?view=office-pia"/>
  public string DescriptionText { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.enabled?view=office-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.height?view=office-pia"/>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `HelpContextId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.helpcontextid?view=office-pia"/>
  public int HelpContextId { get; set; }
  /// <summary>
  /// Gets or sets the `HelpFile` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.helpfile?view=office-pia"/>
  public string HelpFile { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.id?view=office-pia"/>
  public int Id { get; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.instanceid?view=office-pia"/>
  public int InstanceId { get; }
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.left?view=office-pia"/>
  public int Left { get; }
  /// <summary>
  /// Gets or sets the `OLEUsage` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.oleusage?view=office-pia"/>
  public ControlOLEUsage OLEUsage { get; set; }
  /// <summary>
  /// Gets or sets the `OnAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.onaction?view=office-pia"/>
  public string OnAction { get; set; }
  /// <summary>
  /// Gets or sets the `Parameter` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.parameter?view=office-pia"/>
  public string Parameter { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.priority?view=office-pia"/>
  public int Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.tag?view=office-pia"/>
  public string Tag { get; set; }
  /// <summary>
  /// Gets or sets the `TooltipText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.tooltiptext?view=office-pia"/>
  public string TooltipText { get; set; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.top?view=office-pia"/>
  public int Top { get; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.type?view=office-pia"/>
  public ControlType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.visible?view=office-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.width?view=office-pia"/>
  public int Width { get; set; }
  /// <summary>
  /// Gets the `IsPriorityDropped` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.isprioritydropped?view=office-pia"/>
  public bool IsPriorityDropped { get; }
  /// <summary>
  /// Gets the `CommandBar` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.commandbar?view=office-pia"/>
  public CommandBar CommandBar { get; }
  /// <summary>
  /// Gets the `Controls` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.controls?view=office-pia"/>
  public CommandBarControls Controls { get; }
  /// <summary>
  /// Gets or sets the `OLEMenuGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.olemenugroup?view=office-pia"/>
  public OLEMenuGroup OLEMenuGroup { get; set; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.instanceidptr?view=office-pia"/>
  public object InstanceIdPtr { get; }
}

