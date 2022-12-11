namespace DocumentModel.Drawings;

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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
        return (UInt32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Index>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.UInt32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Index{ Val = (System.UInt32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
