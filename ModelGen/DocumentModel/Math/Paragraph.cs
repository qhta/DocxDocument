namespace DocumentModel.Math;


/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public partial class Paragraph: ModelElement<DXM.Paragraph>
{
  public Paragraph(): base(){ }
  
  public Paragraph(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Paragraph(DXM.Paragraph openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Office Math Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMM.ParagraphProperties? ParagraphProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ParagraphProperties,DXM.ParagraphProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ParagraphProperties,DXM.ParagraphProperties>(value);
    }
  }
  
}
