namespace DocumentModel.Bibliography;

/// <summary>
/// Producer Name.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Bibliography.INameList))]
public class ProducerName: IProducerName
{
  /// <summary>
  /// Name List.
  /// </summary>
  public INameList? NameList
  {
    get;
    set;
  }
  
}
