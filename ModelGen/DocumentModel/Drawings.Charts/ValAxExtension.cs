namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ValAxExtension Class.
/// </summary>
public partial class ValAxExtension: ModelElement<DXDC.ValAxExtension>
{
  public ValAxExtension(): base(){ }
  
  public ValAxExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValAxExtension(DXDC.ValAxExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.NumberingFormat? NumberingFormat
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.NumberingFormat>();
      if (element != null)
        return NumberingFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DXO13DC.NumberingFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
