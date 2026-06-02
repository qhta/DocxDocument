
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a command bar control.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol?view=office-pia"/>
public partial class CommandBarControl: MsoOleAccDispObj
{
  /// <summary>
  /// Gets or sets the `BeginGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.begingroup?view=office-pia"/>
  public bool BeginGroup { get; set; }
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.builtin?view=office-pia"/>
  public bool BuiltIn => throw new NotImplementedException();
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.caption?view=office-pia"/>
  public string Caption { get; set; }
  /// <summary>
  /// Gets the `Control` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.control?view=office-pia"/>
  public object Control => throw new NotImplementedException();
  /// <summary>
  /// Gets or sets the `DescriptionText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.descriptiontext?view=office-pia"/>
  public string DescriptionText { get; set; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.enabled?view=office-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.height?view=office-pia"/>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `HelpContextId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.helpcontextid?view=office-pia"/>
  public int HelpContextId { get; set; }
  /// <summary>
  /// Gets or sets the `HelpFile` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.helpfile?view=office-pia"/>
  public string HelpFile { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.id?view=office-pia"/>
  public int Id => throw new NotImplementedException();
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.index?view=office-pia"/>
  public int Index => throw new NotImplementedException();
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.instanceid?view=office-pia"/>
  public int InstanceId => throw new NotImplementedException();
  /// <summary>
  /// Gets the `Left` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.left?view=office-pia"/>
  public int Left => throw new NotImplementedException();
  /// <summary>
  /// Gets or sets the `OLEUsage` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.oleusage?view=office-pia"/>
  public ControlOLEUsage OLEUsage { get; set; }
  /// <summary>
  /// Gets or sets the `OnAction` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.onaction?view=office-pia"/>
  public string OnAction { get; set; }
  /// <summary>
  /// Gets or sets the `Parameter` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.parameter?view=office-pia"/>
  public string Parameter { get; set; }
  /// <summary>
  /// Gets or sets the `Priority` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.priority?view=office-pia"/>
  public int Priority { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.tag?view=office-pia"/>
  public string Tag { get; set; }
  /// <summary>
  /// Gets or sets the `TooltipText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.tooltiptext?view=office-pia"/>
  public string TooltipText { get; set; }
  /// <summary>
  /// Gets the `Top` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.top?view=office-pia"/>
  public int Top => throw new NotImplementedException();
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.type?view=office-pia"/>
  public ControlType Type => throw new NotImplementedException();
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.visible?view=office-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.width?view=office-pia"/>
  public int Width { get; set; }
  /// <summary>
  /// Gets the `IsPriorityDropped` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.isprioritydropped?view=office-pia"/>
  public bool IsPriorityDropped => throw new NotImplementedException();


  #region methods

  /// <summary>
  /// Copies the command bar control.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.copy?view=office-pia"/>
  public CommandBarControl Copy(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes the command bar control.
  /// </summary>
  /// <param name="Temporary">The `Temporary` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.delete?view=office-pia"/>
  public void Delete(object Temporary) { throw new NotImplementedException(); }
  /// <summary>
  /// Executes the command bar control action.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.execute?view=office-pia"/>
  public void Execute() { throw new NotImplementedException(); }
  /// <summary>
  /// Moves the command bar control to a new location.
  /// </summary>
  /// <param name="Bar">The `Bar` parameter.</param>
  /// <param name="Before">The `Before` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.move?view=office-pia"/>
  public CommandBarControl Move(object Bar, object Before) { throw new NotImplementedException(); }
  /// <summary>
  /// Resets the command bar control to its default settings.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.reset?view=office-pia"/>
  public void Reset() { throw new NotImplementedException(); }
  /// <summary>
  /// Sets focus to the command bar control.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarcontrol.setfocus?view=office-pia"/>
  public void SetFocus() { throw new NotImplementedException(); }

  #endregion methods
}

