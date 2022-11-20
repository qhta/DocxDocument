namespace DocumentModel.EMMA;

/// <summary>
/// Defines the EndPointInfo Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IEndPoint))]
public class EndPointInfo: IEndPointInfo
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
