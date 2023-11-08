namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StrDataExtension Class.
/// </summary>
public partial class StrDataExtension: ModelElement<DXDC.StrDataExtension>
{
  public StrDataExtension(): base(){ }
  
  public StrDataExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrDataExtension(DXDC.StrDataExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.AutoGeneneratedCategories? AutoGeneneratedCategories
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.AutoGeneneratedCategories>();
      if (element != null)
        return AutoGeneneratedCategoriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.AutoGeneneratedCategories>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoGeneneratedCategoriesConverter.CreateOpenXmlElement<DXO13DC.AutoGeneneratedCategories>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
