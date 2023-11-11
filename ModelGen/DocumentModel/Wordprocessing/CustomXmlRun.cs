namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a custom XML element around one or more inline level structures (runs, images, fields, etc.) within a paragraph. The attributes on this element shall be used to specify the name and namespace URI of the current custom XML element.
/// </summary>
public partial class CustomXmlRun: ModelElement<DXW.CustomXmlRun>
{
  public CustomXmlRun(): base(){ }
  
  public CustomXmlRun(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlRun(DXW.CustomXmlRun openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.CustomXmlProperties? CustomXmlProperties
  {
    get
    {
      return _Element?.GetObject<DMW.CustomXmlProperties,DXW.CustomXmlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.CustomXmlProperties,DXW.CustomXmlProperties>(value);
    }
  }
  
}
