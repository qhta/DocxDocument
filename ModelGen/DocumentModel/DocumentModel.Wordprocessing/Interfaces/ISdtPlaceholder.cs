namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtPlaceholder Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDocPartReference))]
public interface ISdtPlaceholder // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Document Part Reference.
  /// </summary>
  public IDocPartReference? DocPartReference { get ; set; }
  
}
