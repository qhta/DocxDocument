namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Connection Shape.
/// </summary>
public partial class ConnectionShape: ModelElement<DXDCD.ConnectionShape>
{
  public ConnectionShape(): base(){ }
  
  public ConnectionShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectionShape(DXDCD.ConnectionShape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Macro);
    }
    set
    {
      _ExistingElement.Macro = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get
    {
      return _Element?.Published?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Published = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Published = null;
    }
  }
  
  
  /// <summary>
  ///   Connector Non Visual Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualConnectorShapeDrawingProperties? NonVisualConnectorShapeDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualConnectorShapeDrawingProperties,DXDCD.NonVisualConnectorShapeDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualConnectorShapeDrawingProperties,DXDCD.NonVisualConnectorShapeDrawingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.ShapeProperties,DXDCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.ShapeProperties,DXDCD.ShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Connection Shape Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get
    {
      return _Element?.GetObject<DMDCD.Style,DXDCD.Style>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.Style,DXDCD.Style>(value);
    }
  }
  
}
