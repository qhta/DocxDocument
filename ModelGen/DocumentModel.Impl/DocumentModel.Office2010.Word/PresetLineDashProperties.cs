namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the PresetLineDashProperties Class.
/// </summary>
public class PresetLineDashProperties: IPresetLineDashProperties
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.PresetLineDashValues? Val
  {
    get;
    set;
  }
  
}
