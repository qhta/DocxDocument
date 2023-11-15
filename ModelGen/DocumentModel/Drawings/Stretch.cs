namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a BLIP should be stretched to fill the target rectangle. The other option is a tile where a BLIP is tiled to fill the available area.
/// </summary>
public partial class Stretch: ModelElement<DXD.Stretch>
{
  public Stretch(): base(){ }
  
  public Stretch(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Stretch(DXD.Stretch openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Fill Rectangle.
  /// </summary>
  [DataMember]
  public DMD.FillRectangle? FillRectangle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.RelativeRectangleType");
  }
  
}
