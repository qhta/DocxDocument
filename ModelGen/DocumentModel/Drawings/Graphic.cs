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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
