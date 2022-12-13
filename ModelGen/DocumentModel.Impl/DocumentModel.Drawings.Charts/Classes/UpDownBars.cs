namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the UpDownBars Class.
/// </summary>
public class UpDownBarsImpl: ModelElementImpl, UpDownBars
{
  public DocumentFormat.OpenXml.Drawing.Charts.UpDownBars? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpDownBars?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public UpDownBarsImpl(): base() {}
  
  public UpDownBarsImpl(DocumentFormat.OpenXml.Drawing.Charts.UpDownBars openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gap Width.
  /// </summary>
  public UInt16? GapWidth
  {
    get => (System.UInt16?)OpenXmlElement?.GapWidth?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.GapWidth != null)
        {
          if (value is not null)
            OpenXmlElement.GapWidth.Val = (System.UInt16?)value;
          else
            OpenXmlElement.GapWidth = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.GapWidth = new DocumentFormat.OpenXml.Drawing.Charts.GapWidth{ Val = (System.UInt16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Up Bars.
  /// </summary>
  public DocumentModel.Drawings.Charts.UpBars? UpBars
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Down Bars.
  /// </summary>
  public DocumentModel.Drawings.Charts.DownBars? DownBars
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
