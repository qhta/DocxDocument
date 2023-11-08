namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundProperties Class.
/// </summary>
public partial class BackgroundProperties: ModelElement<DXO13D.BackgroundProperties>
{
  public BackgroundProperties(): base(){ }
  
  public BackgroundProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundProperties(DXO13D.BackgroundProperties openXmlElement): base(openXmlElement) { }
  
}
