namespace DocumentModel.Drawings;

/// <summary>
/// Style Label.
/// </summary>
public class ColorTransformStyleLabelImpl: ModelElementImpl, ColorTransformStyleLabel
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorTransformStyleLabelImpl(): base() {}
  
  public ColorTransformStyleLabelImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
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
  /// Fill Color List.
  /// </summary>
  public DocumentModel.Drawings.FillColorList? FillColorList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  public DocumentModel.Drawings.LineColorList? LineColorList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  public DocumentModel.Drawings.EffectColorList? EffectColorList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  public DocumentModel.Drawings.TextLineColorList? TextLineColorList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  public DocumentModel.Drawings.TextFillColorList? TextFillColorList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  public DocumentModel.Drawings.TextEffectColorList? TextEffectColorList
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
