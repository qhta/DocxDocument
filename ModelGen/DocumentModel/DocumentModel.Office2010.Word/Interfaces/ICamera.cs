namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public interface ICamera // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetCameraTypeValues? PresetCameraType { get ; set; }
  
}
