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
      return _Element?.GetObject<DMDC10.InvertSolidFillFormat,DXO10DC.InvertSolidFillFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.InvertSolidFillFormat,DXO10DC.InvertSolidFillFormat>(value);
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
