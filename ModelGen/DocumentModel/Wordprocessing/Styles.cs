namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies all of the style information stored in the WordprocessingML document: style definitions as well as latent style information.
/// </summary>
public partial class Styles: ModelElement<DXW.Styles>
{
  public Styles(): base(){ }
  
  public Styles(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Styles(DXW.Styles openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  [DataMember]
  public DMW.DocDefaults? DocDefaults
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocDefaults>();
      if (element != null)
        return DocDefaultsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocDefaultsConverter.CreateOpenXmlElement<DXW.DocDefaults>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  [DataMember]
  public DMW.LatentStyles? LatentStyles
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.LatentStyles>();
      if (element != null)
        return LatentStylesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LatentStyles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LatentStylesConverter.CreateOpenXmlElement<DXW.LatentStyles>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
