namespace DocumentModel.Drawings;

/// <summary>
/// Relative Offset Effect.
/// </summary>
public class RelativeOffsetImpl: ModelElementImpl, RelativeOffset
{
  public DocumentFormat.OpenXml.Drawing.RelativeOffset? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.RelativeOffset?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Offset X
  /// </summary>
  public Int32? OffsetX
  {
    get;
    set;
  }
  
  /// <summary>
  /// Offset Y
  /// </summary>
  public Int32? OffsetY
  {
    get;
    set;
  }
  
}
