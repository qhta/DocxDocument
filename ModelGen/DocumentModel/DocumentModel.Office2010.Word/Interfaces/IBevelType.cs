namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public interface IBevelType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? Width { get ; set; }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int64? Height { get ; set; }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.BevelPresetKind? PresetProfileType { get ; set; }
  
}
