namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineReference Class.
/// </summary>
public class LineReferenceImpl: DocumentModel.Drawings.StyleMatrixReferenceTypeImpl, LineReference
{
  public new DocumentFormat.OpenXml.Drawing.LineReference? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineReference?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineReferenceImpl(): base() {}
  
  public LineReferenceImpl(DocumentFormat.OpenXml.Drawing.LineReference openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new RgbColorModelPercentage? RgbColorModelPercentage
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new RgbColorModelHex? RgbColorModelHex
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new HslColor? HslColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new SystemColor? SystemColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new SchemeColor? SchemeColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new PresetColor? PresetColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
