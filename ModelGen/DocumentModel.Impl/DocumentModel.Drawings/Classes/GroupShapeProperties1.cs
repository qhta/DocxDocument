namespace DocumentModel.Drawings;

/// <summary>
/// Group Shape Properties.
/// </summary>
public class GroupShapeProperties1Impl: ModelElementImpl, GroupShapeProperties1
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.GroupShapeProperties?)_OpenXmlElement;
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
  /// 2D Transform for Grouped Objects.
  /// </summary>
  public TransformGroup? TransformGroup
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
  
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
