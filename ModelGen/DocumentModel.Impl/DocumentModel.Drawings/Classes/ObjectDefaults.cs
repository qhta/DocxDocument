namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public class ObjectDefaultsImpl: ModelElementImpl, ObjectDefaults
{
  public DocumentFormat.OpenXml.Drawing.ObjectDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ObjectDefaults?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ObjectDefaultsImpl(): base() {}
  
  public ObjectDefaultsImpl(DocumentFormat.OpenXml.Drawing.ObjectDefaults openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Shape Default.
  /// </summary>
  public DocumentModel.Drawings.ShapeDefault? ShapeDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  public DocumentModel.Drawings.LineDefault? LineDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  public DocumentModel.Drawings.TextDefault? TextDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
