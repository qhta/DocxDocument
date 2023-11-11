namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Group Shape Properties.
/// </summary>
public partial class NonVisualGroupShapeProperties: ModelElement<DXDCD.NonVisualGroupShapeProperties>
{
  public NonVisualGroupShapeProperties(): base(){ }
  
  public NonVisualGroupShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualGroupShapeProperties(DXDCD.NonVisualGroupShapeProperties openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Non-Visual Group Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualGroupShapeDrawingProperties? NonVisualGroupShapeDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualGroupShapeDrawingProperties,DXDCD.NonVisualGroupShapeDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualGroupShapeDrawingProperties,DXDCD.NonVisualGroupShapeDrawingProperties>(value);
    }
  }
  
}
