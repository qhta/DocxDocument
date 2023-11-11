namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Connector Non Visual Properties.
/// </summary>
public partial class NonVisualConnectorShapeDrawingProperties: ModelElement<DXDCD.NonVisualConnectorShapeDrawingProperties>
{
  public NonVisualConnectorShapeDrawingProperties(): base(){ }
  
  public NonVisualConnectorShapeDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualConnectorShapeDrawingProperties(DXDCD.NonVisualConnectorShapeDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Chart Non Visual Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualDrawingProperties,DXDCD.NonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualDrawingProperties,DXDCD.NonVisualDrawingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Connection Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualConnectionShapeProperties? NonVisualConnectionShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualConnectionShapeProperties,DXDCD.NonVisualConnectionShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualConnectionShapeProperties,DXDCD.NonVisualConnectionShapeProperties>(value);
    }
  }
  
}
