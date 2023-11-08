namespace DocumentModel.Wordprocessing;


/// <summary>
///   Default Properties for VML Objects in Main Document.
/// </summary>
public partial class ShapeDefaults: ModelElement<DXW.ShapeDefaults>
{
  public ShapeDefaults(): base(){ }
  
  public ShapeDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeDefaults(DXW.ShapeDefaults openXmlElement): base(openXmlElement) { }
  
}
