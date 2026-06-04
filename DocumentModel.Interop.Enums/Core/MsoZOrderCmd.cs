namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where in the z-order a shape should be moved relative to other shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msozordercmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoZOrderCmd")]
public enum ZOrderCmd
{
  /// <summary>
  /// Bring shape to the front.
  /// </summary>
  [OfficeInteropEnumValue("msoBringToFront")]
  BringToFront,
  /// <summary>
  /// Send shape to the back.
  /// </summary>
  [OfficeInteropEnumValue("msoSendToBack")]
  SendToBack,
  /// <summary>
  /// Bring shape forward.
  /// </summary>
  [OfficeInteropEnumValue("msoBringForward")]
  BringForward,
  /// <summary>
  /// Send shape backward.
  /// </summary>
  [OfficeInteropEnumValue("msoSendBackward")]
  SendBackward,
  /// <summary>
  /// Bring shape in front of text.
  /// </summary>
  [OfficeInteropEnumValue("msoBringInFrontOfText")]
  BringInFrontOfText,
  /// <summary>
  /// Send shape behind text.
  /// </summary>
  [OfficeInteropEnumValue("msoSendBehindText")]
  SendBehindText
}
