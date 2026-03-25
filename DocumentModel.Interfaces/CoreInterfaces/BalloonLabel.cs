using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a label in the Office Assistant balloon.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel?view=office-pia"/>
public partial interface BalloonLabel: InteropObject
{
  /// <summary>
  /// Gets the item associated with the label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel.item?view=office-pia"/>
  public string Item { get; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabel.text?view=office-pia"/>
  public string Text { get; set; }
}

