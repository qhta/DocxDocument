using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TabStops2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface TabStops2: InteropDictionary<string, TabStop2>
{
  /// <summary>
  /// Gets or sets the `DefaultSpacing` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstops2.defaultspacing?view=office-pia
  /// </remarks>
  public float DefaultSpacing { get; set; }
}
