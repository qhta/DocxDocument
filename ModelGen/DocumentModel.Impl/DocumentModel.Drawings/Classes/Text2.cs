namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public class Text2Impl: ModelElementImpl, Text2
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// TextData.
  /// </summary>
  public TextData? TextData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public RichTextBody? RichTextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
