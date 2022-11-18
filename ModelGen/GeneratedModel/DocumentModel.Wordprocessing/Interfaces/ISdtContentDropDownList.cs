namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IListItem))]
public interface ISdtContentDropDownList // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public string? LastValue { get ; set; }
  
}
