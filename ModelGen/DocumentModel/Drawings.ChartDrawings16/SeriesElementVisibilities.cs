namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the SeriesElementVisibilities Class.
/// </summary>
public partial class SeriesElementVisibilities: ModelElement<DXO16DCD.SeriesElementVisibilities>
{
  public SeriesElementVisibilities(): base(){ }
  
  public SeriesElementVisibilities(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesElementVisibilities(DXO16DCD.SeriesElementVisibilities openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   connectorLines, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? ConnectorLines
  {
    get
    {
      return _Element?.ConnectorLines?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ConnectorLines = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.ConnectorLines = null;
    }
  }
  
  
  /// <summary>
  ///   meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? MeanLine
  {
    get
    {
      return _Element?.MeanLine?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.MeanLine = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.MeanLine = null;
    }
  }
  
  
  /// <summary>
  ///   meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? MeanMarker
  {
    get
    {
      return _Element?.MeanMarker?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.MeanMarker = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.MeanMarker = null;
    }
  }
  
  
  /// <summary>
  ///   nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Nonoutliers
  {
    get
    {
      return _Element?.Nonoutliers?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Nonoutliers = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Nonoutliers = null;
    }
  }
  
  
  /// <summary>
  ///   outliers, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Outliers
  {
    get
    {
      return _Element?.Outliers?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Outliers = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Outliers = null;
    }
  }
  
}
