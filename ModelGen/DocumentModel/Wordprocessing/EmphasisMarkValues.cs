namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EmphasisMarkValues enumeration.
/// </summary>
public partial class EmphasisMarkValues: ModelElement<DXW.EmphasisMarkValues>
{
  public EmphasisMarkValues(): base(){ }
  
  public EmphasisMarkValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmphasisMarkValues(DXW.EmphasisMarkValues openXmlElement): base(openXmlElement) { }
  
}
