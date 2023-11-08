namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the ShapeTree Class.
/// </summary>
public partial class ShapeTree: ModelElement<DXOD.ShapeTree>
{
  public ShapeTree(): base(){ }
  
  public ShapeTree(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeTree(DXOD.ShapeTree openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDO.GroupShapeNonVisualProperties? GroupShapeNonVisualProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
      if (element != null)
        return GroupShapeNonVisualPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.GroupShapeNonVisualProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapeNonVisualPropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeNonVisualProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDO.GroupShapeProperties? GroupShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.GroupShapeProperties>();
      if (element != null)
        return GroupShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.GroupShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupShapePropertiesConverter.CreateOpenXmlElement<DXOD.GroupShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXOD.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXOD.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXOD.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
