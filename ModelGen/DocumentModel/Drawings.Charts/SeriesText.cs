namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Series Text.
/// </summary>
public partial class SeriesText: ModelElement<DXDC.SeriesText>
{
  public SeriesText(): base(){ }
  
  public SeriesText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesText(DXDC.SeriesText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   StringReference.
  /// </summary>
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StringReference>();
      if (element != null)
        return StringReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringReferenceConverter.CreateOpenXmlElement<DXDC.StringReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   NumericValue.
  /// </summary>
  [DataMember]
  public DMDC.NumericValue? NumericValue
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumericValue>();
      if (element != null)
        return NumericValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumericValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumericValueConverter.CreateOpenXmlElement<DXDC.NumericValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
