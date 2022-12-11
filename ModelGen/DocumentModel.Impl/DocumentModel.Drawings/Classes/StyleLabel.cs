namespace DocumentModel.Drawings;

/// <summary>
/// Style Label.
/// </summary>
public class StyleLabelImpl: ModelElementImpl, StyleLabel
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleLabelImpl(): base() {}
  
  public StyleLabelImpl(DocumentFormat.OpenXml.Drawing.Diagrams.StyleLabel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Style Name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public Scene3D? Scene3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public Shape3D? Shape3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public TextProperties? TextProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public Style? Style
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
