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
    get;
    set;
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  public Int32? SpaceLength
  {
    get;
    set;
  }
  
}
