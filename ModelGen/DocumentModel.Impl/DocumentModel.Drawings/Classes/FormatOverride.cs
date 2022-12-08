namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FormatOverride Class.
/// </summary>
public class FormatOverrideImpl: ModelElementImpl, FormatOverride
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
