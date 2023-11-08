namespace DocumentModel.Wordprocessing;


/// <summary>
///   Default Properties for VML Objects in Header and Footer.
/// </summary>
public partial class HeaderShapeDefaults: ModelElement<DXW.HeaderShapeDefaults>
{
  public HeaderShapeDefaults(): base(){ }
  
  public HeaderShapeDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderShapeDefaults(DXW.HeaderShapeDefaults openXmlElement): base(openXmlElement) { }
  
}
