namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public interface IVbaSuppData // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// DocEvents.
  /// </summary>
  public DocumentModel.Office.Word.IDocEvents? DocEvents { get ; set; }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? Mcds { get ; set; }
  
}
