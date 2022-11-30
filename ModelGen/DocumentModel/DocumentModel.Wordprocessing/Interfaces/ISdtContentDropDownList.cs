namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public interface ISdtContentDropDownList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public System.String? LastValue { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IListItem>? ListItems { get ; set; }
  
}
