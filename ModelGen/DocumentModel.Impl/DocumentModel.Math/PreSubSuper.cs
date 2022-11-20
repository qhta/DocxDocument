namespace DocumentModel.Math;

/// <summary>
/// Pre-Sub-Superscript Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.ISubArgument))]
[ChildElementInfo(typeof(DocumentModel.Math.ISuperArgument))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
[ChildElementInfo(typeof(DocumentModel.Math.IPreSubSuperProperties))]
public class PreSubSuper: IPreSubSuper
{
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  public IPreSubSuperProperties? PreSubSuperProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  public ISubArgument? SubArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public ISuperArgument? SuperArgument
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base
  {
    get;
    set;
  }
  
}
