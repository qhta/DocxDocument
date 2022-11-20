namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the LevelReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ISequenceOfReferences))]
public class LevelReference: ILevelReference
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
