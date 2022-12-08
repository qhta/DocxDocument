namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelsRange Class.
/// </summary>
public class DataLabelsRangeImpl: ModelElementImpl, DataLabelsRange
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabelsRangeChache.
  /// </summary>
  public DataLabelsRangeChache? DataLabelsRangeChache
  {
    get;
    set;
  }
  
}
