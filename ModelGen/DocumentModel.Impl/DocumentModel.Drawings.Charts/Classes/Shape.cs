namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Shape Definition.
/// </summary>
public class ShapeImpl: ModelElementImpl, Shape
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeImpl(): base() {}
  
  public ShapeImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro
  {
    get => (System.String?)OpenXmlElement?.Macro?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Macro = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public String? TextLink
  {
    get => (System.String?)OpenXmlElement?.TextLink?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TextLink = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Lock Text
  /// </summary>
  public Boolean? LockText
  {
    get => (System.Boolean?)OpenXmlElement?.LockText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LockText = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Publish to Server
  /// </summary>
  public Boolean? Published
  {
    get => (System.Boolean?)OpenXmlElement?.Published?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Published = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualShapeProperties? NonVisualShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Charts.Style? Style
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextBody? TextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
