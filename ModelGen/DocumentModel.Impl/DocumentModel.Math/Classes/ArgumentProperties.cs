namespace DocumentModel.Math;

/// <summary>
/// Argument Properties.
/// </summary>
public class ArgumentPropertiesImpl: ModelElementImpl, ArgumentProperties
{
  public DocumentFormat.OpenXml.Math.ArgumentProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.ArgumentProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Argument Size.
  /// </summary>
  public Int32? ArgumentSize
  {
    get;
    set;
  }
  
}
