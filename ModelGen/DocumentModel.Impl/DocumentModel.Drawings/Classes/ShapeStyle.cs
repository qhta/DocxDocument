namespace DocumentModel.Drawings;

/// <summary>
/// Style.
/// </summary>
public class ShapeStyleImpl: ModelElementImpl, ShapeStyle
{
  public DocumentFormat.OpenXml.Drawing.ShapeStyle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapeStyle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeStyleImpl(): base() {}
  
  public ShapeStyleImpl(DocumentFormat.OpenXml.Drawing.ShapeStyle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Drawings.LineReference? LineReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Drawings.FillReference? FillReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Drawings.EffectReference? EffectReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public DocumentModel.Drawings.FontReference? FontReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
