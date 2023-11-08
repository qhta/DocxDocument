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
      var element = _Element?.GetFirstChild<DXM.Justification>();
      if (element != null)
        return JustificationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Justification>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = JustificationConverter.CreateOpenXmlElement<DXM.Justification>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
