namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public class TextBodyTypeImpl: ModelElementImpl, TextBodyType
{
  public DocumentFormat.OpenXml.Drawing.Charts.TextBodyType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.TextBodyType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TextBodyTypeImpl(): base() {}
  
  public TextBodyTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.TextBodyType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Body Properties.
  /// </summary>
  public virtual BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public virtual ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
