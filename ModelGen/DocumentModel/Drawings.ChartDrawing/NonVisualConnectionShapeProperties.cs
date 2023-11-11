namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Connection Shape Drawing Properties.
/// </summary>
public partial class NonVisualConnectionShapeProperties: ModelElement<DXDCD.NonVisualConnectionShapeProperties>
{
  public NonVisualConnectionShapeProperties(): base(){ }
  
  public NonVisualConnectionShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualConnectionShapeProperties(DXDCD.NonVisualConnectionShapeProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Connection Shape Locks.
  /// </summary>
  [DataMember]
  public DMD.ConnectionShapeLocks? ConnectionShapeLocks
  {
    get
    {
      return _Element?.GetObject<DMD.ConnectionShapeLocks,DXD.ConnectionShapeLocks>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ConnectionShapeLocks,DXD.ConnectionShapeLocks>(value);
    }
  }
  
  
  /// <summary>
  ///   Connection Start.
  /// </summary>
  [DataMember]
  public DMD.StartConnection? StartConnection
  {
    get
    {
      return _Element?.GetObject<DMD.StartConnection,DXD.StartConnection>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.StartConnection,DXD.StartConnection>(value);
    }
  }
  
  
  /// <summary>
  ///   Connection End.
  /// </summary>
  [DataMember]
  public DMD.EndConnection? EndConnection
  {
    get
    {
      return _Element?.GetObject<DMD.EndConnection,DXD.EndConnection>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EndConnection,DXD.EndConnection>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
