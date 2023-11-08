namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the style ID of the parent style from which this style inherits in the style inheritance. The style inheritance refers to a set of styles which inherit from one another to produce the resulting set of properties for a single style. The val attribute of this element specifies the styleId attribute for the parent style in the style inheritance.
/// </summary>
public partial class BasedOn: ModelElement<DXW.BasedOn>
{
  public BasedOn(): base(){ }
  
  public BasedOn(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BasedOn(DXW.BasedOn openXmlElement): base(openXmlElement) { }
  
}
