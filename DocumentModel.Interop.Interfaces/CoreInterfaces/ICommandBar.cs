
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a command bar in the container application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar?view=office-pia"/>
public interface ICommandBar: IMsoOleAccDispObj
{
  /// <summary>
  /// Gets the `BuiltIn` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.builtin?view=office-pia"/>
  public bool BuiltIn { get; }
  /// <summary>
  /// Gets or sets the `Context` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.context?view=office-pia"/>
  public string Context { get; set; }
  /// <summary>
  /// Gets the `Controls` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.controls?view=office-pia"/>
  public ICommandBarControls Controls { get; }
  /// <summary>
  /// Gets or sets the `Enabled` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.enabled?view=office-pia"/>
  public bool Enabled { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.height?view=office-pia"/>
  public int Height { get; set; }
  /// <summary>
  /// Gets the `Index` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.index?view=office-pia"/>
  public int Index { get; }
  /// <summary>
  /// Gets the `InstanceId` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.instanceid?view=office-pia"/>
  public int InstanceId { get; }
  /// <summary>
  /// Gets or sets the `Left` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.left?view=office-pia"/>
  public int Left { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.name?view=office-pia"/>
  public new string Name { get; set; }
  /// <summary>
  /// Gets or sets the `NameLocal` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.namelocal?view=office-pia"/>
  public string NameLocal { get; set; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.position?view=office-pia"/>
  public BarPosition Position { get; set; }
  /// <summary>
  /// Gets or sets the `RowIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.rowindex?view=office-pia"/>
  public int RowIndex { get; set; }
  /// <summary>
  /// Gets or sets the `Protection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.protection?view=office-pia"/>
  public BarProtection Protection { get; set; }
  /// <summary>
  /// Gets or sets the `Top` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.top?view=office-pia"/>
  public int Top { get; set; }
  /// <summary>
  /// Gets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.type?view=office-pia"/>
  public BarType Type { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.visible?view=office-pia"/>
  public bool Visible { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.width?view=office-pia"/>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `AdaptiveMenu` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.adaptivemenu?view=office-pia"/>
  public bool AdaptiveMenu { get; set; }
  /// <summary>
  /// Gets the `Id` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.id?view=office-pia"/>
  public int Id { get; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.instanceidptr?view=office-pia"/>
  public object InstanceIdPtr { get; }


  #region methods

  /// <summary>
  /// Deletes the command bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Finds a control on the command bar that matches the specified criteria.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="id">The `Id` parameter.</param>
  /// <param name="tag">The `Tag` parameter.</param>
  /// <param name="visible">The `Visible` parameter.</param>
  /// <param name="recursive">The `Recursive` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.findcontrol?view=office-pia"/>
  public ICommandBarControl FindControl(object type, object id, object tag, object visible, object recursive);
  /// <summary>
  /// Restores the command bar to its default state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.reset?view=office-pia"/>
  public void Reset();
  /// <summary>
  /// Displays the command bar as a shortcut menu.
  /// </summary>
  /// <param name="x">The `x` parameter.</param>
  /// <param name="y">The `y` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbar.showpopup?view=office-pia"/>
  public void ShowPopup(object x, object y);

  #endregion methods
}

