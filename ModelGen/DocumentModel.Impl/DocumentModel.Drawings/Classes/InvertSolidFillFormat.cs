namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties9? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
