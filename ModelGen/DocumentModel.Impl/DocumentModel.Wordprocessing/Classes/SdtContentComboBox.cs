namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentComboBox Class.
/// </summary>
public class SdtContentComboBoxImpl: ModelElementImpl, SdtContentComboBox
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  public String? LastValue
  {
    get;
    set;
  }
  
  public Collection<ListItem>? ListItems
  {
    get;
    set;
  }
  
}
