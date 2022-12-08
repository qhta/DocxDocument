namespace DocumentModel.Drawings;

/// <summary>
/// Alpha Replace Effect.
/// </summary>
public class AlphaReplaceImpl: ModelElementImpl, AlphaReplace
{
  public DocumentFormat.OpenXml.Drawing.AlphaReplace? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaReplace?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Alpha
  /// </summary>
  public Int32? Alpha
  {
    get;
    set;
  }
  
}
