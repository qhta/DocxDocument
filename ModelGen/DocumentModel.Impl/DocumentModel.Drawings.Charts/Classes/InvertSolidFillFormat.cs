namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public class InvertSolidFillFormatImpl: ModelElementImpl, InvertSolidFillFormat
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public InvertSolidFillFormatImpl(): base() {}
  
  public InvertSolidFillFormatImpl(DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties2? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Charts.ShapeProperties2Impl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Charts.ShapeProperties2Impl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
