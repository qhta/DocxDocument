namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where in the z-order a shape should be moved relative to other shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msozordercmd?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoZOrderCmd")]
public enum ZOrderCmd
{
  /// <summary>
  /// Bring shape to the front.
  /// </summary>
  [InteropEnumValue("msoBringToFront")]
  BringToFront,
  /// <summary>
  /// Send shape to the back.
  /// </summary>
  [InteropEnumValue("msoSendToBack")]
  SendToBack,
  /// <summary>
  /// Bring shape forward.
  /// </summary>
  [InteropEnumValue("msoBringForward")]
  BringForward,
  /// <summary>
  /// Send shape backward.
  /// </summary>
  [InteropEnumValue("msoSendBackward")]
  SendBackward,
  /// <summary>
  /// Bring shape in front of text.
  /// </summary>
  [InteropEnumValue("msoBringInFrontOfText")]
  BringInFrontOfText,
  /// <summary>
  /// Send shape behind text.
  /// </summary>
  [InteropEnumValue("msoSendBehindText")]
  SendBehindText
}
