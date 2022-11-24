namespace DocumentModel.Presentation;

/// <summary>
/// Base properties for Notes View.
/// </summary>
public interface ICommonViewProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Variable Scale
  /// </summary>
  public Boolean? VariableScale { get ; set; }
  
  /// <summary>
  /// View Scale.
  /// </summary>
  public IScaleFactor? ScaleFactor { get ; set; }
  
  /// <summary>
  /// View Origin.
  /// </summary>
  public IOrigin? Origin { get ; set; }
  
}
