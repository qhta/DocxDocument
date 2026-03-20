
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents high-low lines in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines?view=office-pia
/// </remarks>
public partial interface IMsoHiLoLines
{
  /// <summary>
  /// Selects the high-low lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Deletes the high-low lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
