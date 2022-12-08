namespace DocumentModel.Vml;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public class ClipPathImpl: ModelElementImpl, ClipPath
{
  public DocumentFormat.OpenXml.Vml.Office.ClipPath? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ClipPath?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Path Definition
  /// </summary>
  public String? Value
  {
    get;
    set;
  }
  
}
