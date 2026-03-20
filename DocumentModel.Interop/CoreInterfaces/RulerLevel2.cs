
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `RulerLevel2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface RulerLevel2: InteropObject
{
  /// <summary>
  /// Gets or sets the `FirstMargin` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2.firstmargin?view=office-pia
  /// </remarks>
  public float FirstMargin { get; set; }
  /// <summary>
  /// Gets or sets the `LeftMargin` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2.leftmargin?view=office-pia
  /// </remarks>
  public float LeftMargin { get; set; }
}
