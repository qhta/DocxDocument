namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the FillTextEffect Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.INoFillEmpty))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IGradientFillProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ISolidColorFillProperties))]
public class FillTextEffect: IFillTextEffect
{
  /// <summary>
  /// NoFillEmpty.
  /// </summary>
  public INoFillEmpty? NoFillEmpty
  {
    get;
    set;
  }
  
  /// <summary>
  /// SolidColorFillProperties.
  /// </summary>
  public ISolidColorFillProperties? SolidColorFillProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// GradientFillProperties.
  /// </summary>
  public IGradientFillProperties? GradientFillProperties
  {
    get;
    set;
  }
  
}
