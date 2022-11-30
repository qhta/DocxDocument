namespace DocumentModel.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public interface IDelimiter // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public DocumentModel.Math.IDelimiterProperties? DelimiterProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Math.IBase>? Bases { get ; set; }
  
}
