namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document Endnotes.
/// </summary>
public partial class Endnotes: ModelElement<DXW.Endnotes>
{
  public Endnotes(): base(){ }
  
  public Endnotes(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Endnotes(DXW.Endnotes openXmlElement): base(openXmlElement) { }
  
}
