namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Algorithm.
/// </summary>
public partial class Algorithm
{
  
  /// <summary>
  ///   Algorithm Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.AlgorithmKind? Type { get; set; }
  
  
  /// <summary>
  ///   Revision Number
  /// </summary>
  public UInt32? Revision { get; set; }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<Parameter>? Items { get; set; }
  
}
