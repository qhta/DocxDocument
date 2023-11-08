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
      var element = _Element?.GetFirstChild<DXOD.NonVisualDrawingProperties>();
      if (element != null)
        return NonVisualDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXOD.NonVisualDrawingShapeProperties>();
      if (element != null)
        return NonVisualDrawingShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.NonVisualDrawingShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingShapePropertiesConverter.CreateOpenXmlElement<DXOD.NonVisualDrawingShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
