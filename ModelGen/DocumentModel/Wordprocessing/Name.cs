namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the primary name for the current style in the document. This name can be used in an application's user interface as desired. The actual primary name for this style is stored in its val attribute.
/// </summary>
public partial class Name: ModelElement<DXW.Name>
{
  public Name(): base(){ }
  
  public Name(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Name(DXW.Name openXmlElement): base(openXmlElement) { }
  
}
