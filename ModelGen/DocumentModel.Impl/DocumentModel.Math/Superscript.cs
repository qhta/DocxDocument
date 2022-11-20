namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
[ChildElementInfo(typeof(DocumentModel.Math.ISuperArgument))]
[ChildElementInfo(typeof(DocumentModel.Math.ISuperscriptProperties))]
public class Superscript: ISuperscript
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public ISuperscriptProperties? SuperscriptProperties
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
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public ISuperArgument? SuperArgument
  {
    get;
    set;
  }
  
}
