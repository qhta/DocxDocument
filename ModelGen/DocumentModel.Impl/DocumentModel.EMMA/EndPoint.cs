namespace DocumentModel.EMMA;

/// <summary>
/// Defines the EndPoint Class.
/// </summary>
public class EndPoint: IEndPoint
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// endpoint-role
  /// </summary>
  public EndPointRoleValues? EndpointRole
  {
    get;
    set;
  }
  
  /// <summary>
  /// endpoint-address
  /// </summary>
  public string? EndPointAddress
  {
    get;
    set;
  }
  
  /// <summary>
  /// message-id
  /// </summary>
  public string? MessageId
  {
    get;
    set;
  }
  
  /// <summary>
  /// port-num
  /// </summary>
  public int? PortNumber
  {
    get;
    set;
  }
  
  /// <summary>
  /// port-type
  /// </summary>
  public string? PortType
  {
    get;
    set;
  }
  
  /// <summary>
  /// endpoint-pair-ref
  /// </summary>
  public string? EndpointPairRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// service-name
  /// </summary>
  public string? ServiceName
  {
    get;
    set;
  }
  
  /// <summary>
  /// media-type
  /// </summary>
  public string? MediaType
  {
    get;
    set;
  }
  
  /// <summary>
  /// medium
  /// </summary>
  public List<MediumValues>? Medium
  {
    get;
    set;
  }
  
  /// <summary>
  /// mode
  /// </summary>
  public List<string>? Mode
  {
    get;
    set;
  }
  
}
