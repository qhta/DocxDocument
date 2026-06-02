
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a pop-up control on a command bar.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup?view=office-pia"/>
public partial class CommandBarPopup: CommandBarControl
{
  
  /// <summary>
  /// Gets or sets the `OLEMenuGroup` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.commandbarpopup.olemenugroup?view=office-pia"/>
  public OLEMenuGroup OLEMenuGroup { get; set; }
  
}

