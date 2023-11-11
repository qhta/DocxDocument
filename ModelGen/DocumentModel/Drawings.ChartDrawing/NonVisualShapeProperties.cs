namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Shape Properties.
/// </summary>
public partial class NonVisualShapeProperties: ModelElement<DXDCD.NonVisualShapeProperties>
{
  public NonVisualShapeProperties(): base(){ }
  
  public NonVisualShapeProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualShapeProperties(DXDCD.NonVisualShapeProperties openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Non-Visual Shape Drawing Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualShapeDrawingProperties? NonVisualShapeDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD.NonVisualShapeDrawingProperties,DXDCD.NonVisualShapeDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD.NonVisualShapeDrawingProperties,DXDCD.NonVisualShapeDrawingProperties>(value);
    }
  }
  
}
