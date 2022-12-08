namespace DocumentModel.Drawings;

/// <summary>
/// Text Run.
/// </summary>
public class RunImpl: ModelElementImpl, Run
{
  public DocumentFormat.OpenXml.Drawing.Run? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Run?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public String? Text
  {
    get;
    set;
  }
  
}
