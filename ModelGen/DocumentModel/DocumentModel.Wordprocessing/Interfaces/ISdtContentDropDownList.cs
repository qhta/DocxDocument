namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDropDownList Class.
/// </summary>
public interface ISdtContentDropDownList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Drop-down List Last Saved Value
  /// </summary>
  public String? LastValue { get ; set; }
  
  public Collection<IListItem>? ListItems { get ; set; }
  
}
