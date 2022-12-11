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
  
  public SdtContentComboBoxImpl(): base() {}
  
  public SdtContentComboBoxImpl(DocumentFormat.OpenXml.Wordprocessing.SdtContentComboBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Combo Box Last Saved Value
  /// </summary>
  public String? LastValue
  {
    get => (String?)OpenXmlElement?.LastValue?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LastValue = (System.String?)value;
    }
  }
  
  public Collection<ListItem>? ListItems
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
