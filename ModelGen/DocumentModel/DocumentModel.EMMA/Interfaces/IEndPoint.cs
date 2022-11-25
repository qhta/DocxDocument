namespace DocumentModel.EMMA;

/// <summary>
/// Defines the EndPoint Class.
/// </summary>
public interface IEndPoint // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// endpoint-role
  /// </summary>
  public DocumentModel.EMMA.EndPointRoleKind? EndpointRole { get ; set; }
  
  /// <summary>
  /// endpoint-address
  /// </summary>
  public System.String? EndPointAddress { get ; set; }
  
  /// <summary>
  /// message-id
  /// </summary>
  public System.String? MessageId { get ; set; }
  
  /// <summary>
  /// port-num
  /// </summary>
  public System.Int32? PortNumber { get ; set; }
  
  /// <summary>
  /// port-type
  /// </summary>
  public System.String? PortType { get ; set; }
  
  /// <summary>
  /// endpoint-pair-ref
  /// </summary>
  public System.String? EndpointPairRef { get ; set; }
  
  /// <summary>
  /// service-name
  /// </summary>
  public System.String? ServiceName { get ; set; }
  
  /// <summary>
  /// media-type
  /// </summary>
  public System.String? MediaType { get ; set; }
  
  /// <summary>
  /// medium
  /// </summary>
  public System.Collections.Generic.List<DocumentModel.EMMA.MediumKind>? Medium { get ; set; }
  
  /// <summary>
  /// mode
  /// </summary>
  public System.Collections.Generic.List<System.String>? Mode { get ; set; }
  
}
