namespace DocumentModel.Presentation;

/// <summary>
/// Base properties for Notes View.
/// </summary>
public interface ICommonViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Variable Scale
  /// </summary>
  public System.Boolean? VariableScale { get ; set; }
  
  /// <summary>
  /// View Scale.
  /// </summary>
  public DocumentModel.Presentation.IScaleFactor? ScaleFactor { get ; set; }
  
  /// <summary>
  /// View Origin.
  /// </summary>
  public DocumentModel.Presentation.IPoint2DType? Origin { get ; set; }
  
}
