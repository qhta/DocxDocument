namespace DocumentModel.Math;


/// <summary>
///   Office Math Paragraph Properties.
/// </summary>
public partial class ParagraphProperties: ModelElement<DXM.ParagraphProperties>
{
  public ParagraphProperties(): base(){ }
  
  public ParagraphProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphProperties(DXM.ParagraphProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Justification.
  /// </summary>
  [DataMember]
  public DMM.Justification? Justification
  {
    get
    {
      return _Element?.GetObject<DMM.Justification,DXM.Justification>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.Justification,DXM.Justification>(value);
    }
  }
  
}
