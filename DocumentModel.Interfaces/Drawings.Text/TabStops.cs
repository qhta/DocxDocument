using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents the `TabStops2` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2?view=office-pia"/>
public partial interface ITabStops: IModelCollection<ITabStop>
{
  /// <summary>
  /// Gets or sets the `DefaultSpacing` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.defaultspacing?view=office-pia"/>
  public float DefaultSpacing { get; set; }
}

