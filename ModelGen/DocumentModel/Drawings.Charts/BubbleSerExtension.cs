namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleSerExtension Class.
/// </summary>
public partial class BubbleSerExtension: ModelElement<DXDC.BubbleSerExtension>
{
  public BubbleSerExtension(): base(){ }
  
  public BubbleSerExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BubbleSerExtension(DXDC.BubbleSerExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC10.InvertSolidFillFormat? InvertSolidFillFormat
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DC.InvertSolidFillFormat>();
      if (element != null)
        return InvertSolidFillFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.InvertSolidFillFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InvertSolidFillFormatConverter.CreateOpenXmlElement<DXO10DC.InvertSolidFillFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.FilteredCategoryTitle? FilteredCategoryTitle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
      if (element != null)
        return FilteredCategoryTitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredCategoryTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredCategoryTitleConverter.CreateOpenXmlElement<DXO13DC.FilteredCategoryTitle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.DataLabelsRange? DataLabelsRange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.DataLabelsRange>();
      if (element != null)
        return DataLabelsRangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.DataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsRangeConverter.CreateOpenXmlElement<DXO13DC.DataLabelsRange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.CategoryFilterExceptions? CategoryFilterExceptions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
      if (element != null)
        return CategoryFilterExceptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.CategoryFilterExceptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryFilterExceptionsConverter.CreateOpenXmlElement<DXO13DC.CategoryFilterExceptions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
