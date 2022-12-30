namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public partial class BevelType
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Width { get; set; }
  
  /// <summary>
  /// h, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? Height { get; set; }
  
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelPresetKind? PresetProfileType { get; set; }
  
}
