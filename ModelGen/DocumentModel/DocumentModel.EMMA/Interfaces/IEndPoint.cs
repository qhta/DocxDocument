namespace DocumentModel.EMMA;

/// <summary>
/// Defines the EndPoint Class.
/// </summary>
public interface IEndPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// endpoint-role
  /// </summary>
  public EndPointRoleValues? EndpointRole { get ; set; }
  
  /// <summary>
  /// endpoint-address
  /// </summary>
  public String? EndPointAddress { get ; set; }
  
  /// <summary>
  /// message-id
  /// </summary>
  public String? MessageId { get ; set; }
  
  /// <summary>
  /// port-num
  /// </summary>
  public Int32? PortNumber { get ; set; }
  
  /// <summary>
  /// port-type
  /// </summary>
  public String? PortType { get ; set; }
  
  /// <summary>
  /// endpoint-pair-ref
  /// </summary>
  public String? EndpointPairRef { get ; set; }
  
  /// <summary>
  /// service-name
  /// </summary>
  public String? ServiceName { get ; set; }
  
  /// <summary>
  /// media-type
  /// </summary>
  public String? MediaType { get ; set; }
  
  /// <summary>
  /// medium
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.EnumValue<MediumValues>>? Medium { get ; set; }
  
  /// <summary>
  /// mode
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? Mode { get ; set; }
  
}
