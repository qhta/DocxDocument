namespace DocumentModel.Math;

/// <summary>
/// Argument Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IArgumentSize))]
public class ArgumentProperties: IArgumentProperties
{
  /// <summary>
  /// Argument Size.
  /// </summary>
  public IArgumentSize? ArgumentSize
  {
    get;
    set;
  }
  
}
