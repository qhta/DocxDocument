namespace DocumentModel.Drawings;

/// <summary>
/// Algorithm.
/// </summary>
public interface Algorithm
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public AlgorithmKind? Type { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
