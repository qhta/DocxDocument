namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definition Instance.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IAbstractNumId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILevelOverride))]
public class NumberingInstance: INumberingInstance
{
  /// <summary>
  /// numId
  /// </summary>
  public int? NumberID
  {
    get;
    set;
  }
  
  /// <summary>
  /// durableId
  /// </summary>
  public int? DurableId
  {
    get;
    set;
  }
  
  /// <summary>
  /// AbstractNumId.
  /// </summary>
  public IAbstractNumId? AbstractNumId
  {
    get;
    set;
  }
  
}
