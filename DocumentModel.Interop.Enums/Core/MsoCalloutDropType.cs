namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies starting position of the callout line relative to the text bounding box.
/// </summary>
public enum MsoCalloutDropType
{
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  msoCalloutDropMixed = -2,
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  msoCalloutDropCustom = 1,
  /// <summary>
  /// Top. msoCalloutDropCenter3 Center. msoCalloutDropBottom4 Bottom.
  /// </summary>
  msoCalloutDropTop = 2,
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  msoCalloutDropCenter = 3,
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  msoCalloutDropBottom = 4
}
