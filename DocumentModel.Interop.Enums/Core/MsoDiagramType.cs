
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of diagram.
/// </summary>
public enum MsoDiagramType
{
  /// <summary>
  /// Specifies the type of diagram.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Specifies the type of diagram.
  /// </summary>
  OrgChart = 1,
  /// <summary>
  /// Cycle diagram.
  /// </summary>
  Cycle = 2,
  /// <summary>
  /// Radial diagram. msoDiagramPyramid4 Pyramid diagram.
  /// </summary>
  Radial = 3,
  /// <summary>
  /// Specifies the type of diagram.
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
