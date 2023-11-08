namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ShowingPlaceholder Class.
/// </summary>
public partial class ShowingPlaceholder: ModelElement<DXW.ShowingPlaceholder>
{
  public ShowingPlaceholder(): base(){ }
  
  public ShowingPlaceholder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShowingPlaceholder(DXW.ShowingPlaceholder openXmlElement): base(openXmlElement) { }
  
}
