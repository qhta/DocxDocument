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
    get
    {
      return _Element?.SeriesName?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SeriesName = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SeriesName = null;
    }
  }
  
  
  /// <summary>
  ///   categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? CategoryName
  {
    get
    {
      return _Element?.CategoryName?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.CategoryName = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.CategoryName = null;
    }
  }
  
  
  /// <summary>
  ///   value, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Value
  {
    get
    {
      return _Element?.Value?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Value = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Value = null;
    }
  }
  
}
