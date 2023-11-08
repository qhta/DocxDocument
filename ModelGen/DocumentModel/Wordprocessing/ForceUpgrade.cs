namespace DocumentModel.Wordprocessing;


/// <summary>
///   Upgrade Document on Open.
/// </summary>
public partial class ForceUpgrade: ModelElement<DXW.ForceUpgrade>
{
  public ForceUpgrade(): base(){ }
  
  public ForceUpgrade(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ForceUpgrade(DXW.ForceUpgrade openXmlElement): base(openXmlElement) { }
  
}
