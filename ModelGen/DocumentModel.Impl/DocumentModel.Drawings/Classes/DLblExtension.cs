namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public class DLblExtensionImpl: ModelElementImpl, DLblExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.DLblExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DLblExtension?)_OpenXmlElement;
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
  
  public DataLabelFieldTable? DataLabelFieldTable
  {
    get;
    set;
  }
  
  public Boolean? ExceptionForSave
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
  
}
