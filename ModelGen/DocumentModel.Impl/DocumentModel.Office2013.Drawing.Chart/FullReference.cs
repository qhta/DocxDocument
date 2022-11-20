namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FullReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ISequenceOfReferences))]
public class FullReference: IFullReference
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public ISequenceOfReferences? SequenceOfReferences
  {
    get;
    set;
  }
  
}
