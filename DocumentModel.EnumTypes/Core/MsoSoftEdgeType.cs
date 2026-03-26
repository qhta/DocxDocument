namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of soft edge effect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosoftedgetype?view=office-pia` for Office interop details.
/// </remarks>
public enum SoftEdgeType
{
  /// <summary>
  /// A mix of soft edge types.
  /// </summary>
  /// <summary>
  /// No soft edge.
  /// </summary>
  None = 0,
  /// <summary>
  /// Soft Edge
  /// </summary>
  Type1 = 1,
  /// <summary>
  /// Soft Edge
  /// </summary>
  Type2 = 2,
  /// <summary>
  /// Soft Edge
  /// </summary>
  Type3 = 3,
  /// <summary>
  /// Soft Edge
  /// </summary>
  Type4 = 4,
  /// <summary>
  /// Soft Edge
  /// </summary>
  Type5 = 5,
  /// <summary>
  /// Soft Edge
  /// </summary>
  Type6 = 6
}
