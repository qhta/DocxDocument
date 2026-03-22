
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the connector between two similar property test values.
/// </summary>
public enum MsoConnector
{
  /// <summary>
  /// Combine property test values to form one property test.
  /// </summary>
  And = 1,
  /// <summary>
  /// Treat property test values as separate criteria.
  /// </summary>
  Or
}
