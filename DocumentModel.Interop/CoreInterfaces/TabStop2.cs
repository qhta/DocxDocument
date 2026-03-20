
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TabStop2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface TabStop2: InteropObject
{
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.position?view=office-pia
  /// </remarks>
  public float Position { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.type?view=office-pia
  /// </remarks>
  public MsoTabStopType Type { get; set; }
}
