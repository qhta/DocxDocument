namespace DocumentModel.Wordprocessing;

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
  public DocumentModel.Wordprocessing.BevelPresetKind? PresetProfileType { get ; set; }
  
}
