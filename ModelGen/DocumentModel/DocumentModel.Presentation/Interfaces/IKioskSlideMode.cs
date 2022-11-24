namespace DocumentModel.Presentation;

/// <summary>
/// Kiosk Slide Show Mode.
/// </summary>
public interface IKioskSlideMode // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Restart Show
  /// </summary>
  public UInt32? Restart { get ; set; }
  
}
