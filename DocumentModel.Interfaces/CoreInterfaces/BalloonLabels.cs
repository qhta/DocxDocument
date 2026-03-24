using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// A collection of BalloonLabel objects that represent all labels in the Office Assistant balloon.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabels?view=office-pia"/>
public partial interface BalloonLabels: InteropCollection<object>
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabels.name?view=office-pia"/>
  public string Name { get; }
}

