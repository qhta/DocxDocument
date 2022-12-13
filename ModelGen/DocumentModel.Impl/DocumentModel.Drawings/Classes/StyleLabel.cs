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
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// 3-D Scene.
  /// </summary>
  public DocumentModel.Drawings.Scene3D? Scene3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// 3-D Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Shape3D? Shape3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Properties.
  /// </summary>
  public DocumentModel.Drawings.TextProperties? TextProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Style? Style
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
