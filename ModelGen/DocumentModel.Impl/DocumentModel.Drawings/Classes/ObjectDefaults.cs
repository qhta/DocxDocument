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
    get;
    set;
  }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  public LineDefault? LineDefault
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  public TextDefault? TextDefault
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
