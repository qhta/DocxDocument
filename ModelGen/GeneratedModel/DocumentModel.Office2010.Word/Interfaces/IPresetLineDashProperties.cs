namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the PresetLineDashProperties Class.
/// </summary>
public interface IPresetLineDashProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.PresetLineDash? Val { get ; set; }
  
}
