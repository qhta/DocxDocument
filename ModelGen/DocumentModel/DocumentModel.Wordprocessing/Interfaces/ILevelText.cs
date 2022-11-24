namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public interface ILevelText // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Level Text
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  public Boolean? Null { get ; set; }
  
}
