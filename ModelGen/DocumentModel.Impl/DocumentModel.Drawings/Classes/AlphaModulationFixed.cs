namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AlphaModulationFixed Class.
/// </summary>
public partial class AlphaModulationFixedImpl: ModelElementImpl, AlphaModulationFixed
{
  public DocumentFormat.OpenXml.Drawing.AlphaModulationFixed? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaModulationFixed?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AlphaModulationFixedImpl(): base() {}
  
  public AlphaModulationFixedImpl(DocumentFormat.OpenXml.Drawing.AlphaModulationFixed openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Amount
  /// </summary>
  public Int32? Amount
  {
    get => (System.Int32?)OpenXmlElement?.Amount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Amount = (System.Int32?)value;
    }
  }
  
}
