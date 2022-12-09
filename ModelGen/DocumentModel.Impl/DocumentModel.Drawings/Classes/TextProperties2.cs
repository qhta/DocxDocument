namespace DocumentModel.Drawings;

/// <summary>
/// Text Properties.
/// </summary>
public class TextProperties2Impl: ModelElementImpl, TextProperties2
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
