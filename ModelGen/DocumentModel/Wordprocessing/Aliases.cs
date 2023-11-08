namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of alternative names for the parent style definition. These names can be used in an application's user interface as desired. The alternate names shall be stored in this element's val attribute, and each name shall be separated by one or more consecutive comma characters (Unicode character value 002C). All present commas shall be interpreted as separator character and never as part of an alternate style name.
/// </summary>
public partial class Aliases: ModelElement<DXW.Aliases>
{
  public Aliases(): base(){ }
  
  public Aliases(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Aliases(DXW.Aliases openXmlElement): base(openXmlElement) { }
  
}
