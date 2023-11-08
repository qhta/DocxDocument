namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeWidth Class.
/// </summary>
public partial class RelativeWidth: ModelElement<DXO10WD.RelativeWidth>
{
  public RelativeWidth(): base(){ }
  
  public RelativeWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeWidth(DXO10WD.RelativeWidth openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PercentageWidth.
  /// </summary>
  [DataMember]
  public DMWD.PercentageWidth? PercentageWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10WD.PercentageWidth>();
      if (element != null)
        return PercentageWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10WD.PercentageWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PercentageWidthConverter.CreateOpenXmlElement<DXO10WD.PercentageWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
