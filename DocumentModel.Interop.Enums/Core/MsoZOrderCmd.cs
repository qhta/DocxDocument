namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies where in the z-order a shape should be moved relative to other shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msozordercmd?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoZOrderCmd))]
public enum ZOrderCmd
{
  /// <summary>
  /// Bring shape to the front.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoZOrderCmd.msoBringToFront))]
  BringToFront,
  /// <summary>
  /// Send shape to the back.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoZOrderCmd.msoSendToBack))]
  SendToBack,
  /// <summary>
  /// Bring shape forward.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoZOrderCmd.msoBringForward))]
  BringForward,
  /// <summary>
  /// Send shape backward.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoZOrderCmd.msoSendBackward))]
  SendBackward,
  /// <summary>
  /// Bring shape in front of text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoZOrderCmd.msoBringInFrontOfText))]
  BringInFrontOfText,
  /// <summary>
  /// Send shape behind text.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoZOrderCmd.msoSendBehindText))]
  SendBehindText
}
