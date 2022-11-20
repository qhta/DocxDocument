namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Algorithm.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IParameter))]
public class Algorithm: IAlgorithm
{
  /// <summary>
  /// Algorithm Type
  /// </summary>
  public AlgorithmValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Revision Number
  /// </summary>
  public uint? Revision
  {
    get;
    set;
  }
  
}
