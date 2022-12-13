namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Band Format.
/// </summary>
public class BandFormatImpl: ModelElementImpl, BandFormat
{
  public DocumentFormat.OpenXml.Drawing.Charts.BandFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BandFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BandFormatImpl(): base() {}
  
  public BandFormatImpl(DocumentFormat.OpenXml.Drawing.Charts.BandFormat openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index
  {
    get => (System.UInt32?)OpenXmlElement?.Index?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Index != null)
        {
          if (value is not null)
            OpenXmlElement.Index.Val = (System.UInt32?)value;
          else
            OpenXmlElement.Index = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Index = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
