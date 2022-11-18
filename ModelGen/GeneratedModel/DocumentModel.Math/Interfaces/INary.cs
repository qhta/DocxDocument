namespace DocumentModel.Math;

/// <summary>
/// n-ary Operator Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.INaryProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.ISubArgument))]
[ChildElementInfo(typeof(DocumentModel.Math.ISuperArgument))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public interface INary // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
