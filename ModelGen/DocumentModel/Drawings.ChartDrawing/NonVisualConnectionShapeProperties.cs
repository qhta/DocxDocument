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
      var element = _Element?.GetFirstChild<DXD.ConnectionShapeLocks>();
      if (element != null)
        return ConnectionShapeLocksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ConnectionShapeLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionShapeLocksConverter.CreateOpenXmlElement<DXD.ConnectionShapeLocks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.StartConnection>();
      if (element != null)
        return StartConnectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.StartConnection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StartConnectionConverter.CreateOpenXmlElement<DXD.StartConnection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.EndConnection>();
      if (element != null)
        return EndConnectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EndConnection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndConnectionConverter.CreateOpenXmlElement<DXD.EndConnection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
