namespace DocumentModel.Drawings;

/// <summary>
/// Algorithm.
/// </summary>
public interface Algorithm
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public DocumentModel.Drawings.AlgorithmKind? Type { get ; set; }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public UInt32? Revision { get ; set; }
  
  public Collection<DocumentModel.Drawings.Parameter>? Parameters { get ; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
