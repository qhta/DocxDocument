namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Pivot Format.
/// </summary>
public class PivotFormatImpl: ModelElementImpl, PivotFormat
{
  public DocumentFormat.OpenXml.Drawing.Charts.PivotFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.PivotFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PivotFormatImpl(): base() {}
  
  public PivotFormatImpl(DocumentFormat.OpenXml.Drawing.Charts.PivotFormat openXmlElement): base(openXmlElement)
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
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabel? DataLabel
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
