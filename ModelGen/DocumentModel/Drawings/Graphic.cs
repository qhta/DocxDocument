namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of a single graphic object. Document authors should refer to this element when they wish to persist a graphical object of some kind. The specification for this graphical object is provided entirely by the document author and referenced within the graphicData child element.
/// </summary>
public partial class Graphic: ModelElement<DXD.Graphic>
{
  public Graphic(): base(){ }
  
  public Graphic(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Graphic(DXD.Graphic openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Graphic Object Data.
  /// </summary>
  [DataMember]
  public DMD.GraphicData? GraphicData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GraphicData>();
      if (element != null)
        return GraphicDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GraphicData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GraphicDataConverter.CreateOpenXmlElement<DXD.GraphicData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
