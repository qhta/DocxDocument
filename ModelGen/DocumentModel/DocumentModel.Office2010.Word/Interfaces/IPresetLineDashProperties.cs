namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the PresetLineDashProperties Class.
/// </summary>
public interface IPresetLineDashProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetLineDashValues? Val { get ; set; }
  
}
