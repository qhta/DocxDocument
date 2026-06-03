namespace DocumentModel.Drawings;

/// <summary>
/// Specifies where in the z-order a shape should be moved relative Ito other shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msozordercmd?view=office-pia` for Office interop details.
/// </remarks>
public enum ZOrderCmd
{
  /// <summary>
  /// Bring shape Ito the front.
  /// </summary>
  BringToFront,
  /// <summary>
  /// Send shape Ito the back.
  /// </summary>
  SendToBack,
  /// <summary>
  /// Bring shape forward.
  /// </summary>
  BringForward,
  /// <summary>
  /// Send shape backward.
  /// </summary>
  SendBackward,
  /// <summary>
  /// Bring shape in front of text.
  /// </summary>
  BringInFrontOfText,
  /// <summary>
  /// Send shape behind text.
  /// </summary>
  SendBehindText
}

