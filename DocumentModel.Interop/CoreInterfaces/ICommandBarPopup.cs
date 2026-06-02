
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a pop-up control on a command bar.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup?view=office-pia"/>
public interface ICommandBarPopup: ICommandBarControl
{
  /// <summary>
  /// Gets the `CommandBar` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.commandbar?view=office-pia"/>
  public ICommandBar CommandBar { get; }

  /// <summary>
  /// Gets the `Controls` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.controls?view=office-pia"/>
  public ICommandBarControls Controls { get; }

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
}



