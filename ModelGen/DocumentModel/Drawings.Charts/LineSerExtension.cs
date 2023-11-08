namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the LineSerExtension Class.
/// </summary>
public partial class LineSerExtension: ModelElement<DXDC.LineSerExtension>
{
  public LineSerExtension(): base(){ }
  
  public LineSerExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSerExtension(DXDC.LineSerExtension openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC13.FilteredSeriesTitle? FilteredSeriesTitle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FilteredSeriesTitle>();
      if (element != null)
        return FilteredSeriesTitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FilteredSeriesTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredSeriesTitleConverter.CreateOpenXmlElement<DXO13DC.FilteredSeriesTitle>(value);
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
