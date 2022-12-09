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
  
  /// <summary>
  /// Shape Default.
  /// </summary>
  public ShapeDefault? ShapeDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  public LineDefault? LineDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  public TextDefault? TextDefault
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
