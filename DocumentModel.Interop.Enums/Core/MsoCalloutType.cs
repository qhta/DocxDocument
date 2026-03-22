namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of callout line.
/// </summary>
public enum MsoCalloutType
{
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  One = 1,
  /// <summary>
  /// Single, angled callout line. msoCalloutThree3 Callout line made up of two line segments. Callout line is
  /// attached on left side of text bounding box. msoCalloutFour4 Callout line made up of two line segments. Callout
  /// line is attached on right side of text bounding box.
  /// </summary>
  Two = 2,
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  Three = 3,
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  Four = 4
}
