namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the field has been changed and the results shall be updated on open in a conforming consumer.
/// </summary>
public partial class Dirty: ModelElement<DXW.Dirty>
{
  public Dirty(): base(){ }
  
  public Dirty(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Dirty(DXW.Dirty openXmlElement): base(openXmlElement) { }
  
}
