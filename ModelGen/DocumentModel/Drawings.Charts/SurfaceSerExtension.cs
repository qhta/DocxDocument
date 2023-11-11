namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceSerExtension Class.
/// </summary>
public partial class SurfaceSerExtension: ModelElement<DXDC.SurfaceSerExtension>
{
  public SurfaceSerExtension(): base(){ }
  
  public SurfaceSerExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceSerExtension(DXDC.SurfaceSerExtension openXmlElement): base(openXmlElement) { }
  
  
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
