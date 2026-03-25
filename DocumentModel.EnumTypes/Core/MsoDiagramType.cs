
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of diagram.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodiagramtype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoDiagramType
{
  /// <summary>
  /// Return value only; indicates a combination of the other states.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Organization chart diagram.
  /// </summary>
  OrgChart = 1,
  /// <summary>
  /// Cycle diagram.
  /// </summary>
  Cycle = 2,
  /// <summary>
  /// Radial diagram.
  /// </summary>
  Radial = 3,
  /// <summary>
  /// Pyramid diagram.
  /// </summary>
  Pyramid = 4,
  /// <summary>
  /// Venn diagram.
  /// </summary>
  Venn = 5,
  /// <summary>
  /// Target diagram.
  /// </summary>
  Target = 6
}
