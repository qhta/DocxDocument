namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the leader character for tab stops.
/// </summary>
public enum TabLeaderKind
{
  /// <summary>No leader</summary>
  None = 0,
  /// <summary>Dotted leader</summary>
  Dots = 1,
  /// <summary>Dashed leader</summary>
  Dashes = 2,
  /// <summary>Solid line leader</summary>
  Line = 3,
  /// <summary>Heavy line leader</summary>
  Heavy = 4,
  /// <summary>Middle dot leader</summary>
  MiddleDot = 5
}