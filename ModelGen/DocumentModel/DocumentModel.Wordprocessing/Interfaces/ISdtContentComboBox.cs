namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
public interface ISdtContentComboBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  public String? LastValue { get ; set; }
  
  public Collection<IListItem>? ListItems { get ; set; }
  
}
