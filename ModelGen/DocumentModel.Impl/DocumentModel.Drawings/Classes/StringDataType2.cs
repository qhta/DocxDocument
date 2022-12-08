namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public class StringDataType2Impl: ModelElementImpl, StringDataType2
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// PointCount.
  /// </summary>
  public virtual UInt32? PointCount
  {
    get;
    set;
  }
  
}
