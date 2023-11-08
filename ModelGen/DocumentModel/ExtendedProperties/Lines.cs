namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Number of Lines.
/// </summary>
public partial class Lines: ModelElement<DXEP.Lines>
{
  public Lines(): base(){ }
  
  public Lines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Lines(DXEP.Lines openXmlElement): base(openXmlElement) { }
  
}
