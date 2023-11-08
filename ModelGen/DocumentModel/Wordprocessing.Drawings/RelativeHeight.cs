namespace DocumentModel.Wordprocessing.Drawings;


/// <summary>
///   Defines the RelativeHeight Class.
/// </summary>
public partial class RelativeHeight: ModelElement<DXO10WD.RelativeHeight>
{
  public RelativeHeight(): base(){ }
  
  public RelativeHeight(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelativeHeight(DXO10WD.RelativeHeight openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PercentageHeight.
  /// </summary>
  [DataMember]
  public DMWD.PercentageHeight? PercentageHeight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10WD.PercentageHeight>();
      if (element != null)
        return PercentageHeightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10WD.PercentageHeight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PercentageHeightConverter.CreateOpenXmlElement<DXO10WD.PercentageHeight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
