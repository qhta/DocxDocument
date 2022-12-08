namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Text Class.
/// </summary>
public class Text1Impl: ModelElementImpl, Text1
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
    get;
    set;
  }
  
  /// <summary>
  /// RichTextBody.
  /// </summary>
  public RichTextBody? RichTextBody
  {
    get;
    set;
  }
  
}
