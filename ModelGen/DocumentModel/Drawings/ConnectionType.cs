namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ConnectionType Class.
/// </summary>
public partial class ConnectionType: ModelElement<DXD.ConnectionType>
{
  public ConnectionType(): base(){ }
  
  public ConnectionType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectionType(DXD.ConnectionType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Identifier
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  
  /// <summary>
  ///   Index
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get
    {
      return _Element?.Index?.Value;
    }
    set
    {
      _ExistingElement.Index = value;
    }
  }
  
}
