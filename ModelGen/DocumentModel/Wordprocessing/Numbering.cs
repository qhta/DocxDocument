namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definitions.
/// </summary>
public partial class Numbering: ModelElement<DXW.Numbering>
{
  public Numbering(): base(){ }
  
  public Numbering(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Numbering(DXW.Numbering openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.NumberingIdMacAtCleanup? NumberingIdMacAtCleanup
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NumberingIdMacAtCleanup>();
      if (element != null)
        return NumberingIdMacAtCleanupConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NumberingIdMacAtCleanup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingIdMacAtCleanupConverter.CreateOpenXmlElement<DXW.NumberingIdMacAtCleanup>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
