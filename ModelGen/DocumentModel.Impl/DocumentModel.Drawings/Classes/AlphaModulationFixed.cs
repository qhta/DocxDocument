namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AlphaModulationFixed Class.
/// </summary>
public class AlphaModulationFixedImpl: ModelElementImpl, AlphaModulationFixed
{
  public DocumentFormat.OpenXml.Drawing.AlphaModulationFixed? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaModulationFixed?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Amount
  /// </summary>
  public Int32? Amount
  {
    get => (Int32?)OpenXmlElement?.Amount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Amount = (System.Int32?)value;
    }
  }
  
}
