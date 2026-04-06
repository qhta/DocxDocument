using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// A collection of BalloonLabel objects that represent all labels in the Office Assistant balloon.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabels?view=office-pia"/>
public partial interface IBalloonLabels: IModelCollection<IBalloon>
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloonlabels.name?view=office-pia"/>
  public string Name { get; }
}

