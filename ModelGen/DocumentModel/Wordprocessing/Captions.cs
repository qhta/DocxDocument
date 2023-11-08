namespace DocumentModel.Wordprocessing;


/// <summary>
///   Caption Settings.
/// </summary>
public partial class Captions: ModelElement<DXW.Captions>
{
  public Captions(): base(){ }
  
  public Captions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Captions(DXW.Captions openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.AutoCaptions? AutoCaptions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AutoCaptions>();
      if (element != null)
        return AutoCaptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AutoCaptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoCaptionsConverter.CreateOpenXmlElement<DXW.AutoCaptions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
