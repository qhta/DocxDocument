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
      var element = _Element?.GetFirstChild<DXO13DC.AxisDataSourceType>();
      if (element != null)
        return AxisDataSourceTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.AxisDataSourceType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisDataSourceTypeConverter.CreateOpenXmlElement<DXO13DC.AxisDataSourceType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
