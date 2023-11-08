namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the CategoryAxisScaling Class.
/// </summary>
public partial class CategoryAxisScaling: ModelElement<DXO16DCD.CategoryAxisScaling>
{
  public CategoryAxisScaling(): base(){ }
  
  public CategoryAxisScaling(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CategoryAxisScaling(DXO16DCD.CategoryAxisScaling openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? GapWidth
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GapWidth);
    }
    set
    {
      _ExistingElement.GapWidth = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
