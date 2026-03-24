namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies starting position of the callout line relative to the text bounding box.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocalloutdroptype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoCalloutDropType
{
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  Custom = 1,
  /// <summary>
  /// Top. msoCalloutDropCenter3 Center. msoCalloutDropBottom4 Bottom.
  /// </summary>
  Top = 2,
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  Center = 3,
  /// <summary>
  /// Specifies starting position of the callout line relative to the text bounding box.
  /// </summary>
  Bottom = 4
}
