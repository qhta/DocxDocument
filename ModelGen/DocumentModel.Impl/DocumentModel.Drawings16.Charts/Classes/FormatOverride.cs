namespace DocumentModel.Drawings16.Charts;

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
  
  public FormatOverrideImpl(): base() {}
  
  public FormatOverrideImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverride openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx
  {
    get => (System.UInt32?)OpenXmlElement?.Idx?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Idx = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
