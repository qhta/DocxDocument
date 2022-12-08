namespace DocumentModel.Drawings;

/// <summary>
/// Shape Style.
/// </summary>
public class Style1Impl: ModelElementImpl, Style1
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Style? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Style?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public LineReference1? LineReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public FillReference1? FillReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public EffectReference2? EffectReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Reference.
  /// </summary>
  public FontReference2? FontReference
  {
    get;
    set;
  }
  
}
