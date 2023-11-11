namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the ShapeNonVisualProperties Class.
/// </summary>
public partial class ShapeNonVisualProperties: ModelElement<DXOD.ShapeNonVisualProperties>
{
  public ShapeNonVisualProperties(): base(){ }
  
  public ShapeNonVisualProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeNonVisualProperties(DXOD.ShapeNonVisualProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.NonVisualDrawingProperties,DXOD.NonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.NonVisualDrawingProperties,DXOD.NonVisualDrawingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   NonVisualDrawingShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.NonVisualDrawingShapeProperties,DXOD.NonVisualDrawingShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.NonVisualDrawingShapeProperties,DXOD.NonVisualDrawingShapeProperties>(value);
    }
  }
  
}
