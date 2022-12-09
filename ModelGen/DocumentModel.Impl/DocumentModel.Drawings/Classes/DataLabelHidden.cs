namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelHidden Class.
/// </summary>
public class DataLabelHiddenImpl: ModelElementImpl, DataLabelHidden
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
  {
    get => (UInt32?)OpenXmlElement?.Idx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Idx = (System.UInt32?)value;
    }
  }
  
}
