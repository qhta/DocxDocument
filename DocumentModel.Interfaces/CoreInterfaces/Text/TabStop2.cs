
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TabStop2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2?view=office-pia"/>
public partial interface TabStop2: InteropObject
{
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.position?view=office-pia"/>
  public float Position { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.type?view=office-pia"/>
  public TabStopType Type { get; set; }
}

