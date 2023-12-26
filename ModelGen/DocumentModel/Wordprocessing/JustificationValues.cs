namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the JustificationValues enumeration.
/// </summary>
public partial class JustificationValues: ModelElement<DXW.JustificationValues>
{
  public JustificationValues(): base(){ }
  
  public JustificationValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public JustificationValues(DXW.JustificationValues openXmlElement): base(openXmlElement) { }
  
}
