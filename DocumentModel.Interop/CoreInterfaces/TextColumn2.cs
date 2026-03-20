
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextColumn2` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2?view=office-pia
/// </remarks>
public partial interface TextColumn2: InteropObject
{
  /// <summary>
  /// Gets or sets the `Number` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2.number?view=office-pia
  /// </remarks>
  public int Number { get; set; }
  /// <summary>
  /// Gets or sets the `Spacing` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2.spacing?view=office-pia
  /// </remarks>
  public float Spacing { get; set; }
  /// <summary>
  /// Gets or sets the `TextDirection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2.textdirection?view=office-pia
  /// </remarks>
  public MsoTextDirection TextDirection { get; set; }
}
