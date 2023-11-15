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
    get => _Element?.ConnectorLines?.Value;
    set => _ExistingElement.ConnectorLines = value;
  }
  
  
  /// <summary>
  ///   meanLine, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? MeanLine
  {
    get => _Element?.MeanLine?.Value;
    set => _ExistingElement.MeanLine = value;
  }
  
  
  /// <summary>
  ///   meanMarker, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? MeanMarker
  {
    get => _Element?.MeanMarker?.Value;
    set => _ExistingElement.MeanMarker = value;
  }
  
  
  /// <summary>
  ///   nonoutliers, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Nonoutliers
  {
    get => _Element?.Nonoutliers?.Value;
    set => _ExistingElement.Nonoutliers = value;
  }
  
  
  /// <summary>
  ///   outliers, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Outliers
  {
    get => _Element?.Outliers?.Value;
    set => _ExistingElement.Outliers = value;
  }
  
}
