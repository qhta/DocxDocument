namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of callout line.
/// </summary>
public enum MsoCalloutType
{
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  msoCalloutMixed = -2,
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  msoCalloutOne = 1,
  /// <summary>
  /// Single, angled callout line. msoCalloutThree3 Callout line made up of two line segments. Callout line is
  /// attached on left side of text bounding box. msoCalloutFour4 Callout line made up of two line segments. Callout
  /// line is attached on right side of text bounding box.
  /// </summary>
  msoCalloutTwo = 2,
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  msoCalloutThree = 3,
  /// <summary>
  /// Specifies the type of callout line.
  /// </summary>
  msoCalloutFour = 4
}
