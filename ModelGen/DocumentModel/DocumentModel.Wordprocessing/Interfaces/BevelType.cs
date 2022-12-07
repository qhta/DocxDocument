namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BevelType Class.
/// </summary>
public interface BevelType
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public BevelPresetKind? PresetProfileType { get ; set; }
  
}
