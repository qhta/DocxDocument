namespace DocumentModel.Wordprocessing;


/// <summary>
///   Checkbox Form Field State.
/// </summary>
public partial class Checked: ModelElement<DXW.Checked>
{
  public Checked(): base(){ }
  
  public Checked(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Checked(DXW.Checked openXmlElement): base(openXmlElement) { }
  
}
