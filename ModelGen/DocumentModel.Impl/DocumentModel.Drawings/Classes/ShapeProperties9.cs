namespace DocumentModel.Drawings;

/// <summary>
/// Shape Properties.
/// </summary>
public class ShapeProperties9Impl: ModelElementImpl, ShapeProperties9
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Black and White Mode
  /// </summary>
  public BlackWhiteMode? BlackWhiteMode
  {
    get => (BlackWhiteMode?)OpenXmlElement?.BlackWhiteMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlackWhiteMode = (DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues?)value;
    }
  }
  
  /// <summary>
  /// 2D Transform for Individual Objects.
  /// </summary>
  public Transform2D3? Transform2D
  {
    get;
    set;
  }
  
  public CustomGeometry? CustomGeometry
  {
    get;
    set;
  }
  
  public PresetGeometry? PresetGeometry
  {
    get;
    set;
  }
  
  public Boolean? NoFill
  {
    get;
    set;
  }
  
  public SolidFill? SolidFill
  {
    get;
    set;
  }
  
  public GradientFill? GradientFill
  {
    get;
    set;
  }
  
  public BlipFill2? BlipFill
  {
    get;
    set;
  }
  
  public PatternFill? PatternFill
  {
    get;
    set;
  }
  
  public Boolean? GroupFill
  {
    get;
    set;
  }
  
  public Outline? Outline
  {
    get;
    set;
  }
  
  public EffectList? EffectList
  {
    get;
    set;
  }
  
  public EffectDag? EffectDag
  {
    get;
    set;
  }
  
  public Scene3DType? Scene3DType
  {
    get;
    set;
  }
  
  public Shape3DType? Shape3DType
  {
    get;
    set;
  }
  
  public ShapePropertiesExtensionList? ShapePropertiesExtensionList
  {
    get;
    set;
  }
  
}
