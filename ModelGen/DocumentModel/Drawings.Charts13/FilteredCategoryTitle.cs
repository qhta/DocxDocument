namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredCategoryTitle Class.
/// </summary>
public partial class FilteredCategoryTitle: ModelElement<DXO13DC.FilteredCategoryTitle>
{
  public FilteredCategoryTitle(): base(){ }
  
  public FilteredCategoryTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredCategoryTitle(DXO13DC.FilteredCategoryTitle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   AxisDataSourceType.
  /// </summary>
  [DataMember]
  public DMDC13.AxisDataSourceType? AxisDataSourceType
  {
    get
    {
      return _Element?.GetObject<DMDC13.AxisDataSourceType,DXO13DC.AxisDataSourceType>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.AxisDataSourceType,DXO13DC.AxisDataSourceType>(value);
    }
  }
  
}
