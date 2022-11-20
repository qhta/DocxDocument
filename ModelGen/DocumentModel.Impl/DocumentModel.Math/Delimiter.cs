namespace DocumentModel.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IDelimiterProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public class Delimiter: IDelimiter
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public IDelimiterProperties? DelimiterProperties
  {
    get;
    set;
  }
  
}
