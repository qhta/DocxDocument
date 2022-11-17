namespace DocumentModel.Math;

public interface IDelimiterProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IBeginChar? BeginChar { get ; set; }

  public ISeparatorChar? SeparatorChar { get ; set; }

  public IEndChar? EndChar { get ; set; }

  public IGrowOperators? GrowOperators { get ; set; }

  public DocumentModel.Math.IShape? Shape { get ; set; }

  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }

}
