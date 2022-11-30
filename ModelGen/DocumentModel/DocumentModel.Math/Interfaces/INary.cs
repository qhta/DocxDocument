namespace DocumentModel.Math;

/// <summary>
/// n-ary Operator Function.
/// </summary>
public interface INary // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// n-ary Properties.
  /// </summary>
  public DocumentModel.Math.INaryProperties? NaryProperties { get ; set; }
  
  /// <summary>
  /// Lower limit (n-ary) .
  /// </summary>
  public DocumentModel.Math.ISubArgument? SubArgument { get ; set; }
  
  /// <summary>
  /// Upper limit (n-ary).
  /// </summary>
  public DocumentModel.Math.ISuperArgument? SuperArgument { get ; set; }
  
  /// <summary>
  /// Base (Argument).
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
