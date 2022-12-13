namespace DocumentModel.Drawings;

/// <summary>
/// Shape Style.
/// </summary>
public class StyleImpl: ModelElementImpl, Style
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Style? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Style?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleImpl(): base() {}
  
  public StyleImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Style openXmlElement): base(openXmlElement)
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
