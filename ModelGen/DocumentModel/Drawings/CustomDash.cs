namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a custom dashing scheme. It is a list of dash stop elements which represent building block atoms upon which the custom dashing scheme is built.
/// </summary>
public partial class CustomDash: ModelElement<DXD.CustomDash>
{
  public CustomDash(): base(){ }
  
  public CustomDash(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomDash(DXD.CustomDash openXmlElement): base(openXmlElement) { }
  
}
