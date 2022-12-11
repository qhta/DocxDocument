namespace DocumentModel.Drawings;

/// <summary>
/// Text Properties.
/// </summary>
public class TextPropertiesImpl: ModelElementImpl, TextProperties
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextPropertiesImpl(): base() {}
  
  public TextPropertiesImpl(DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  public Shape3DType? Shape3DType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  public FlatText? FlatText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
