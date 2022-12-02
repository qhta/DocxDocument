namespace DocumentModel.Math;

/// <summary>
/// n-ary Operator Function.
/// </summary>
public interface INary // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// n-ary Properties.
  /// </summary>
  public INaryProperties? NaryProperties { get ; set; }
  
  /// <summary>
  /// Lower limit (n-ary) .
  /// </summary>
  public ISubArgument? SubArgument { get ; set; }
  
  /// <summary>
  /// Upper limit (n-ary).
  /// </summary>
  public ISuperArgument? SuperArgument { get ; set; }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public IBase? Base { get ; set; }
  
}
