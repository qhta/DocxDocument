namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
public interface ISdtPlaceholder // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  public System.String? DocPartReference { get ; set; }
  
}
