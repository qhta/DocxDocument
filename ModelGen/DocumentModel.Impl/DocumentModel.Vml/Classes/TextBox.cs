namespace DocumentModel.Vml;

/// <summary>
/// Defines the TextBox Class.
/// </summary>
public class TextBoxImpl: ModelElement<DocumentFormat.OpenXml.Vml.TextBox>, TextBox
{
  public DocumentModel.Wordprocessing.TextBoxContent? TextBoxContent
  {
    get;
    set;
  }
  
}
