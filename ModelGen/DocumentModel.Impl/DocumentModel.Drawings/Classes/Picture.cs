namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Picture Class.
/// </summary>
public class PictureImpl: ModelElementImpl, Picture
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PictureImpl(): base() {}
  
  public PictureImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.Picture openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro
  {
    get => (String?)OpenXmlElement?.Macro?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Macro = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published
  {
    get => (Boolean?)OpenXmlElement?.Published?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Published = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public NonVisualPictureProperties? NonVisualPictureProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public BlipFill? BlipFill
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Style.
  /// </summary>
  public Style? Style
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
