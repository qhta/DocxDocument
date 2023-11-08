namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Display Visual Boundary For Header/Footer or Between Pages.
/// </summary>
public partial class DoNotDisplayPageBoundaries: ModelElement<DXW.DoNotDisplayPageBoundaries>
{
  public DoNotDisplayPageBoundaries(): base(){ }
  
  public DoNotDisplayPageBoundaries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotDisplayPageBoundaries(DXW.DoNotDisplayPageBoundaries openXmlElement): base(openXmlElement) { }
  
}
