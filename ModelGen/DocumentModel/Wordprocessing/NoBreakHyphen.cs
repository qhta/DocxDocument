namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that a nonbreaking hyphen character shall be placed at the current location in the run content.
/// </summary>
public partial class NoBreakHyphen: ModelElement<DXW.NoBreakHyphen>
{
  public NoBreakHyphen(): base(){ }
  
  public NoBreakHyphen(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoBreakHyphen(DXW.NoBreakHyphen openXmlElement): base(openXmlElement) { }
  
}
