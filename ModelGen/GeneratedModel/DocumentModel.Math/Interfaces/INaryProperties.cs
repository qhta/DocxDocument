namespace DocumentModel.Math;

public interface INaryProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IAccentChar? AccentChar { get ; set; }
  
  public ILimitLocation? LimitLocation { get ; set; }
  
  public IGrowOperators? GrowOperators { get ; set; }
  
  public IHideSubArgument? HideSubArgument { get ; set; }
  
  public IHideSuperArgument? HideSuperArgument { get ; set; }
  
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
