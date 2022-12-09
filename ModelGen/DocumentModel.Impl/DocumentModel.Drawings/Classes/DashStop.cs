namespace DocumentModel.Drawings;

/// <summary>
/// Dash Stop.
/// </summary>
public class DashStopImpl: ModelElementImpl, DashStop
{
  public DocumentFormat.OpenXml.Drawing.DashStop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.DashStop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Dash Length
  /// </summary>
  public Int32? DashLength
  {
    get => (Int32?)OpenXmlElement?.DashLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DashLength = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  public Int32? SpaceLength
  {
    get => (Int32?)OpenXmlElement?.SpaceLength?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SpaceLength = (System.Int32?)value;
    }
  }
  
}
