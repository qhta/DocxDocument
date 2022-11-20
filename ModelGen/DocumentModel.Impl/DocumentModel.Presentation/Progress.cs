namespace DocumentModel.Presentation;

/// <summary>
/// Progress.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IFloatVariantValue))]
public class Progress: IProgress
{
  /// <summary>
  /// Float Value.
  /// </summary>
  public IFloatVariantValue? FloatVariantValue
  {
    get;
    set;
  }
  
}
