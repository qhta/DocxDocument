using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a check box in the Office Assistant balloon.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox?view=office-pia"/>
public partial interface IBalloonCheckbox: IInteropObject
{
  /// <summary>
  /// Gets the item text associated with the check box.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.item?view=office-pia"/>
  public string Item { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `Checked` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.checked?view=office-pia"/>
  public bool Checked { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ballooncheckbox.text?view=office-pia"/>
  public string Text { get; set; }
}

