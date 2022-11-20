namespace DocumentModel.Presentation;

/// <summary>
/// Kiosk Slide Show Mode.
/// </summary>
public interface IKioskSlideMode // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Restart Show
  /// </summary>
  public uint? Restart { get ; set; }
  
}
