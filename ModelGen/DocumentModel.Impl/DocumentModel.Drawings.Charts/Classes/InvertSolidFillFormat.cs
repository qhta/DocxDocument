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
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
