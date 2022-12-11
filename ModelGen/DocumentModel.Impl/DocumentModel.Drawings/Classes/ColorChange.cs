namespace DocumentModel.Drawings;

/// <summary>
/// Color Change Effect.
/// </summary>
public class ColorChangeImpl: ModelElementImpl, ColorChange
{
  public DocumentFormat.OpenXml.Drawing.ColorChange? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ColorChange?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorChangeImpl(): base() {}
  
  public ColorChangeImpl(DocumentFormat.OpenXml.Drawing.ColorChange openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Consider Alpha Values
  /// </summary>
  public Boolean? UseAlpha
  {
    get => (Boolean?)OpenXmlElement?.UseAlpha?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UseAlpha = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Change Color From.
  /// </summary>
  public ColorFrom? ColorFrom
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Change Color To.
  /// </summary>
  public ColorTo? ColorTo
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
