namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Text.
/// </summary>
public interface ILevelText // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Level Text
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// Level Text Is Null Character
  /// </summary>
  public System.Boolean? Null { get ; set; }
  
}
