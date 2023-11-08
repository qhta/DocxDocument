namespace DocumentModel.Wordprocessing;


/// <summary>
///   Subset Fonts When Embedding.
/// </summary>
public partial class SaveSubsetFonts: ModelElement<DXW.SaveSubsetFonts>
{
  public SaveSubsetFonts(): base(){ }
  
  public SaveSubsetFonts(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaveSubsetFonts(DXW.SaveSubsetFonts openXmlElement): base(openXmlElement) { }
  
}
