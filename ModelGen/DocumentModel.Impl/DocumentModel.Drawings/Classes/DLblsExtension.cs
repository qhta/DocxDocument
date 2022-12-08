namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblsExtension Class.
/// </summary>
public class DLblsExtensionImpl: ModelElementImpl, DLblsExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DLblsExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public ChartText2? ChartText
  {
    get;
    set;
  }
  
  public DataLabelFieldTable? DataLabelFieldTable
  {
    get;
    set;
  }
  
  public Boolean? ShowDataLabelsRange
  {
    get;
    set;
  }
  
  public ShapeProperties3? ShapeProperties
  {
    get;
    set;
  }
  
  public Layout1? Layout
  {
    get;
    set;
  }
  
  public Boolean? ShowLeaderLines
  {
    get;
    set;
  }
  
  public LeaderLines1? LeaderLines
  {
    get;
    set;
  }
  
}
