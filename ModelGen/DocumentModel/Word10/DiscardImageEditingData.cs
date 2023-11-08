namespace DocumentModel.Word10;


/// <summary>
///   An OnOff element specifies that when true, the cropped-out areas of the images are not to be saved. Rather, the images saved are the results of applying imgProps on the original images.
/// </summary>
public partial class DiscardImageEditingData: ModelElement<DXO10W.DiscardImageEditingData>
{
  public DiscardImageEditingData(): base(){ }
  
  public DiscardImageEditingData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiscardImageEditingData(DXO10W.DiscardImageEditingData openXmlElement): base(openXmlElement) { }
  
}
