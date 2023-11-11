namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BarSerExtension Class.
/// </summary>
public partial class BarSerExtension: ModelElement<DXDC.BarSerExtension>
{
  public BarSerExtension(): base(){ }
  
  public BarSerExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarSerExtension(DXDC.BarSerExtension openXmlElement): base(openXmlElement) { }
  
  
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
      return _Element?.GetObject<DMDC10.InvertSolidFillFormat,DXO10DC.InvertSolidFillFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.InvertSolidFillFormat,DXO10DC.InvertSolidFillFormat>(value);
    }
  }
  
  [DataMember]
  public DMDC13.FilteredSeriesTitle? FilteredSeriesTitle
  {
    get
    {
      return _Element?.GetObject<DMDC13.FilteredSeriesTitle,DXO13DC.FilteredSeriesTitle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredSeriesTitle,DXO13DC.FilteredSeriesTitle>(value);
    }
  }
  
  [DataMember]
  public DMDC13.FilteredCategoryTitle? FilteredCategoryTitle
  {
    get
    {
      return _Element?.GetObject<DMDC13.FilteredCategoryTitle,DXO13DC.FilteredCategoryTitle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredCategoryTitle,DXO13DC.FilteredCategoryTitle>(value);
    }
  }
  
  [DataMember]
  public DMDC13.DataLabelsRange? DataLabelsRange
  {
    get
    {
      return _Element?.GetObject<DMDC13.DataLabelsRange,DXO13DC.DataLabelsRange>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.DataLabelsRange,DXO13DC.DataLabelsRange>(value);
    }
  }
  
  [DataMember]
  public DMDC13.CategoryFilterExceptions? CategoryFilterExceptions
  {
    get
    {
      return _Element?.GetObject<DMDC13.CategoryFilterExceptions,DXO13DC.CategoryFilterExceptions>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.CategoryFilterExceptions,DXO13DC.CategoryFilterExceptions>(value);
    }
  }
  
}
