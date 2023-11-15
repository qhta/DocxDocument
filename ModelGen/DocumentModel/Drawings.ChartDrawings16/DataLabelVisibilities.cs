namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the DataLabelVisibilities Class.
/// </summary>
public partial class DataLabelVisibilities: ModelElement<DXO16DCD.DataLabelVisibilities>
{
  public DataLabelVisibilities(): base(){ }
  
  public DataLabelVisibilities(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelVisibilities(DXO16DCD.DataLabelVisibilities openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? SeriesName
  {
    get => _Element?.SeriesName?.Value;
    set => _ExistingElement.SeriesName = value;
  }
  
  
  /// <summary>
  ///   categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? CategoryName
  {
    get => _Element?.CategoryName?.Value;
    set => _ExistingElement.CategoryName = value;
  }
  
  
  /// <summary>
  ///   value, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Value
  {
    get => _Element?.Value?.Value;
    set => _ExistingElement.Value = value;
  }
  
}
