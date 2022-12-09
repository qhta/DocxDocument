namespace DocumentModel.Drawings;

/// <summary>
/// Shape Definition.
/// </summary>
public class Shape4Impl: ModelElementImpl, Shape4
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  /// Text Link
  /// </summary>
  public String? TextLink
  {
    get => (String?)OpenXmlElement?.TextLink?.Value;
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
    get => (Boolean?)OpenXmlElement?.LockText?.Value;
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
    get => (Boolean?)OpenXmlElement?.Published?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Published = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Non-Visual Shape Properties.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties7? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style4? Style
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public TextBody2? TextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
