namespace DocumentModel.Drawings;

/// <summary>
/// Shape Style.
/// </summary>
public class Style4Impl: ModelElementImpl, Style4
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Style? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Style?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference2? LineReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public FillReference1? FillReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public EffectReference2? EffectReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public FontReference1? FontReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
