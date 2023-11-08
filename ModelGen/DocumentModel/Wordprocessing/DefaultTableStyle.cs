namespace DocumentModel.Wordprocessing;


/// <summary>
///   Default Table Style for Newly Inserted Tables.
/// </summary>
public partial class DefaultTableStyle: ModelElement<DXW.DefaultTableStyle>
{
  public DefaultTableStyle(): base(){ }
  
  public DefaultTableStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DefaultTableStyle(DXW.DefaultTableStyle openXmlElement): base(openXmlElement) { }
  
}
