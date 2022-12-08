namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public class ExternalData2Impl: ModelElementImpl, ExternalData2
{
  public DocumentFormat.OpenXml.Drawing.Charts.ExternalData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ExternalData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  public Boolean? AutoUpdate
  {
    get;
    set;
  }
  
}
